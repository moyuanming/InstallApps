namespace InstallLaneApp
{
    partial class InstalllanAppFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.cmd = new System.Windows.Forms.Label();
            this.BtnExec = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtRet = new System.Windows.Forms.TextBox();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.CbxCommandList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRun = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnClearMsg = new System.Windows.Forms.Button();
            this.CbxRunCmd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEStartIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEcount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtXStartIP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtXcount = new System.Windows.Forms.TextBox();
            this.CheckSinle = new System.Windows.Forms.CheckBox();
            this.TxtIP4 = new System.Windows.Forms.TextBox();
            this.PbExec = new System.Windows.Forms.ProgressBar();
            this.TmResfh = new System.Windows.Forms.Timer();
            this.LabMessage = new System.Windows.Forms.Label();
            this.BtnData = new System.Windows.Forms.Button();
            this.TxtRunCommand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Heard:";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(127, 79);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(128, 21);
            this.TxtIP.TabIndex = 1;
            this.TxtIP.Text = "10.3.55.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(127, 128);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(701, 21);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "PassWord:";
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(127, 161);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(701, 21);
            this.TxtPwd.TabIndex = 1;
            this.TxtPwd.Text = "kissme";
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(44, 198);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(71, 12);
            this.cmd.TabIndex = 0;
            this.cmd.Text = "Select Cmd:";
            // 
            // BtnExec
            // 
            this.BtnExec.Location = new System.Drawing.Point(753, 193);
            this.BtnExec.Name = "BtnExec";
            this.BtnExec.Size = new System.Drawing.Size(75, 23);
            this.BtnExec.TabIndex = 2;
            this.BtnExec.Text = "&Exec";
            this.BtnExec.UseVisualStyleBackColor = true;
            this.BtnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(764, 571);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtRet
            // 
            this.TxtRet.Location = new System.Drawing.Point(127, 259);
            this.TxtRet.Multiline = true;
            this.TxtRet.Name = "TxtRet";
            this.TxtRet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtRet.Size = new System.Drawing.Size(701, 259);
            this.TxtRet.TabIndex = 1;
            // 
            // BtnConfig
            // 
            this.BtnConfig.Location = new System.Drawing.Point(596, 571);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(75, 23);
            this.BtnConfig.TabIndex = 5;
            this.BtnConfig.Text = "&Config";
            this.BtnConfig.UseVisualStyleBackColor = true;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // CbxCommandList
            // 
            this.CbxCommandList.FormattingEnabled = true;
            this.CbxCommandList.Location = new System.Drawing.Point(127, 194);
            this.CbxCommandList.Name = "CbxCommandList";
            this.CbxCommandList.Size = new System.Drawing.Size(619, 20);
            this.CbxCommandList.TabIndex = 6;
            this.CbxCommandList.Text = "Monitor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cmd:";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(752, 225);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 7;
            this.BtnRun.Text = "&Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Result:";
            // 
            // BtnClearMsg
            // 
            this.BtnClearMsg.Location = new System.Drawing.Point(512, 571);
            this.BtnClearMsg.Name = "BtnClearMsg";
            this.BtnClearMsg.Size = new System.Drawing.Size(75, 23);
            this.BtnClearMsg.TabIndex = 9;
            this.BtnClearMsg.Text = "&CleareMsg";
            this.BtnClearMsg.UseVisualStyleBackColor = true;
            this.BtnClearMsg.Click += new System.EventHandler(this.BtnClearMsg_Click);
            // 
            // CbxRunCmd
            // 
            this.CbxRunCmd.FormattingEnabled = true;
            this.CbxRunCmd.Items.AddRange(new object[] {
            "ls /EMRCV5/BIN",
            "cat /EMRCV5/CONFIG/AppFunction.ini"});
            this.CbxRunCmd.Location = new System.Drawing.Point(127, 226);
            this.CbxRunCmd.Name = "CbxRunCmd";
            this.CbxRunCmd.Size = new System.Drawing.Size(257, 20);
            this.CbxRunCmd.TabIndex = 6;
            this.CbxRunCmd.Text = "Monitor";
            this.CbxRunCmd.SelectedIndexChanged += new System.EventHandler(this.CbxRunCmd_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(311, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lane Soft Tools";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(1, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(844, 2);
            this.label9.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(5, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(844, 2);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "E StartIP:";
            // 
            // TxtEStartIP
            // 
            this.TxtEStartIP.Enabled = false;
            this.TxtEStartIP.Location = new System.Drawing.Point(541, 62);
            this.TxtEStartIP.Name = "TxtEStartIP";
            this.TxtEStartIP.Size = new System.Drawing.Size(104, 21);
            this.TxtEStartIP.TabIndex = 1;
            this.TxtEStartIP.Text = "71";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "E Count:";
            // 
            // TxtEcount
            // 
            this.TxtEcount.Enabled = false;
            this.TxtEcount.Location = new System.Drawing.Point(724, 62);
            this.TxtEcount.Name = "TxtEcount";
            this.TxtEcount.Size = new System.Drawing.Size(104, 21);
            this.TxtEcount.TabIndex = 1;
            this.TxtEcount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "X StartIP:";
            // 
            // TxtXStartIP
            // 
            this.TxtXStartIP.Enabled = false;
            this.TxtXStartIP.Location = new System.Drawing.Point(541, 95);
            this.TxtXStartIP.Name = "TxtXStartIP";
            this.TxtXStartIP.Size = new System.Drawing.Size(104, 21);
            this.TxtXStartIP.TabIndex = 1;
            this.TxtXStartIP.Text = "51";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(667, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "X Count:";
            // 
            // TxtXcount
            // 
            this.TxtXcount.Enabled = false;
            this.TxtXcount.Location = new System.Drawing.Point(724, 95);
            this.TxtXcount.Name = "TxtXcount";
            this.TxtXcount.Size = new System.Drawing.Size(104, 21);
            this.TxtXcount.TabIndex = 1;
            this.TxtXcount.Text = "2";
            // 
            // CheckSinle
            // 
            this.CheckSinle.AutoSize = true;
            this.CheckSinle.Location = new System.Drawing.Point(379, 82);
            this.CheckSinle.Name = "CheckSinle";
            this.CheckSinle.Size = new System.Drawing.Size(72, 16);
            this.CheckSinle.TabIndex = 12;
            this.CheckSinle.Text = "Multiple";
            this.CheckSinle.UseVisualStyleBackColor = true;
            this.CheckSinle.CheckedChanged += new System.EventHandler(this.CheckSinle_CheckedChanged);
            // 
            // TxtIP4
            // 
            this.TxtIP4.Location = new System.Drawing.Point(261, 79);
            this.TxtIP4.Name = "TxtIP4";
            this.TxtIP4.Size = new System.Drawing.Size(101, 21);
            this.TxtIP4.TabIndex = 1;
            this.TxtIP4.Text = "51";
            // 
            // PbExec
            // 
            this.PbExec.Location = new System.Drawing.Point(127, 524);
            this.PbExec.Name = "PbExec";
            this.PbExec.Size = new System.Drawing.Size(701, 23);
            this.PbExec.TabIndex = 21;
            // 
            // TmResfh
            // 
            this.TmResfh.Enabled = true;
            this.TmResfh.Interval = 1000;
            this.TmResfh.Tick += new System.EventHandler(this.TmResfh_Tick);
            // 
            // LabMessage
            // 
            this.LabMessage.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabMessage.ForeColor = System.Drawing.Color.Cyan;
            this.LabMessage.Location = new System.Drawing.Point(121, 561);
            this.LabMessage.Name = "LabMessage";
            this.LabMessage.Size = new System.Drawing.Size(330, 33);
            this.LabMessage.TabIndex = 22;
            this.LabMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnData
            // 
            this.BtnData.Location = new System.Drawing.Point(680, 571);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(75, 23);
            this.BtnData.TabIndex = 23;
            this.BtnData.Text = "&Lane Data";
            this.BtnData.UseVisualStyleBackColor = true;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // TxtRunCommand
            // 
            this.TxtRunCommand.Location = new System.Drawing.Point(390, 225);
            this.TxtRunCommand.Name = "TxtRunCommand";
            this.TxtRunCommand.Size = new System.Drawing.Size(356, 21);
            this.TxtRunCommand.TabIndex = 1;
            this.TxtRunCommand.Text = "51";
            // 
            // InstalllanAppFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 601);
            this.Controls.Add(this.BtnData);
            this.Controls.Add(this.LabMessage);
            this.Controls.Add(this.PbExec);
            this.Controls.Add(this.CheckSinle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnClearMsg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.CbxRunCmd);
            this.Controls.Add(this.CbxCommandList);
            this.Controls.Add(this.BtnConfig);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnExec);
            this.Controls.Add(this.TxtRet);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRunCommand);
            this.Controls.Add(this.TxtIP4);
            this.Controls.Add(this.TxtXcount);
            this.Controls.Add(this.TxtEcount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtXStartIP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtEStartIP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtIP);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(867, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(867, 640);
            this.Name = "InstalllanAppFrom";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstalllanAppFrom";
            this.Load += new System.EventHandler(this.InstalllanAppFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.Label cmd;
        private System.Windows.Forms.Button BtnExec;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtRet;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.ComboBox CbxCommandList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnClearMsg;
        private System.Windows.Forms.ComboBox CbxRunCmd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEStartIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtEcount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtXStartIP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtXcount;
        private System.Windows.Forms.CheckBox CheckSinle;
        private System.Windows.Forms.TextBox TxtIP4;
        private System.Windows.Forms.ProgressBar PbExec;
        private System.Windows.Forms.Timer TmResfh;
        private System.Windows.Forms.Label LabMessage;
        private System.Windows.Forms.Button BtnData;
        private System.Windows.Forms.TextBox TxtRunCommand;
    }
}