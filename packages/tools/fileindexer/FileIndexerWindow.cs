﻿// ****************************************************************************
// 
// Copyright (C) 2005-2014 Doom9 & al
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
// 
// ****************************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

using MeGUI.core.details;
using MeGUI.core.util;

namespace MeGUI
{
    /// <summary>
    /// Summary description for File Indexer.
    /// </summary>
    public partial class FileIndexerWindow : Form
    {
        public enum IndexType
        {
            AVISOURCE, D2V, DGA, DGI, FFMS, LSMASH, NONE
        };

        #region variables
        private LogItem _oLog;
        private IndexType IndexerUsed = IndexType.D2V;
        private string strVideoCodec = "";
        private string strVideoScanType = "";
        private string strContainerFormat = "";
        private List<AudioTrackInfo> audioTracks = new List<AudioTrackInfo>();
        private bool dialogMode = false; // $%£%$^>*"%$%%$#{"!!! Affects the public behaviour!
        private bool configured = false;
        private MainForm mainForm;
        private VideoUtil vUtil;
        private JobUtil jobUtil;
        #endregion

        #region start / stop
        public void setConfig(string input, string projectName, int demuxType,
            bool showCloseOnQueue, bool closeOnQueue, bool loadOnComplete, bool updateMode)
        {
            openVideo(input);
            if (!string.IsNullOrEmpty(projectName))
                this.output.Text = projectName;
            if (demuxType == 0)
                demuxNoAudiotracks.Checked = true;
            else
                demuxAll.Checked = true;
            this.loadOnComplete.Checked = loadOnComplete;
            if (updateMode)
            {
                this.dialogMode = true;
                queueButton.Text = "更新";
            }
            else
                this.dialogMode = false;
            checkIndexIO();
            if (!showCloseOnQueue)
            {
                this.closeOnQueue.Hide();
                this.Controls.Remove(this.closeOnQueue);
            }
            this.closeOnQueue.Checked = closeOnQueue;
        }

        public FileIndexerWindow(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.vUtil = new VideoUtil(mainForm);
            this.jobUtil = new JobUtil(mainForm);
            CheckDGIIndexer();
        }

        public FileIndexerWindow(MainForm mainForm, string fileName)
            : this(mainForm)
        {
            CheckDGIIndexer();
            openVideo(fileName);
        }

        public FileIndexerWindow(MainForm mainForm, string fileName, bool autoReturn)
            : this(mainForm, fileName)
        {
            CheckDGIIndexer();
            openVideo(fileName);
            this.loadOnComplete.Checked = true;
            this.closeOnQueue.Checked = true;
            checkIndexIO();
        }

        private void CheckDGIIndexer()
        {
            string filter = "所有 DGAVCIndex 支援的檔案|*.264;*.h264;*.avc;*.m2t*;*.m2ts;*.mts;*.tp;*.ts;*.trp";
            filter += "|所有 DGIndex 支援的檔案|*.vob;*.mpg;*.mpeg;*.m1v;*.m2v;*.mpv;*.tp;*.ts;*.trp;*.m2t;*.m2ts;*.pva;*.vro";
            filter += "|所有 FFMS Indexer 支援的檔案|*.mkv;*.avi;*.mp4;*.flv;*.wmv;*.ogm;*.vob;*.mpg;*.m2ts;*.ts";
            filter += "|所有 LSMASH Indexer 支援的檔案|*.mkv;*.avi;*.mp4;*.flv;*.wmv;*.ogm;*.vob;*.mpg;*.m2ts;*.ts";
            if (MainForm.Instance.Settings.IsDGIIndexerAvailable())
            {
                filter += "|所有 DGIndexNV 支援的檔案|*.264;*.h264;*.avc;*.m2v;*.mpv;*.vc1;*.mkv;*.vob;*.mp4;*.mpg;*.mpeg;*.m2t;*.m2ts;*.mts;*.tp;*.ts;*.trp";
                filter += "|所有支援的檔案|*.mkv;*.avi;*.mp4;*.flv;*.wmv;*.ogm;*.264;*.h264;*.avc;*.m2t*;*.m2ts;*.mts;*.tp;*.ts;*.trp;*.vob;*.mpg;*.mpeg;*.m1v;*.m2v;*.mpv;*.pva;*.vro;*.vc1|所有檔案|*.*";
                input.Filter = filter;
                input.FilterIndex = 6;
            }
            else
            {
                filter += "|所有支援的檔案|*.mkv;*.avi;*.mp4;*.flv;*.wmv;*.ogm;*.264;*.h264;*.avc;*.m2t*;*.m2ts;*.mts;*.tp;*.ts;*.trp;*.vob;*.mpg;*.mpeg;*.m1v;*.m2v;*.mpv;*.pva;*.vro|所有檔案|*.*";
                input.Filter = filter;
                input.FilterIndex = 5;
            }
        }

        private void changeIndexer(IndexType dgType)
        {
            switch (dgType)
            {
                case IndexType.DGI:
                    {
                        this.saveProjectDialog.Filter = "DGIndexNV 專案檔案|*.dgi";
                        if (this.demuxTracks.Checked)
                            this.demuxAll.Checked = true;
                        this.demuxTracks.Enabled = false;
                        //this.gbAudio.Enabled = true;
                        this.gbAudio.Text = " 音訊提取 ";
                        this.gbOutput.Enabled = true;
                        this.demuxVideo.Enabled = true;
                        IndexerUsed = IndexType.DGI;
                        btnDGI.Checked = true;
                        if (txtContainerInformation.Text.Trim().ToUpperInvariant().Equals("MATROSKA"))
                            generateAudioList();
                        break;
                    }
                case IndexType.DGA:
                    {
                        this.saveProjectDialog.Filter = "DGAVCIndex 專案檔案|*.dga";
                        //this.gbOutput.Enabled = true;
                        this.gbAudio.Enabled = true;
                        this.gbAudio.Text = " 音訊提取 ";
                        if (this.demuxTracks.Checked)
                            this.demuxAll.Checked = true;
                        this.demuxTracks.Enabled = false;
                        this.demuxVideo.Enabled = true;
                        IndexerUsed = IndexType.DGA;
                        btnDGA.Checked = true;
                        break;
                    }
                case IndexType.D2V:
                    {
                        this.saveProjectDialog.Filter = "DGIndex 專案檔案|*.d2v";
                        this.demuxTracks.Enabled = true;
                        //this.gbOutput.Enabled = true;
                        this.gbAudio.Text = " 音訊提取 ";
                        this.gbAudio.Enabled = true;
                        this.demuxVideo.Enabled = true;
                        IndexerUsed = IndexType.D2V;
                        btnD2V.Checked = true;
                        break;
                    }
                case IndexType.FFMS:
                    {
                        this.saveProjectDialog.Filter = "FFMSIndex 專案檔案|*.ffindex";
                        //this.gbOutput.Enabled = false;
                        this.gbAudio.Enabled = true;
                        if (this.demuxTracks.Checked)
                            this.demuxAll.Checked = true;
                        this.demuxTracks.Enabled = true;
                        this.demuxVideo.Checked = false;
                        this.demuxVideo.Enabled = false;
                        IndexerUsed = IndexType.FFMS;
                        btnFFMS.Checked = true;
                        if (txtContainerInformation.Text.Trim().ToUpperInvariant().Equals("MATROSKA"))
                        {
                            generateAudioList();
                            this.gbAudio.Text = " 音訊提取 ";
                        }
                        else
                            this.gbAudio.Text = " 音訊編碼 ";
                        break;
                    }
                case IndexType.LSMASH:
                    {
                        this.saveProjectDialog.Filter = "LSMASHIndex 專案檔案|*.lwi";
                        //this.gbOutput.Enabled = false;
                        this.gbAudio.Enabled = true;
                        if (this.demuxTracks.Checked)
                            this.demuxAll.Checked = true;
                        this.demuxTracks.Enabled = true;
                        this.demuxVideo.Checked = false;
                        this.demuxVideo.Enabled = false;
                        IndexerUsed = IndexType.LSMASH;
                        btnLSMASH.Checked = true;
                        if (txtContainerInformation.Text.Trim().ToUpperInvariant().Equals("MATROSKA"))
                        {
                            generateAudioList();
                            this.gbAudio.Text = " 音訊提取 ";
                        }
                        else
                            this.gbAudio.Text = " 音訊編碼 ";
                        break;
                    }
            }
            setOutputFileName();
            recommendSettings();
            if (!demuxTracks.Checked)
                rbtracks_CheckedChanged(null, null);
        }
        #endregion
        #region buttons
        private void pickOutputButton_Click(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(output.Text))
            {
                saveProjectDialog.InitialDirectory = Path.GetDirectoryName(output.Text);
                saveProjectDialog.FileName = Path.GetFileName(output.Text);
            }
            if (saveProjectDialog.ShowDialog() == DialogResult.OK)
            {
                output.Text = saveProjectDialog.FileName;
                checkIndexIO();
            }
        }

        private void input_FileSelected(FileBar sender, FileBarEventArgs args)
        {
            openVideo(input.Filename);
            checkIndexIO();
        }
        private void openVideo(string fileName)
        {
            this._oLog = mainForm.FileIndexerLog;
            if (_oLog == null)
            {
                _oLog = mainForm.Log.Info("FileIndexer");
                mainForm.FileIndexerLog = _oLog;
            }
            MediaInfoFile iFile = new MediaInfoFile(fileName, ref _oLog);

            strVideoCodec = iFile.VideoInfo.Track.Codec;
            strVideoScanType = iFile.VideoInfo.ScanType;
            strContainerFormat = iFile.ContainerFileTypeString;
            audioTracks = iFile.AudioInfo.Tracks;

            if (String.IsNullOrEmpty(strVideoCodec))
                txtCodecInformation.Text = " unknown";
            else
                txtCodecInformation.Text = " " + strVideoCodec;
            if (String.IsNullOrEmpty(strContainerFormat))
                txtContainerInformation.Text = " unknown";
            else
                txtContainerInformation.Text = " " + strContainerFormat;
            if (String.IsNullOrEmpty(strVideoScanType))
                txtScanTypeInformation.Text = " unknown";
            else
                txtScanTypeInformation.Text = " " + strVideoScanType;

            cbPGC.Items.Clear();
            if (iFile.VideoInfo.PGCCount <= 0)
                cbPGC.Items.Add("none");
            else if (iFile.VideoInfo.PGCCount == 1)
                cbPGC.Items.Add("all");
            else
            {
                cbPGC.Items.Add("all");
                for (int i = 1; i < iFile.VideoInfo.PGCCount; i++)
                    cbPGC.Items.Add(i.ToString());
            }
            cbPGC.SelectedIndex = 0;
            cbPGC.Enabled = iFile.VideoInfo.PGCCount > 1;

            if (input.Filename != fileName)
                input.Filename = fileName;

            generateAudioList();

            btnD2V.Enabled = iFile.isD2VIndexable();
            btnDGA.Enabled = iFile.isDGAIndexable();
            btnDGI.Enabled = iFile.isDGIIndexable();
            btnFFMS.Enabled = iFile.isFFMSIndexable();
            btnLSMASH.Enabled = iFile.isLSMASHIndexable(true);

            IndexType newType = IndexType.NONE;
            iFile.recommendIndexer(out newType, true);
            if (newType == IndexType.D2V || newType == IndexType.DGA ||
                newType == IndexType.DGI || newType == IndexType.FFMS ||
                newType == IndexType.LSMASH)
            {
                gbIndexer.Enabled = gbAudio.Enabled = gbOutput.Enabled = true;
                changeIndexer(newType);
            }
            else
            {
                gbIndexer.Enabled = gbAudio.Enabled = gbOutput.Enabled = false;
                btnFFMS.Checked = btnD2V.Checked = btnDGA.Checked = btnDGI.Checked = btnLSMASH.Checked = false;
                output.Text = "";
                demuxNoAudiotracks.Checked = true;
                MessageBox.Show("No indexer for this file found. Please try open it directly in the AVS Script Creator", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void generateAudioList()
        {
            AudioTracks.Items.Clear();

            foreach (AudioTrackInfo atrack in audioTracks)
                AudioTracks.Items.Add(atrack);
        }

        /// <summary>
        /// recommend input settings based upon the input file
        /// </summary>
        private void recommendSettings()
        {
            if (AudioTracks.Items.Count > 0)
            {
                if (IndexerUsed == IndexType.D2V)
                {
                    if (strContainerFormat.Equals("MPEG-PS"))
                    {
                        demuxTracks.Enabled = true;
                    }
                    else
                    {
                        if (demuxTracks.Checked)
                            demuxAll.Checked = true;
                        demuxTracks.Enabled = false;
                    }
                }
            }
            else
            {
                demuxNoAudiotracks.Checked = true;
                demuxTracks.Enabled = false;
            }
            AudioTracks.Enabled = demuxTracks.Checked;

            if (IndexerUsed == IndexType.FFMS)
            {
                if (!strContainerFormat.ToUpperInvariant().Equals("MATROSKA") &&
                    !strContainerFormat.ToUpperInvariant().Equals("AVI") &&
                    !strContainerFormat.ToUpperInvariant().Equals("MPEG-4") &&
                    !strContainerFormat.ToUpperInvariant().Equals("FLASH VIDEO"))
                {
                    MessageBox.Show("It is recommended to use a MKV, AVI, MP4 or FLV container to index files with the FFMS2 indexer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// sets the output file name
        /// </summary>
        private void setOutputFileName()
        {
            if (!String.IsNullOrEmpty(this.input.Filename))
            {
                string projectPath = "";
                string fileNameNoPath = Path.GetFileName(this.input.Filename);
                if (string.IsNullOrEmpty(projectPath = mainForm.Settings.DefaultOutputDir))
                    projectPath = Path.GetDirectoryName(this.input.Filename);
                switch (IndexerUsed)
                {
                    case IndexType.D2V: output.Text = Path.Combine(projectPath, Path.ChangeExtension(fileNameNoPath, ".d2v")); ; break;
                    case IndexType.DGA: output.Text = Path.Combine(projectPath, Path.ChangeExtension(fileNameNoPath, ".dga")); ; break;
                    case IndexType.DGI: output.Text = Path.Combine(projectPath, Path.ChangeExtension(fileNameNoPath, ".dgi")); ; break;
                    case IndexType.FFMS: output.Text = Path.Combine(projectPath, fileNameNoPath + ".ffindex"); break;
                    case IndexType.LSMASH: output.Text = Path.Combine(projectPath, fileNameNoPath + ".lwi"); break;
                }
            }
        }

        /// <summary>
        /// creates a project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queueButton_Click(object sender, System.EventArgs e)
        {
            if (dialogMode)
                return;

            if (!configured)
            {
                MessageBox.Show("You must select the input and output file to continue",
                    "Configuration incomplete", MessageBoxButtons.OK);
                return;
            }

            if (!Drives.ableToWriteOnThisDrive(Path.GetPathRoot(output.Text)))
            {
                MessageBox.Show("MeGUI cannot write on the disc " + Path.GetPathRoot(output.Text) + "\n" +
                    "Please, select another output path to save your project...", "Configuration Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            JobChain prepareJobs = null;
            string videoInput = input.Filename;

            // create pgcdemux job if needed
            if (cbPGC.SelectedIndex > 0 
                && Path.GetExtension(input.Filename.ToUpperInvariant()) == ".VOB")
            {
                string videoIFO;
                // PGC numbers are not present in VOB, so we check the main IFO
                if (Path.GetFileName(input.Filename).ToUpperInvariant().Substring(0, 4) == "VTS_")
                    videoIFO = input.Filename.Substring(0, input.Filename.LastIndexOf("_")) + "_0.IFO";
                else
                    videoIFO = Path.ChangeExtension(input.Filename, ".IFO");

                if (File.Exists(videoIFO))
                {
                    prepareJobs = new SequentialChain(new PgcDemuxJob(videoIFO, Path.GetDirectoryName(output.Text), cbPGC.SelectedIndex));
                    videoInput = Path.Combine(Path.GetDirectoryName(output.Text), "VTS_01_1.VOB");
                    for (int i = 1; i < 10; i++)
                    {
                        string file = Path.Combine(Path.GetDirectoryName(output.Text), "VTS_01_" + i + ".VOB");
                        if (File.Exists(file))
                        {
                            MessageBox.Show("The pgc demux file already exists: \n" + file + "\n\n" +
                                "Please select another output path to save your project.", "Configuration Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            switch (IndexerUsed)
            {
                case IndexType.D2V:
                    {
                        prepareJobs = new SequentialChain(prepareJobs, new SequentialChain(generateD2VIndexJob(videoInput)));
                        mainForm.Jobs.addJobsWithDependencies(prepareJobs, true);
                        if (this.closeOnQueue.Checked)
                            this.Close();
                        break;
                    }
                case IndexType.DGI:
                    {
                        prepareJobs = new SequentialChain(prepareJobs, new SequentialChain(generateDGNVIndexJob(videoInput)));
                        mainForm.Jobs.addJobsWithDependencies(prepareJobs, true);
                        if (this.closeOnQueue.Checked)
                            this.Close();
                        break;
                    }
                case IndexType.DGA:
                    {
                        prepareJobs = new SequentialChain(prepareJobs, new SequentialChain(generateDGAIndexJob(videoInput)));
                        mainForm.Jobs.addJobsWithDependencies(prepareJobs, true);
                        if (this.closeOnQueue.Checked)
                            this.Close();
                        break;
                    }
                case IndexType.FFMS:
                    {
                        FFMSIndexJob job = generateFFMSIndexJob(videoInput);
                        if (txtContainerInformation.Text.Trim().ToUpperInvariant().Equals("MATROSKA") 
                            && job.DemuxMode > 0 && job.AudioTracks.Count > 0)
                        {
                            job.DemuxMode = 0;
                            job.AudioTracksDemux = job.AudioTracks;
                            job.AudioTracks = new List<AudioTrackInfo>();
                            MkvExtractJob extractJob = new MkvExtractJob(videoInput, Path.GetDirectoryName(this.output.Text), job.AudioTracksDemux);
                            prepareJobs = new SequentialChain(prepareJobs, new SequentialChain(extractJob));
                        }
                        prepareJobs = new SequentialChain(prepareJobs, new SequentialChain(job));
                        mainForm.Jobs.addJobsWithDependencies(prepareJobs, true);
                        if (this.closeOnQueue.Checked)
                            this.Close();
                        break;
                    }
                case IndexType.LSMASH:
                    {
                        LSMASHIndexJob job = generateLSMASHIndexJob(videoInput);
                        if (txtContainerInformation.Text.Trim().ToUpperInvariant().Equals("MATROSKA")
                            && job.DemuxMode > 0 && job.AudioTracks.Count > 0)
                        {
                            job.DemuxMode = 0;
                            job.AudioTracksDemux = job.AudioTracks;
                            job.AudioTracks = new List<AudioTrackInfo>();
                            MkvExtractJob extractJob = new MkvExtractJob(videoInput, Path.GetDirectoryName(this.output.Text), job.AudioTracksDemux);
                            prepareJobs = new SequentialChain(prepareJobs, new SequentialChain(extractJob));
                        }
                        prepareJobs = new SequentialChain(prepareJobs, new SequentialChain(job));
                        mainForm.Jobs.addJobsWithDependencies(prepareJobs, true);
                        if (this.closeOnQueue.Checked)
                            this.Close();
                        break;
                    }
            }              
        }
        #endregion
        #region helper methods
        private void checkIndexIO()
        {
            configured = (!input.Filename.Equals("") && !output.Text.Equals(""));
            if (configured && dialogMode)
                queueButton.DialogResult = DialogResult.OK;
            else
                queueButton.DialogResult = DialogResult.None;
        }

        private D2VIndexJob generateD2VIndexJob(string videoInput)
        {
            int demuxType = 0;
            if (demuxTracks.Checked)
                demuxType = 1;
            else if (demuxNoAudiotracks.Checked)
                demuxType = 0;
            else
                demuxType = 2;

            List<AudioTrackInfo> audioTracks = new List<AudioTrackInfo>();
            foreach (AudioTrackInfo ati in AudioTracks.CheckedItems)
                audioTracks.Add(ati);

            return new D2VIndexJob(videoInput, this.output.Text, demuxType, audioTracks, loadOnComplete.Checked, demuxVideo.Checked);
        }

        private DGIIndexJob generateDGNVIndexJob(string videoInput)
        {
            int demuxType = 0;
            if (demuxTracks.Checked)
                demuxType = 1;
            else if (demuxNoAudiotracks.Checked)
                demuxType = 0;
            else
                demuxType = 2;

            List<AudioTrackInfo> audioTracks = new List<AudioTrackInfo>();
            foreach (AudioTrackInfo ati in AudioTracks.CheckedItems)
                audioTracks.Add(ati);

            return new DGIIndexJob(videoInput, this.output.Text, demuxType, audioTracks, loadOnComplete.Checked, demuxVideo.Checked);
        }

        private DGAIndexJob generateDGAIndexJob(string videoInput)
        {
            int demuxType = 0;
            if (demuxTracks.Checked)
                demuxType = 1;
            else if (demuxNoAudiotracks.Checked)
                demuxType = 0;
            else
                demuxType = 2;

            List<AudioTrackInfo> audioTracks = new List<AudioTrackInfo>();
            foreach (AudioTrackInfo ati in AudioTracks.CheckedItems)
                audioTracks.Add(ati);

            return new DGAIndexJob(videoInput, this.output.Text, demuxType, audioTracks, loadOnComplete.Checked, demuxVideo.Checked);
        }

        private FFMSIndexJob generateFFMSIndexJob(string videoInput)
        {
            int demuxType = 0;
            if (demuxTracks.Checked)
                demuxType = 1;
            else if (demuxNoAudiotracks.Checked)
                demuxType = 0;
            else
                demuxType = 2;

            List<AudioTrackInfo> audioTracks = new List<AudioTrackInfo>();
            foreach (AudioTrackInfo ati in AudioTracks.CheckedItems)
                audioTracks.Add(ati);

            return new FFMSIndexJob(videoInput, output.Text, demuxType, audioTracks, loadOnComplete.Checked);
        }

        private LSMASHIndexJob generateLSMASHIndexJob(string videoInput)
        {
            int demuxType = 0;
            if (demuxTracks.Checked)
                demuxType = 1;
            else if (demuxNoAudiotracks.Checked)
                demuxType = 0;
            else
                demuxType = 2;

            List<AudioTrackInfo> audioTracks = new List<AudioTrackInfo>();
            foreach (AudioTrackInfo ati in AudioTracks.CheckedItems)
                audioTracks.Add(ati);

            return new LSMASHIndexJob(videoInput, output.Text, demuxType, audioTracks, loadOnComplete.Checked);
        }
        #endregion

        private void rbtracks_CheckedChanged(object sender, EventArgs e)
        {
            // Now defaults to starting with every track selected
            for (int i = 0; i < AudioTracks.Items.Count; i++)
                AudioTracks.SetItemChecked(i, !demuxNoAudiotracks.Checked);
            AudioTracks.Enabled = demuxTracks.Checked;
        }

        private void btnFFMS_Click(object sender, EventArgs e)
        {
            changeIndexer(IndexType.FFMS);
        }

        private void btnDGI_Click(object sender, EventArgs e)
        {
            changeIndexer(IndexType.DGI);
        }

        private void btnDGA_Click(object sender, EventArgs e)
        {
            changeIndexer(IndexType.DGA);
        }

        private void btnD2V_Click(object sender, EventArgs e)
        {
            changeIndexer(IndexType.D2V);
        }

        private void btnLSMASH_Click(object sender, EventArgs e)
        {
            changeIndexer(IndexType.LSMASH);
        }
    }

    public class D2VCreatorTool : MeGUI.core.plugins.interfaces.ITool
    {

        #region ITool Members

        public string Name
        {
            get { return "檔案索引"; }
        }

        public void Run(MainForm info)
        {
            new FileIndexerWindow(info).Show();

        }

        public Shortcut[] Shortcuts
        {
            get { return new Shortcut[] { Shortcut.Ctrl2 }; }
        }

        #endregion

        #region IIDable Members

        public string ID
        {
            get { return "d2v_creator"; }
        }

        #endregion
    }

    public class d2vIndexJobPostProcessor
    {
        public static JobPostProcessor PostProcessor = new JobPostProcessor(postprocess, "D2V_postprocessor");
        private static LogItem postprocess(MainForm mainForm, Job ajob)
        {
            if (!(ajob is D2VIndexJob)) return null;
            D2VIndexJob job = (D2VIndexJob)ajob;

            StringBuilder logBuilder = new StringBuilder();
            VideoUtil vUtil = new VideoUtil(mainForm);
            List<string> arrFilesToDelete = new List<string>();
            Dictionary<int, string> audioFiles = vUtil.getAllDemuxedAudio(job.AudioTracks, new List<AudioTrackInfo>(), out arrFilesToDelete, job.Output, null);
            if (job.LoadSources)
            {
                if (job.DemuxMode != 0 && audioFiles.Count > 0)
                {
                    string[] files = new string[audioFiles.Values.Count];
                    audioFiles.Values.CopyTo(files, 0);
                    Util.ThreadSafeRun(mainForm, new MethodInvoker(
                        delegate
                        {
                            mainForm.Audio.openAudioFile(files);
                        }));
                }
                // if the above needed delegation for openAudioFile this needs it for openVideoFile?
                // It seems to fix the problem of ASW dissapearing as soon as it appears on a system (Vista X64)
                Util.ThreadSafeRun(mainForm, new MethodInvoker(
                    delegate
                    {
                        AviSynthWindow asw = new AviSynthWindow(mainForm, job.Output);
                        asw.OpenScript += new OpenScriptCallback(mainForm.Video.openVideoFile);
                        asw.Show();
                    }));
            }

            return null;
        }
    }

    public class dgiIndexJobPostProcessor
    {
        public static JobPostProcessor PostProcessor = new JobPostProcessor(postprocess, "Dgi_postprocessor");
        private static LogItem postprocess(MainForm mainForm, Job ajob)
        {
            if (!(ajob is DGIIndexJob)) return null;
            DGIIndexJob job = (DGIIndexJob)ajob;

            StringBuilder logBuilder = new StringBuilder();
            VideoUtil vUtil = new VideoUtil(mainForm);
            List<string> arrFilesToDelete = new List<string>();
            Dictionary<int, string> audioFiles = vUtil.getAllDemuxedAudio(job.AudioTracks, new List<AudioTrackInfo>(), out arrFilesToDelete, job.Output, null);
            if (job.LoadSources)
            {
                if (job.DemuxMode != 0 && audioFiles.Count > 0)
                {
                    string[] files = new string[audioFiles.Values.Count];
                    audioFiles.Values.CopyTo(files, 0);
                    Util.ThreadSafeRun(mainForm, new MethodInvoker(
                        delegate
                        {
                            mainForm.Audio.openAudioFile(files);
                        }));
                }
                // if the above needed delegation for openAudioFile this needs it for openVideoFile?
                // It seems to fix the problem of ASW dissapearing as soon as it appears on a system (Vista X64)
                Util.ThreadSafeRun(mainForm, new MethodInvoker(
                    delegate
                    {
                        AviSynthWindow asw = new AviSynthWindow(mainForm, job.Output);
                        asw.OpenScript += new OpenScriptCallback(mainForm.Video.openVideoFile);
                        asw.Show();
                    }));
            }

            return null;
        }
    }

    public class dgaIndexJobPostProcessor
    {
        public static JobPostProcessor PostProcessor = new JobPostProcessor(postprocess, "Dga_postprocessor");
        private static LogItem postprocess(MainForm mainForm, Job ajob)
        {
            if (!(ajob is DGAIndexJob)) return null;
            DGAIndexJob job = (DGAIndexJob)ajob;

            StringBuilder logBuilder = new StringBuilder();
            VideoUtil vUtil = new VideoUtil(mainForm);
            List<string> arrFilesToDelete = new List<string>();
            Dictionary<int, string> audioFiles = vUtil.getAllDemuxedAudio(job.AudioTracks, new List<AudioTrackInfo>(), out arrFilesToDelete, job.Output, null);
            if (job.LoadSources)
            {
                if (job.DemuxMode != 0 && audioFiles.Count > 0)
                {
                    string[] files = new string[audioFiles.Values.Count];
                    audioFiles.Values.CopyTo(files, 0);
                    Util.ThreadSafeRun(mainForm, new MethodInvoker(
                        delegate
                        {
                            mainForm.Audio.openAudioFile(files);
                        }));
                }
                // if the above needed delegation for openAudioFile this needs it for openVideoFile?
                // It seems to fix the problem of ASW dissapearing as soon as it appears on a system (Vista X64)
                Util.ThreadSafeRun(mainForm, new MethodInvoker(
                    delegate
                    {
                        AviSynthWindow asw = new AviSynthWindow(mainForm, job.Output);
                        asw.OpenScript += new OpenScriptCallback(mainForm.Video.openVideoFile);
                        asw.Show();
                    }));
            }

            return null;
        }
    }

    public class ffmsIndexJobPostProcessor
    {
        public static JobPostProcessor PostProcessor = new JobPostProcessor(postprocess, "FFMS_postprocessor");
        private static LogItem postprocess(MainForm mainForm, Job ajob)
        {
            if (!(ajob is FFMSIndexJob)) return null;
            FFMSIndexJob job = (FFMSIndexJob)ajob;

            StringBuilder logBuilder = new StringBuilder();
            VideoUtil vUtil = new VideoUtil(mainForm);
            List<string> arrFilesToDelete = new List<string>();
            Dictionary<int, string> audioFiles = vUtil.getAllDemuxedAudio(job.AudioTracks, job.AudioTracksDemux, out arrFilesToDelete, job.Output, null);
            if (job.LoadSources)
            {
                if (job.DemuxMode != 0)
                {
                    string[] files = new string[audioFiles.Values.Count];
                    audioFiles.Values.CopyTo(files, 0);
                    Util.ThreadSafeRun(mainForm, new MethodInvoker(
                        delegate
                        {
                            mainForm.Audio.openAudioFile(files);
                        }));
                }
                // if the above needed delegation for openAudioFile this needs it for openVideoFile?
                // It seems to fix the problem of ASW dissapearing as soon as it appears on a system (Vista X64)
                Util.ThreadSafeRun(mainForm, new MethodInvoker(
                    delegate
                    {
                        AviSynthWindow asw = new AviSynthWindow(mainForm, job.Input, job.Output);
                        asw.OpenScript += new OpenScriptCallback(mainForm.Video.openVideoFile);
                        asw.Show();
                    }));
            }

            return null;
        }
    }

    public class lsmashIndexJobPostProcessor
    {
        public static JobPostProcessor PostProcessor = new JobPostProcessor(postprocess, "LSMASH_postprocessor");
        private static LogItem postprocess(MainForm mainForm, Job ajob)
        {
            if (!(ajob is LSMASHIndexJob)) 
                return null;
            LSMASHIndexJob job = (LSMASHIndexJob)ajob;

            StringBuilder logBuilder = new StringBuilder();
            VideoUtil vUtil = new VideoUtil(mainForm);
            List<string> arrFilesToDelete = new List<string>();
            Dictionary<int, string> audioFiles = vUtil.getAllDemuxedAudio(job.AudioTracks, job.AudioTracksDemux, out arrFilesToDelete, job.Output, null);
            if (job.LoadSources)
            {
                if (job.DemuxMode != 0)
                {
                    string[] files = new string[audioFiles.Values.Count];
                    audioFiles.Values.CopyTo(files, 0);
                    Util.ThreadSafeRun(mainForm, new MethodInvoker(
                        delegate
                        {
                            mainForm.Audio.openAudioFile(files);
                        }));
                }
                // if the above needed delegation for openAudioFile this needs it for openVideoFile?
                // It seems to fix the problem of ASW dissapearing as soon as it appears on a system (Vista X64)
                Util.ThreadSafeRun(mainForm, new MethodInvoker(
                    delegate
                    {
                        AviSynthWindow asw = new AviSynthWindow(mainForm, job.Input, job.Output);
                        asw.OpenScript += new OpenScriptCallback(mainForm.Video.openVideoFile);
                        asw.Show();
                    }));
            }

            return null;
        }
    }

    public delegate void ProjectCreationComplete(); // this event is fired when the dgindex thread finishes
}