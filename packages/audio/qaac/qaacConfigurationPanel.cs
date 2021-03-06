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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MeGUI.core.plugins.interfaces;

namespace MeGUI.packages.audio.qaac
{
    public partial class qaacConfigurationPanel : MeGUI.core.details.audio.AudioConfigurationPanel, Editable<QaacSettings>
    {

        public qaacConfigurationPanel():base()
        {
            InitializeComponent();
            cbMode.Items.AddRange(EnumProxy.CreateArray(QaacSettings.SupportedModes));
            cbProfile.Items.AddRange(EnumProxy.CreateArray(QaacSettings.SupportedProfiles));
        }

        #region Editable<QaacSettings> Members

        #region properties
        /// <summary>
        /// gets / sets the settings that are being shown in this configuration dialog
        /// </summary>
        protected override AudioCodecSettings CodecSettings
        {
            get
            {
                QaacSettings qas = new QaacSettings();
                switch ((QaacMode)(cbMode.SelectedItem as EnumProxy).RealValue)
                {
                    case QaacMode.ABR: qas.BitrateMode = BitrateManagementMode.ABR; break;
                    case QaacMode.CBR: qas.BitrateMode = BitrateManagementMode.CBR; break;
                    default: qas.BitrateMode = BitrateManagementMode.VBR; break;
                }
                qas.NoDelay = chNoDelay.Checked;
                qas.Mode = (QaacMode)(cbMode.SelectedItem as EnumProxy).RealValue;
                qas.Profile = (QaacProfile)(cbProfile.SelectedItem as EnumProxy).RealValue;
                if (qas.Mode == QaacMode.TVBR)
                    qas.Quality = Int16.Parse(cbQuality.SelectedItem.ToString());
                else 
                    qas.Bitrate = (int)trackBar.Value;
                return qas;
            }
            set
            {
                QaacSettings qas = value as QaacSettings;
                cbMode.SelectedItem = EnumProxy.Create(qas.Mode);
                cbProfile.SelectedItem = EnumProxy.Create(qas.Profile);
                if (qas.Mode == QaacMode.TVBR)
                {
                    cbQuality.SelectedItem = qas.Quality.ToString();
                    if (cbQuality.SelectedItem == null)
                    {
                        // change to a proper value
                        foreach (string item in cbQuality.Items)
                        {
                            if (qas.Quality >= Int16.Parse(item))
                                cbQuality.SelectedItem = item;
                        }

                        // reset to default if required
                        if (cbQuality.SelectedItem == null)
                            cbQuality.SelectedItem = 91;
                    }
                }
                else
                    trackBar.Value = Math.Max(Math.Min(qas.Bitrate, trackBar.Maximum), trackBar.Minimum);
                chNoDelay.Checked = qas.NoDelay;
            }
        }
        #endregion

        QaacSettings Editable<QaacSettings>.Settings
        {
            get
            {
                return (QaacSettings)Settings;
            }
            set
            {
                Settings = value;
            }
        }

        #endregion

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            switch ((QaacMode)(cbMode.SelectedItem as EnumProxy).RealValue)
            {
                case QaacMode.TVBR:
                    trackBar.Visible = false;
                    cbQuality.Visible = label4.Visible = true;
                    trackBar.Minimum = 0;
                    trackBar.Maximum = 127;
                    trackBar.TickFrequency = 1;
                    encoderGroupBox.Text = String.Format(" QAAC 選項 - (Q={0}) ", cbQuality.SelectedItem);
                    break;
                case QaacMode.CVBR:
                    trackBar.Visible = true;
                    cbQuality.Visible = label4.Visible = false;
                    trackBar.Minimum = 0;
                    trackBar.Maximum = 320;
                    trackBar.TickFrequency = 20;
                    encoderGroupBox.Text = String.Format(" QAAC 選項 - 固定-動態位元率 @ {0} kbit/s ", trackBar.Value);
                    break;
                case QaacMode.ABR:
                    trackBar.Visible = true;
                    cbQuality.Visible = label4.Visible = false;
                    trackBar.Minimum = 0;
                    trackBar.Maximum = 320;
                    trackBar.TickFrequency = 20;
                    encoderGroupBox.Text = String.Format(" QAAC 選項 - 動態位元率 @ {0} kbit/s ", trackBar.Value);
                    break;
                case QaacMode.CBR:
                    trackBar.Visible = true;
                    cbQuality.Visible = label4.Visible = false;
                    trackBar.Minimum = 0;
                    trackBar.Maximum = 320;
                    trackBar.TickFrequency = 20;
                    encoderGroupBox.Text = String.Format(" QAAC 選項 - 固定位元率  @ {0} kbit/s ", trackBar.Value);
                    break;
            }
            if (cbProfile.SelectedIndex == 2)
                encoderGroupBox.Text = String.Format("QAAC 選項");
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBar1_ValueChanged(sender, e);
        }

        private void cbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProfile.SelectedIndex)
            {
                case 2: trackBar.Enabled = false; cbMode.Enabled = false; break;
                default: trackBar.Enabled = true; cbMode.Enabled = true; break;
            }

            if (cbProfile.SelectedIndex == 1)
            {
                QaacMode qMode = (QaacMode)(cbMode.SelectedItem as EnumProxy).RealValue;
                cbMode.Items.Remove(EnumProxy.Create(QaacMode.TVBR));
                if (qMode == QaacMode.TVBR)
                    cbMode.SelectedItem = EnumProxy.Create(QaacMode.CVBR);
            }
            else if (cbMode.Items.Count == 3)
                cbMode.Items.Insert(0, EnumProxy.Create(QaacMode.TVBR));

            cbMode_SelectedIndexChanged(sender, e);
        }
    }
}