namespace InstallApp
{
    partial class InstallFrom
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
            this.components = new System.ComponentModel.Container();
            this.BtnInstall = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxApp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxPlaza = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtInstallPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnClearMsg = new System.Windows.Forms.Button();
            this.BtnSetTime = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnSetTime8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSvnName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtSvnPwd = new System.Windows.Forms.TextBox();
            this.TmResfh = new System.Windows.Forms.Timer(this.components);
            this.PbExec = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnExeccmd = new System.Windows.Forms.Button();
            this.CbxRunCmd = new System.Windows.Forms.ComboBox();
            this.TxtRunCommand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnInstall
            // 
            this.BtnInstall.Location = new System.Drawing.Point(755, 191);
            this.BtnInstall.Name = "BtnInstall";
            this.BtnInstall.Size = new System.Drawing.Size(75, 23);
            this.BtnInstall.TabIndex = 0;
            this.BtnInstall.Text = "&Install";
            this.BtnInstall.UseVisualStyleBackColor = true;
            this.BtnInstall.Click += new System.EventHandler(this.BtnInstall_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(487, 537);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "&Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(736, 537);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "NetWork:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plaza:";
            // 
            // TxtNet
            // 
            this.TxtNet.Location = new System.Drawing.Point(133, 134);
            this.TxtNet.Name = "TxtNet";
            this.TxtNet.Size = new System.Drawing.Size(305, 21);
            this.TxtNet.TabIndex = 4;
            this.TxtNet.Text = "03";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "App:";
            // 
            // CbxApp
            // 
            this.CbxApp.FormattingEnabled = true;
            this.CbxApp.Location = new System.Drawing.Point(133, 163);
            this.CbxApp.Name = "CbxApp";
            this.CbxApp.Size = new System.Drawing.Size(697, 20);
            this.CbxApp.TabIndex = 5;
            this.CbxApp.Text = "Monitor";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(5, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(825, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plaza App Install Tools";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxPlaza
            // 
            this.CbxPlaza.FormattingEnabled = true;
            this.CbxPlaza.Items.AddRange(new object[] {
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61"});
            this.CbxPlaza.Location = new System.Drawing.Point(525, 134);
            this.CbxPlaza.Name = "CbxPlaza";
            this.CbxPlaza.Size = new System.Drawing.Size(305, 20);
            this.CbxPlaza.TabIndex = 5;
            this.CbxPlaza.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "ServerIP:";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(134, 74);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(696, 21);
            this.TxtIP.TabIndex = 4;
            this.TxtIP.Text = "10.3.54.11";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Install Path:";
            // 
            // TxtInstallPath
            // 
            this.TxtInstallPath.Location = new System.Drawing.Point(133, 192);
            this.TxtInstallPath.Name = "TxtInstallPath";
            this.TxtInstallPath.Size = new System.Drawing.Size(619, 21);
            this.TxtInstallPath.TabIndex = 4;
            this.TxtInstallPath.Text = "D:\\RHYSOFT";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(7, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(833, 2);
            this.label7.TabIndex = 6;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(133, 255);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtResult.Size = new System.Drawing.Size(697, 237);
            this.TxtResult.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "Result:";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(833, 2);
            this.label9.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnClearMsg
            // 
            this.BtnClearMsg.Location = new System.Drawing.Point(570, 537);
            this.BtnClearMsg.Name = "BtnClearMsg";
            this.BtnClearMsg.Size = new System.Drawing.Size(75, 23);
            this.BtnClearMsg.TabIndex = 1;
            this.BtnClearMsg.Text = "&CleareMsg";
            this.BtnClearMsg.UseVisualStyleBackColor = true;
            this.BtnClearMsg.Click += new System.EventHandler(this.BtnClearMsg_Click);
            // 
            // BtnSetTime
            // 
            this.BtnSetTime.Location = new System.Drawing.Point(320, 537);
            this.BtnSetTime.Name = "BtnSetTime";
            this.BtnSetTime.Size = new System.Drawing.Size(75, 23);
            this.BtnSetTime.TabIndex = 8;
            this.BtnSetTime.Text = "UTC";
            this.BtnSetTime.UseVisualStyleBackColor = true;
            this.BtnSetTime.Click += new System.EventHandler(this.BtnSetTime_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(5, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(833, 2);
            this.label10.TabIndex = 9;
            // 
            // BtnSetTime8
            // 
            this.BtnSetTime8.Location = new System.Drawing.Point(403, 537);
            this.BtnSetTime8.Name = "BtnSetTime8";
            this.BtnSetTime8.Size = new System.Drawing.Size(75, 23);
            this.BtnSetTime8.TabIndex = 10;
            this.BtnSetTime8.Text = "UTC+8";
            this.BtnSetTime8.UseVisualStyleBackColor = true;
            this.BtnSetTime8.Click += new System.EventHandler(this.BtnSetTime8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "SvnName:";
            // 
            // TxtSvnName
            // 
            this.TxtSvnName.Location = new System.Drawing.Point(133, 104);
            this.TxtSvnName.Name = "TxtSvnName";
            this.TxtSvnName.Size = new System.Drawing.Size(305, 21);
            this.TxtSvnName.TabIndex = 4;
            this.TxtSvnName.Text = "mym";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(459, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "SvnPwd:";
            // 
            // TxtSvnPwd
            // 
            this.TxtSvnPwd.Location = new System.Drawing.Point(525, 104);
            this.TxtSvnPwd.Name = "TxtSvnPwd";
            this.TxtSvnPwd.PasswordChar = '*';
            this.TxtSvnPwd.Size = new System.Drawing.Size(305, 21);
            this.TxtSvnPwd.TabIndex = 4;
            this.TxtSvnPwd.Text = "future";
            // 
            // TmResfh
            // 
            this.TmResfh.Enabled = true;
            this.TmResfh.Interval = 1000;
            this.TmResfh.Tick += new System.EventHandler(this.TmResfh_Tick);
            // 
            // PbExec
            // 
            this.PbExec.Location = new System.Drawing.Point(134, 498);
            this.PbExec.Name = "PbExec";
            this.PbExec.Size = new System.Drawing.Size(696, 23);
            this.PbExec.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "ExecCmd:";
            // 
            // BtnExeccmd
            // 
            this.BtnExeccmd.Location = new System.Drawing.Point(755, 219);
            this.BtnExeccmd.Name = "BtnExeccmd";
            this.BtnExeccmd.Size = new System.Drawing.Size(75, 23);
            this.BtnExeccmd.TabIndex = 23;
            this.BtnExeccmd.Text = "&Exec";
            this.BtnExeccmd.UseVisualStyleBackColor = true;
            this.BtnExeccmd.Click += new System.EventHandler(this.BtnExeccmd_Click);
            // 
            // CbxRunCmd
            // 
            this.CbxRunCmd.FormattingEnabled = true;
            this.CbxRunCmd.Items.AddRange(new object[] {
            "ls /EMRCV5/BIN",
            "cat /EMRCV5/CONFIG/AppFunction.ini"});
            this.CbxRunCmd.Location = new System.Drawing.Point(133, 223);
            this.CbxRunCmd.Name = "CbxRunCmd";
            this.CbxRunCmd.Size = new System.Drawing.Size(257, 20);
            this.CbxRunCmd.TabIndex = 25;
            this.CbxRunCmd.Text = "Monitor";
            this.CbxRunCmd.SelectedIndexChanged += new System.EventHandler(this.CbxRunCmd_SelectedIndexChanged);
            // 
            // TxtRunCommand
            // 
            this.TxtRunCommand.Location = new System.Drawing.Point(396, 222);
            this.TxtRunCommand.Name = "TxtRunCommand";
            this.TxtRunCommand.Size = new System.Drawing.Size(356, 21);
            this.TxtRunCommand.TabIndex = 24;
            this.TxtRunCommand.Text = "51";
            // 
            // InstallFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 572);
            this.Controls.Add(this.CbxRunCmd);
            this.Controls.Add(this.TxtRunCommand);
            this.Controls.Add(this.BtnExeccmd);
            this.Controls.Add(this.PbExec);
            this.Controls.Add(this.BtnSetTime8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnSetTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxPlaza);
            this.Controls.Add(this.CbxApp);
            this.Controls.Add(this.TxtIP);
            this.Controls.Add(this.TxtInstallPath);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtSvnPwd);
            this.Controls.Add(this.TxtSvnName);
            this.Controls.Add(this.TxtNet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnClearMsg);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInstall);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Tools";
            this.Load += new System.EventHandler(this.InstallFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInstall;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxApp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxPlaza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtInstallPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnClearMsg;
        private System.Windows.Forms.Button BtnSetTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnSetTime8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSvnName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtSvnPwd;
        private System.Windows.Forms.Timer TmResfh;
        private System.Windows.Forms.ProgressBar PbExec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnExeccmd;
        private System.Windows.Forms.ComboBox CbxRunCmd;
        private System.Windows.Forms.TextBox TxtRunCommand;
    }
}