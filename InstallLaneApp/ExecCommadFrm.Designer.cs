namespace InstallLaneApp
{
    partial class ExecCommadFrm
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
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRet = new System.Windows.Forms.TextBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TmResfh = new System.Windows.Forms.Timer(this.components);
            this.PbExec = new System.Windows.Forms.ProgressBar();
            this.LabTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCommaneName = new System.Windows.Forms.TextBox();
            this.LabMessage = new System.Windows.Forms.Label();
            this.BtnRetry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Result:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TxtRet
            // 
            this.TxtRet.Location = new System.Drawing.Point(81, 213);
            this.TxtRet.Multiline = true;
            this.TxtRet.Name = "TxtRet";
            this.TxtRet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtRet.Size = new System.Drawing.Size(701, 294);
            this.TxtRet.TabIndex = 9;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(81, 147);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(701, 21);
            this.TxtPwd.TabIndex = 15;
            this.TxtPwd.Text = "kissme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cmd Name";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(81, 112);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(701, 21);
            this.TxtUserName.TabIndex = 16;
            this.TxtUserName.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "PassWord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Name";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(81, 77);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(701, 21);
            this.TxtIP.TabIndex = 17;
            this.TxtIP.Text = "10.3.55.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP Heard";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(683, 559);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TmResfh
            // 
            this.TmResfh.Enabled = true;
            this.TmResfh.Interval = 1000;
            this.TmResfh.Tick += new System.EventHandler(this.TmResfh_Tick);
            // 
            // PbExec
            // 
            this.PbExec.Location = new System.Drawing.Point(81, 513);
            this.PbExec.Name = "PbExec";
            this.PbExec.Size = new System.Drawing.Size(701, 23);
            this.PbExec.TabIndex = 20;
            // 
            // LabTitle
            // 
            this.LabTitle.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTitle.Location = new System.Drawing.Point(11, 21);
            this.LabTitle.Name = "LabTitle";
            this.LabTitle.Size = new System.Drawing.Size(785, 33);
            this.LabTitle.TabIndex = 21;
            this.LabTitle.Text = "Runing Command";
            this.LabTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(1, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(794, 2);
            this.label9.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(1, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(794, 2);
            this.label6.TabIndex = 22;
            // 
            // txtCommaneName
            // 
            this.txtCommaneName.Location = new System.Drawing.Point(81, 183);
            this.txtCommaneName.Name = "txtCommaneName";
            this.txtCommaneName.Size = new System.Drawing.Size(701, 21);
            this.txtCommaneName.TabIndex = 23;
            this.txtCommaneName.Text = "root";
            // 
            // LabMessage
            // 
            this.LabMessage.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabMessage.ForeColor = System.Drawing.Color.Cyan;
            this.LabMessage.Location = new System.Drawing.Point(80, 553);
            this.LabMessage.Name = "LabMessage";
            this.LabMessage.Size = new System.Drawing.Size(507, 33);
            this.LabMessage.TabIndex = 21;
            this.LabMessage.Text = "Please Wait ……";
            this.LabMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnRetry
            // 
            this.BtnRetry.Location = new System.Drawing.Point(601, 559);
            this.BtnRetry.Name = "BtnRetry";
            this.BtnRetry.Size = new System.Drawing.Size(75, 23);
            this.BtnRetry.TabIndex = 19;
            this.BtnRetry.Text = "&Retry";
            this.BtnRetry.UseVisualStyleBackColor = true;
            this.BtnRetry.Click += new System.EventHandler(this.BtnRetry_Click);
            // 
            // ExecCommadFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.txtCommaneName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LabMessage);
            this.Controls.Add(this.LabTitle);
            this.Controls.Add(this.PbExec);
            this.Controls.Add(this.BtnRetry);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtRet);
            this.Name = "ExecCommadFrm";
            this.Text = "ExecCommadFrm";
            this.Load += new System.EventHandler(this.ExecCommadFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtRet;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Timer TmResfh;
        private System.Windows.Forms.ProgressBar PbExec;
        private System.Windows.Forms.Label LabTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCommaneName;
        private System.Windows.Forms.Label LabMessage;
        private System.Windows.Forms.Button BtnRetry;
    }
}