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
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRet = new System.Windows.Forms.TextBox();
            this.CbxRunCmd = new System.Windows.Forms.ComboBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Result:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TxtRet
            // 
            this.TxtRet.Location = new System.Drawing.Point(81, 173);
            this.TxtRet.Multiline = true;
            this.TxtRet.Name = "TxtRet";
            this.TxtRet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtRet.Size = new System.Drawing.Size(701, 238);
            this.TxtRet.TabIndex = 9;
            // 
            // CbxRunCmd
            // 
            this.CbxRunCmd.FormattingEnabled = true;
            this.CbxRunCmd.Items.AddRange(new object[] {
            "ls /EMRCV5/BIN",
            "cat /EMRCV5/CONFIG/AppFunction.ini"});
            this.CbxRunCmd.Location = new System.Drawing.Point(81, 137);
            this.CbxRunCmd.Name = "CbxRunCmd";
            this.CbxRunCmd.Size = new System.Drawing.Size(619, 20);
            this.CbxRunCmd.TabIndex = 18;
            this.CbxRunCmd.Text = "Monitor";
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(81, 110);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(701, 21);
            this.TxtPwd.TabIndex = 15;
            this.TxtPwd.Text = "kissme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cmd";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(81, 78);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(701, 21);
            this.TxtUserName.TabIndex = 16;
            this.TxtUserName.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "PassWord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Name";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(81, 37);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(128, 21);
            this.TxtIP.TabIndex = 17;
            this.TxtIP.Text = "10.3.55.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP Heard";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(683, 434);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // ExecCommadFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CbxRunCmd);
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
        private System.Windows.Forms.ComboBox CbxRunCmd;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
    }
}