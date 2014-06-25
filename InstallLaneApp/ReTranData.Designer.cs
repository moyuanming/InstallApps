namespace InstallLaneApp
{
    partial class ReTranData
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
            this.DgView = new System.Windows.Forms.DataGridView();
            this.BtnReUpLoad = new System.Windows.Forms.Button();
            this.LabTitle = new System.Windows.Forms.Label();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DptStartTime = new System.Windows.Forms.DateTimePicker();
            this.DptEndTime = new System.Windows.Forms.DateTimePicker();
            this.TxtReCounts = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMsgType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCollect = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUpFlag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtDB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtWhere = new System.Windows.Forms.TextBox();
            this.PbExec = new System.Windows.Forms.ProgressBar();
            this.TmResfh = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgView)).BeginInit();
            this.SuspendLayout();
            // 
            // DgView
            // 
            this.DgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgView.Location = new System.Drawing.Point(93, 230);
            this.DgView.Name = "DgView";
            this.DgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DgView.RowTemplate.Height = 23;
            this.DgView.Size = new System.Drawing.Size(725, 212);
            this.DgView.TabIndex = 0;
            // 
            // BtnReUpLoad
            // 
            this.BtnReUpLoad.Location = new System.Drawing.Point(571, 494);
            this.BtnReUpLoad.Name = "BtnReUpLoad";
            this.BtnReUpLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnReUpLoad.TabIndex = 1;
            this.BtnReUpLoad.Text = "ReUpLoad";
            this.BtnReUpLoad.UseVisualStyleBackColor = true;
            this.BtnReUpLoad.Click += new System.EventHandler(this.BtnReUpLoad_Click);
            // 
            // LabTitle
            // 
            this.LabTitle.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTitle.Location = new System.Drawing.Point(22, 9);
            this.LabTitle.Name = "LabTitle";
            this.LabTitle.Size = new System.Drawing.Size(785, 33);
            this.LabTitle.TabIndex = 28;
            this.LabTitle.Text = "Query Lane Message And Re UpLoad Message";
            this.LabTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(636, 65);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(182, 21);
            this.TxtPwd.TabIndex = 25;
            this.TxtPwd.Text = "kissme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "PassWord:";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(93, 65);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(182, 21);
            this.TxtIP.TabIndex = 27;
            this.TxtIP.Text = "10.3.55.51";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "IP Heard:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "User Name:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(355, 65);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(182, 21);
            this.TxtUserName.TabIndex = 26;
            this.TxtUserName.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "StartTime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "EndTime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "ReturnCount:";
            // 
            // DptStartTime
            // 
            this.DptStartTime.Location = new System.Drawing.Point(93, 95);
            this.DptStartTime.Name = "DptStartTime";
            this.DptStartTime.Size = new System.Drawing.Size(182, 21);
            this.DptStartTime.TabIndex = 29;
            // 
            // DptEndTime
            // 
            this.DptEndTime.Location = new System.Drawing.Point(355, 95);
            this.DptEndTime.Name = "DptEndTime";
            this.DptEndTime.Size = new System.Drawing.Size(182, 21);
            this.DptEndTime.TabIndex = 29;
            // 
            // TxtReCounts
            // 
            this.TxtReCounts.Location = new System.Drawing.Point(636, 95);
            this.TxtReCounts.Name = "TxtReCounts";
            this.TxtReCounts.Size = new System.Drawing.Size(182, 21);
            this.TxtReCounts.TabIndex = 26;
            this.TxtReCounts.Text = "500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "MsgType:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtMsgType
            // 
            this.TxtMsgType.Location = new System.Drawing.Point(93, 125);
            this.TxtMsgType.Name = "TxtMsgType";
            this.TxtMsgType.Size = new System.Drawing.Size(182, 21);
            this.TxtMsgType.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "Collect:";
            // 
            // TxtCollect
            // 
            this.TxtCollect.Location = new System.Drawing.Point(355, 125);
            this.TxtCollect.Name = "TxtCollect";
            this.TxtCollect.Size = new System.Drawing.Size(182, 21);
            this.TxtCollect.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "UploadFlag:";
            // 
            // TxtUpFlag
            // 
            this.TxtUpFlag.Location = new System.Drawing.Point(636, 125);
            this.TxtUpFlag.Name = "TxtUpFlag";
            this.TxtUpFlag.Size = new System.Drawing.Size(182, 21);
            this.TxtUpFlag.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "Result:";
            // 
            // BtnQuery
            // 
            this.BtnQuery.Location = new System.Drawing.Point(485, 494);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(75, 23);
            this.BtnQuery.TabIndex = 1;
            this.BtnQuery.Text = "Query";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(665, 494);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "LaneDBPath:";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtDB
            // 
            this.TxtDB.Location = new System.Drawing.Point(93, 200);
            this.TxtDB.Name = "TxtDB";
            this.TxtDB.Size = new System.Drawing.Size(725, 21);
            this.TxtDB.TabIndex = 27;
            this.TxtDB.Text = "/EMRCV5/DATA/EMRC_MSG_DB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "LaneDBPath:";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtWhere
            // 
            this.TxtWhere.Location = new System.Drawing.Point(93, 155);
            this.TxtWhere.Multiline = true;
            this.TxtWhere.Name = "TxtWhere";
            this.TxtWhere.Size = new System.Drawing.Size(725, 36);
            this.TxtWhere.TabIndex = 27;
            this.TxtWhere.Text = "where  MessageTime>=\\\"{0}\\\" and MessageTime <=\\\"{1}\\\" and substr(MessageBody,19,2" +
    ") like \\\"%{2}%\\\" and substr(MessageBody,65,6) like\\\"%{3}%\\\" and Mark like\\\"%{4}%" +
    "\\\"";
            // 
            // PbExec
            // 
            this.PbExec.Location = new System.Drawing.Point(93, 450);
            this.PbExec.Name = "PbExec";
            this.PbExec.Size = new System.Drawing.Size(725, 23);
            this.PbExec.TabIndex = 31;
            // 
            // TmResfh
            // 
            this.TmResfh.Enabled = true;
            this.TmResfh.Interval = 10;
            this.TmResfh.Tick += new System.EventHandler(this.TmResfh_Tick);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(17, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(794, 2);
            this.label13.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(23, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(794, 2);
            this.label14.TabIndex = 32;
            // 
            // ReTranData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 526);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PbExec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DptEndTime);
            this.Controls.Add(this.DptStartTime);
            this.Controls.Add(this.LabTitle);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtReCounts);
            this.Controls.Add(this.TxtUpFlag);
            this.Controls.Add(this.TxtCollect);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtMsgType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtWhere);
            this.Controls.Add(this.TxtDB);
            this.Controls.Add(this.TxtIP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnReUpLoad);
            this.Controls.Add(this.DgView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 565);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(842, 565);
            this.Name = "ReTranData";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReTranData";
            this.Load += new System.EventHandler(this.ReTranData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgView;
        private System.Windows.Forms.Button BtnReUpLoad;
        private System.Windows.Forms.Label LabTitle;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DptStartTime;
        private System.Windows.Forms.DateTimePicker DptEndTime;
        private System.Windows.Forms.TextBox TxtReCounts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMsgType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCollect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUpFlag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtWhere;
        private System.Windows.Forms.ProgressBar PbExec;
        private System.Windows.Forms.Timer TmResfh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}