
namespace EASEncoder_Test_App
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomData = new System.Windows.Forms.TextBox();
            this.checkBoxNWR = new System.Windows.Forms.CheckBox();
            this.checkBoxEBS = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnnouncement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "This tool can be used to generate EAS messages with incorrect or undocumented val" +
    "ues.\r\nThis can be used to check how the decoder responds to data that is not def" +
    "ined or incorrectly formatted.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "[Preamble]-ZCZC-";
            // 
            // txtCustomData
            // 
            this.txtCustomData.Location = new System.Drawing.Point(113, 77);
            this.txtCustomData.Name = "txtCustomData";
            this.txtCustomData.Size = new System.Drawing.Size(469, 20);
            this.txtCustomData.TabIndex = 2;
            this.txtCustomData.TextChanged += new System.EventHandler(this.txtCustomData_TextChanged);
            // 
            // checkBoxNWR
            // 
            this.checkBoxNWR.AutoSize = true;
            this.checkBoxNWR.Location = new System.Drawing.Point(19, 111);
            this.checkBoxNWR.Name = "checkBoxNWR";
            this.checkBoxNWR.Size = new System.Drawing.Size(108, 17);
            this.checkBoxNWR.TabIndex = 3;
            this.checkBoxNWR.Text = "Use NWR Tones";
            this.checkBoxNWR.UseVisualStyleBackColor = true;
            // 
            // checkBoxEBS
            // 
            this.checkBoxEBS.AutoSize = true;
            this.checkBoxEBS.Location = new System.Drawing.Point(19, 135);
            this.checkBoxEBS.Name = "checkBoxEBS";
            this.checkBoxEBS.Size = new System.Drawing.Size(102, 17);
            this.checkBoxEBS.TabIndex = 4;
            this.checkBoxEBS.Text = "Use EBS Tones";
            this.checkBoxEBS.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Announcement Text";
            // 
            // txtAnnouncement
            // 
            this.txtAnnouncement.Location = new System.Drawing.Point(19, 200);
            this.txtAnnouncement.Multiline = true;
            this.txtAnnouncement.Name = "txtAnnouncement";
            this.txtAnnouncement.Size = new System.Drawing.Size(563, 257);
            this.txtAnnouncement.TabIndex = 6;
            this.txtAnnouncement.TextChanged += new System.EventHandler(this.txtAnnouncement_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "EAS message will be saved to program folder.";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(637, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(637, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Output File Name:";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOutputFile.Location = new System.Drawing.Point(117, 492);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(100, 26);
            this.txtOutputFile.TabIndex = 12;
            this.txtOutputFile.Text = "output";
            this.txtOutputFile.TextChanged += new System.EventHandler(this.txtOutputFile_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 568);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnnouncement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxEBS);
            this.Controls.Add(this.checkBoxNWR);
            this.Controls.Add(this.txtCustomData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Generate Custom EAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.TextBox txtCustomData;
        internal System.Windows.Forms.CheckBox checkBoxNWR;
        internal System.Windows.Forms.CheckBox checkBoxEBS;
        internal System.Windows.Forms.TextBox txtAnnouncement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtOutputFile;
    }
}