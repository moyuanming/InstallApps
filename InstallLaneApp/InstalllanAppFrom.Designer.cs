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
            this.TxtCmd = new System.Windows.Forms.TextBox();
            this.BtnExec = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtRet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lane IP";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(127, 71);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(220, 21);
            this.TxtIP.TabIndex = 1;
            this.TxtIP.Text = "10.3.55.51";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(127, 100);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(220, 21);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "PassWord";
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(127, 132);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(220, 21);
            this.TxtPwd.TabIndex = 1;
            this.TxtPwd.Text = "kissme";
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(56, 165);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(23, 12);
            this.cmd.TabIndex = 0;
            this.cmd.Text = "Cmd";
            // 
            // TxtCmd
            // 
            this.TxtCmd.Location = new System.Drawing.Point(127, 162);
            this.TxtCmd.Name = "TxtCmd";
            this.TxtCmd.Size = new System.Drawing.Size(220, 21);
            this.TxtCmd.TabIndex = 1;
            this.TxtCmd.Text = "ls";
            // 
            // BtnExec
            // 
            this.BtnExec.Location = new System.Drawing.Point(188, 397);
            this.BtnExec.Name = "BtnExec";
            this.BtnExec.Size = new System.Drawing.Size(75, 23);
            this.BtnExec.TabIndex = 2;
            this.BtnExec.Text = "&Exec";
            this.BtnExec.UseVisualStyleBackColor = true;
            this.BtnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(269, 397);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ls";
            // 
            // TxtRet
            // 
            this.TxtRet.Location = new System.Drawing.Point(127, 239);
            this.TxtRet.Multiline = true;
            this.TxtRet.Name = "TxtRet";
            this.TxtRet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtRet.Size = new System.Drawing.Size(220, 133);
            this.TxtRet.TabIndex = 1;
            this.TxtRet.Text = "ls";
            // 
            // InstalllanAppFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 464);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnExec);
            this.Controls.Add(this.TxtRet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtCmd);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIP);
            this.Controls.Add(this.label1);
            this.Name = "InstalllanAppFrom";
            this.Text = "InstalllanAppFrom";
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
        private System.Windows.Forms.TextBox TxtCmd;
        private System.Windows.Forms.Button BtnExec;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtRet;
    }
}