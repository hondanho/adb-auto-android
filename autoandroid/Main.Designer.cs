﻿namespace auto_android
{
    partial class Main
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGeneralSetting = new System.Windows.Forms.GroupBox();
            this.nudThreadNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetupMEmu = new System.Windows.Forms.Button();
            this.nupNoMEmuDevices = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMEmuRootPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuccess = new System.Windows.Forms.TextBox();
            this.txtFail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChooseBaseMEmu = new System.Windows.Forms.Button();
            this.txtMEmuZipBase = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbGeneralSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNoMEmuDevices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.Location = new System.Drawing.Point(16, 235);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // gbGeneralSetting
            // 
            this.gbGeneralSetting.Controls.Add(this.nudThreadNo);
            this.gbGeneralSetting.Controls.Add(this.label3);
            this.gbGeneralSetting.Location = new System.Drawing.Point(16, 15);
            this.gbGeneralSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGeneralSetting.Name = "gbGeneralSetting";
            this.gbGeneralSetting.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGeneralSetting.Size = new System.Drawing.Size(443, 213);
            this.gbGeneralSetting.TabIndex = 4;
            this.gbGeneralSetting.TabStop = false;
            this.gbGeneralSetting.Text = "Cài đặt chung";
            // 
            // nudThreadNo
            // 
            this.nudThreadNo.Location = new System.Drawing.Point(171, 28);
            this.nudThreadNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudThreadNo.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudThreadNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreadNo.Name = "nudThreadNo";
            this.nudThreadNo.Size = new System.Drawing.Size(53, 22);
            this.nudThreadNo.TabIndex = 3;
            this.nudThreadNo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudThreadNo.ValueChanged += new System.EventHandler(this.nudThreadNo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số luồng";
            // 
            // btnSetupMEmu
            // 
            this.btnSetupMEmu.Location = new System.Drawing.Point(21, 165);
            this.btnSetupMEmu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetupMEmu.Name = "btnSetupMEmu";
            this.btnSetupMEmu.Size = new System.Drawing.Size(109, 28);
            this.btnSetupMEmu.TabIndex = 7;
            this.btnSetupMEmu.Text = "Cài đặt";
            this.btnSetupMEmu.UseVisualStyleBackColor = true;
            this.btnSetupMEmu.Click += new System.EventHandler(this.btnSetupMEmu_Click);
            // 
            // nupNoMEmuDevices
            // 
            this.nupNoMEmuDevices.Location = new System.Drawing.Point(149, 60);
            this.nupNoMEmuDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nupNoMEmuDevices.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nupNoMEmuDevices.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNoMEmuDevices.Name = "nupNoMEmuDevices";
            this.nupNoMEmuDevices.Size = new System.Drawing.Size(53, 22);
            this.nupNoMEmuDevices.TabIndex = 6;
            this.nupNoMEmuDevices.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "No. MEmu devices";
            // 
            // txtMEmuRootPath
            // 
            this.txtMEmuRootPath.Location = new System.Drawing.Point(149, 27);
            this.txtMEmuRootPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMEmuRootPath.Name = "txtMEmuRootPath";
            this.txtMEmuRootPath.Size = new System.Drawing.Size(285, 22);
            this.txtMEmuRootPath.TabIndex = 1;
            this.txtMEmuRootPath.Text = "D:\\Program Files\\Microvirt\\MEmu";
            this.txtMEmuRootPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtMEmuRootPath_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MEmu root";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Successed Accounts";
            // 
            // txtSuccess
            // 
            this.txtSuccess.Location = new System.Drawing.Point(16, 310);
            this.txtSuccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSuccess.Multiline = true;
            this.txtSuccess.Name = "txtSuccess";
            this.txtSuccess.ReadOnly = true;
            this.txtSuccess.Size = new System.Drawing.Size(441, 255);
            this.txtSuccess.TabIndex = 6;
            // 
            // txtFail
            // 
            this.txtFail.Location = new System.Drawing.Point(479, 310);
            this.txtFail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFail.Multiline = true;
            this.txtFail.Name = "txtFail";
            this.txtFail.ReadOnly = true;
            this.txtFail.Size = new System.Drawing.Size(441, 255);
            this.txtFail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Failed Accounts";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnChooseBaseMEmu);
            this.groupBox1.Controls.Add(this.txtMEmuZipBase);
            this.groupBox1.Controls.Add(this.btnSetupMEmu);
            this.groupBox1.Controls.Add(this.nupNoMEmuDevices);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMEmuRootPath);
            this.groupBox1.Location = new System.Drawing.Point(479, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(444, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt MEmu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "MEmu zip base";
            // 
            // btnChooseBaseMEmu
            // 
            this.btnChooseBaseMEmu.Location = new System.Drawing.Point(380, 90);
            this.btnChooseBaseMEmu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseBaseMEmu.Name = "btnChooseBaseMEmu";
            this.btnChooseBaseMEmu.Size = new System.Drawing.Size(56, 28);
            this.btnChooseBaseMEmu.TabIndex = 9;
            this.btnChooseBaseMEmu.Text = "Chọn";
            this.btnChooseBaseMEmu.UseVisualStyleBackColor = true;
            this.btnChooseBaseMEmu.Click += new System.EventHandler(this.btnChooseBaseMEmu_Click);
            // 
            // txtMEmuZipBase
            // 
            this.txtMEmuZipBase.Location = new System.Drawing.Point(149, 92);
            this.txtMEmuZipBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMEmuZipBase.Name = "txtMEmuZipBase";
            this.txtMEmuZipBase.ReadOnly = true;
            this.txtMEmuZipBase.Size = new System.Drawing.Size(221, 22);
            this.txtMEmuZipBase.TabIndex = 8;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(140, 235);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 41);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 571);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFail);
            this.Controls.Add(this.txtSuccess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbGeneralSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(954, 618);
            this.MinimumSize = new System.Drawing.Size(954, 618);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.gbGeneralSetting.ResumeLayout(false);
            this.gbGeneralSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNoMEmuDevices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGeneralSetting;
        private System.Windows.Forms.TextBox txtMEmuRootPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudThreadNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetupMEmu;
        private System.Windows.Forms.NumericUpDown nupNoMEmuDevices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuccess;
        private System.Windows.Forms.TextBox txtFail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChooseBaseMEmu;
        private System.Windows.Forms.TextBox txtMEmuZipBase;
        private System.Windows.Forms.Button btnStop;
    }
}