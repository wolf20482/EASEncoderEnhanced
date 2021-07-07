﻿namespace EASEncoder_Test_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCounty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboOriginator = new System.Windows.Forms.ComboBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkEbsTones = new System.Windows.Forms.CheckBox();
            this.chkNwsTone = new System.Windows.Forms.CheckBox();
            this.txtAnnouncement = new System.Windows.Forms.TextBox();
            this.btnGeneratePlay = new System.Windows.Forms.Button();
            this.datagridRegions = new System.Windows.Forms.DataGridView();
            this.btnAddRegion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboLengthHour = new System.Windows.Forms.ComboBox();
            this.comboLengthMinutes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnGenerateCustom = new System.Windows.Forms.Button();
            this.btnTTSSettings = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGeneratedData = new System.Windows.Forms.TextBox();
            this.labelTTSVoice = new System.Windows.Forms.Label();
            this.comboVoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRegions)).BeginInit();
            this.SuspendLayout();
            // 
            // comboState
            // 
            this.comboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(9, 209);
            this.comboState.Margin = new System.Windows.Forms.Padding(2);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(236, 28);
            this.comboState.TabIndex = 0;
            this.comboState.SelectedIndexChanged += new System.EventHandler(this.comboState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "County";
            // 
            // comboCounty
            // 
            this.comboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCounty.FormattingEnabled = true;
            this.comboCounty.Location = new System.Drawing.Point(268, 209);
            this.comboCounty.Margin = new System.Windows.Forms.Padding(2);
            this.comboCounty.Name = "comboCounty";
            this.comboCounty.Size = new System.Drawing.Size(217, 28);
            this.comboCounty.TabIndex = 2;
            this.comboCounty.SelectedIndexChanged += new System.EventHandler(this.comboCounty_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code";
            // 
            // comboCode
            // 
            this.comboCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCode.FormattingEnabled = true;
            this.comboCode.Location = new System.Drawing.Point(9, 86);
            this.comboCode.Margin = new System.Windows.Forms.Padding(2);
            this.comboCode.Name = "comboCode";
            this.comboCode.Size = new System.Drawing.Size(278, 28);
            this.comboCode.TabIndex = 4;
            this.comboCode.SelectedIndexChanged += new System.EventHandler(this.comboCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Originator";
            // 
            // comboOriginator
            // 
            this.comboOriginator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOriginator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOriginator.FormattingEnabled = true;
            this.comboOriginator.Location = new System.Drawing.Point(9, 29);
            this.comboOriginator.Margin = new System.Windows.Forms.Padding(2);
            this.comboOriginator.Name = "comboOriginator";
            this.comboOriginator.Size = new System.Drawing.Size(278, 28);
            this.comboOriginator.TabIndex = 6;
            this.comboOriginator.SelectedIndexChanged += new System.EventHandler(this.comboOriginator_SelectedIndexChanged);
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(8, 149);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(278, 26);
            this.dateStart.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Event Begin Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valid for (Hours)";
            // 
            // txtSender
            // 
            this.txtSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSender.Location = new System.Drawing.Point(332, 29);
            this.txtSender.Margin = new System.Windows.Forms.Padding(2);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(134, 26);
            this.txtSender.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sender ID (8 Chars)";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Pink;
            this.btnGenerate.Location = new System.Drawing.Point(957, 310);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(147, 63);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate EAS File";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkEbsTones
            // 
            this.chkEbsTones.AutoSize = true;
            this.chkEbsTones.Checked = true;
            this.chkEbsTones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEbsTones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEbsTones.Location = new System.Drawing.Point(508, 13);
            this.chkEbsTones.Margin = new System.Windows.Forms.Padding(2);
            this.chkEbsTones.Name = "chkEbsTones";
            this.chkEbsTones.Size = new System.Drawing.Size(211, 24);
            this.chkEbsTones.TabIndex = 15;
            this.chkEbsTones.Text = "Use EBS Attention Tones";
            this.chkEbsTones.UseVisualStyleBackColor = true;
            // 
            // chkNwsTone
            // 
            this.chkNwsTone.AutoSize = true;
            this.chkNwsTone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNwsTone.Location = new System.Drawing.Point(508, 41);
            this.chkNwsTone.Margin = new System.Windows.Forms.Padding(2);
            this.chkNwsTone.Name = "chkNwsTone";
            this.chkNwsTone.Size = new System.Drawing.Size(207, 24);
            this.chkNwsTone.TabIndex = 16;
            this.chkNwsTone.Text = "Use NWS Attention Tone";
            this.chkNwsTone.UseVisualStyleBackColor = true;
            // 
            // txtAnnouncement
            // 
            this.txtAnnouncement.Location = new System.Drawing.Point(508, 92);
            this.txtAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnnouncement.Multiline = true;
            this.txtAnnouncement.Name = "txtAnnouncement";
            this.txtAnnouncement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnnouncement.Size = new System.Drawing.Size(430, 262);
            this.txtAnnouncement.TabIndex = 17;
            this.txtAnnouncement.TextChanged += new System.EventHandler(this.txtAnnouncement_TextChanged);
            // 
            // btnGeneratePlay
            // 
            this.btnGeneratePlay.BackColor = System.Drawing.Color.LightPink;
            this.btnGeneratePlay.Location = new System.Drawing.Point(957, 224);
            this.btnGeneratePlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneratePlay.Name = "btnGeneratePlay";
            this.btnGeneratePlay.Size = new System.Drawing.Size(147, 56);
            this.btnGeneratePlay.TabIndex = 18;
            this.btnGeneratePlay.Text = "Generate EAS && Play";
            this.btnGeneratePlay.UseVisualStyleBackColor = false;
            this.btnGeneratePlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // datagridRegions
            // 
            this.datagridRegions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridRegions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridRegions.Location = new System.Drawing.Point(12, 291);
            this.datagridRegions.Margin = new System.Windows.Forms.Padding(2);
            this.datagridRegions.Name = "datagridRegions";
            this.datagridRegions.RowTemplate.Height = 24;
            this.datagridRegions.Size = new System.Drawing.Size(472, 197);
            this.datagridRegions.TabIndex = 19;
            // 
            // btnAddRegion
            // 
            this.btnAddRegion.Location = new System.Drawing.Point(390, 245);
            this.btnAddRegion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRegion.Name = "btnAddRegion";
            this.btnAddRegion.Size = new System.Drawing.Size(94, 35);
            this.btnAddRegion.TabIndex = 20;
            this.btnAddRegion.Text = "Add Location";
            this.btnAddRegion.UseVisualStyleBackColor = true;
            this.btnAddRegion.Click += new System.EventHandler(this.btnAddRegion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Event Location(s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Announcement Text";
            // 
            // comboLengthHour
            // 
            this.comboLengthHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLengthHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLengthHour.FormattingEnabled = true;
            this.comboLengthHour.Location = new System.Drawing.Point(298, 146);
            this.comboLengthHour.Margin = new System.Windows.Forms.Padding(2);
            this.comboLengthHour.Name = "comboLengthHour";
            this.comboLengthHour.Size = new System.Drawing.Size(83, 28);
            this.comboLengthHour.TabIndex = 23;
            // 
            // comboLengthMinutes
            // 
            this.comboLengthMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLengthMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLengthMinutes.FormattingEnabled = true;
            this.comboLengthMinutes.Location = new System.Drawing.Point(394, 146);
            this.comboLengthMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.comboLengthMinutes.Name = "comboLengthMinutes";
            this.comboLengthMinutes.Size = new System.Drawing.Size(91, 28);
            this.comboLengthMinutes.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Valid for (minutes)";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputFile.Location = new System.Drawing.Point(631, 440);
            this.txtOutputFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(201, 26);
            this.txtOutputFile.TabIndex = 26;
            this.txtOutputFile.Text = "output";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 453);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Output File Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(505, 356);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(312, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "EAS audio files will be output to app directory at:";
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.Location = new System.Drawing.Point(506, 375);
            this.lblOutputDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(326, 41);
            this.lblOutputDirectory.TabIndex = 29;
            this.lblOutputDirectory.Text = "./";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.LightPink;
            this.btnAbout.Location = new System.Drawing.Point(957, 132);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(147, 56);
            this.btnAbout.TabIndex = 30;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGenerateCustom
            // 
            this.btnGenerateCustom.BackColor = System.Drawing.Color.Pink;
            this.btnGenerateCustom.Location = new System.Drawing.Point(957, 421);
            this.btnGenerateCustom.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateCustom.Name = "btnGenerateCustom";
            this.btnGenerateCustom.Size = new System.Drawing.Size(147, 45);
            this.btnGenerateCustom.TabIndex = 31;
            this.btnGenerateCustom.Text = "Generate EAS from Custom Data";
            this.btnGenerateCustom.UseVisualStyleBackColor = false;
            this.btnGenerateCustom.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnTTSSettings
            // 
            this.btnTTSSettings.BackColor = System.Drawing.Color.LightPink;
            this.btnTTSSettings.Location = new System.Drawing.Point(957, 48);
            this.btnTTSSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnTTSSettings.Name = "btnTTSSettings";
            this.btnTTSSettings.Size = new System.Drawing.Size(147, 56);
            this.btnTTSSettings.TabIndex = 32;
            this.btnTTSSettings.Text = "Open TTS Settings";
            this.btnTTSSettings.UseVisualStyleBackColor = false;
            this.btnTTSSettings.Click += new System.EventHandler(this.btnTTSSettings_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(506, 511);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Generated EAS Message Header Data";
            // 
            // txtGeneratedData
            // 
            this.txtGeneratedData.Location = new System.Drawing.Point(508, 527);
            this.txtGeneratedData.Name = "txtGeneratedData";
            this.txtGeneratedData.ReadOnly = true;
            this.txtGeneratedData.Size = new System.Drawing.Size(596, 20);
            this.txtGeneratedData.TabIndex = 34;
            this.txtGeneratedData.TextChanged += new System.EventHandler(this.txtGeneratedData_TextChanged);
            // 
            // labelTTSVoice
            // 
            this.labelTTSVoice.AutoSize = true;
            this.labelTTSVoice.Location = new System.Drawing.Point(13, 511);
            this.labelTTSVoice.Name = "labelTTSVoice";
            this.labelTTSVoice.Size = new System.Drawing.Size(94, 13);
            this.labelTTSVoice.TabIndex = 35;
            this.labelTTSVoice.Text = "Select TTS Voice:";
            // 
            // comboVoice
            // 
            this.comboVoice.FormattingEnabled = true;
            this.comboVoice.Location = new System.Drawing.Point(113, 508);
            this.comboVoice.Name = "comboVoice";
            this.comboVoice.Size = new System.Drawing.Size(316, 21);
            this.comboVoice.TabIndex = 36;
            this.comboVoice.SelectedIndexChanged += new System.EventHandler(this.comboVoice_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 575);
            this.Controls.Add(this.comboVoice);
            this.Controls.Add(this.labelTTSVoice);
            this.Controls.Add(this.txtGeneratedData);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnTTSSettings);
            this.Controls.Add(this.btnGenerateCustom);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblOutputDirectory);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboLengthMinutes);
            this.Controls.Add(this.comboLengthHour);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddRegion);
            this.Controls.Add(this.datagridRegions);
            this.Controls.Add(this.btnGeneratePlay);
            this.Controls.Add(this.txtAnnouncement);
            this.Controls.Add(this.chkNwsTone);
            this.Controls.Add(this.chkEbsTones);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboOriginator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCounty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EAS Encoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridRegions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCounty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboOriginator;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkEbsTones;
        private System.Windows.Forms.CheckBox chkNwsTone;
        private System.Windows.Forms.TextBox txtAnnouncement;
        private System.Windows.Forms.Button btnGeneratePlay;
        private System.Windows.Forms.DataGridView datagridRegions;
        private System.Windows.Forms.Button btnAddRegion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboLengthHour;
        private System.Windows.Forms.ComboBox comboLengthMinutes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnGenerateCustom;
        private System.Windows.Forms.Button btnTTSSettings;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGeneratedData;
        private System.Windows.Forms.Label labelTTSVoice;
        private System.Windows.Forms.ComboBox comboVoice;
    }
}

