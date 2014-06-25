using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using Routrek.Crypto;
using Routrek.SSHC;
using Routrek.SSHCV1;
using Routrek.SSHCV2;
using Routrek.Toolkit;
using Routrek.PKI;
namespace InstallLaneApp
{
    public partial class InstalllanAppFrom : Form
    {
        public InstalllanAppFrom()
        {
            InitializeComponent();
        }

        LanToolsConfig Lts;
        LaneCommand SelectCommd;
        void SetCommand(string CommandName)
        {
            foreach (LaneCommand tmp in Lts.CommandList)
            {
                if (CommandName == tmp.Name)
                {
                    SelectCommd = tmp;
                    return;
                }
            }
            SelectCommd = null;
        }
        void LoadCommandFile()
        {
            CbxCommandList.Items.Clear();
            CbxRunCmd.Items.Clear();
            try
            {
                Lts = LanToolsConfig.LoadFile("Command.xml");

                foreach (LaneCommand tmp in Lts.CommandList)
                {
                    CbxCommandList.Items.Add(tmp.Name);

                }
                foreach (ExecCommands tmp in Lts.Commands)
                {
                    CbxRunCmd.Items.Add(tmp.CommandName);

                }
                CbxCommandList.SelectedIndex = 0;
                CbxRunCmd.SelectedIndex = 0;
                TxtXcount.Text = Lts.Xcount.ToString();
                TxtEcount.Text = Lts.ECount.ToString();
                TxtXStartIP.Text = Lts.XstartIP.ToString();
                TxtEStartIP.Text = Lts.EStartIP.ToString();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("没有可以安装的程序！！检查Apps.xml是否存在");

            }
        }
        private void InstalllanAppFrom_Load(object sender, EventArgs e)
        {
            LoadCommandFile();
        }
        string UploadFile(string localFilePath,string remoteFilePath)
        {
           string IP = string.Format("{0}{1}", TxtIP.Text, TxtIP4.Text);
           return SFtptools.SftpUpload(IP, TxtUserName.Text, TxtPwd.Text, localFilePath, remoteFilePath);
        }
        bool RetState = true;
        void SSh_RetStateEnevt(bool ret)
        {
            RetState = ret;
        }
        int RetValue = 0;
        void SSh_RetPressEvent(int Input)
        {
            RetValue = Input;
        }
        string RetMsg = "";
        void SSh_RetMessageEvent(string Message)
        {
            RetMsg += Message +"\r\n";
        }
        void ExecCmd(string CmdString)
        {
            ECToolsInterface ECServer; ;
            if (RbSSH2.Checked)
            {
                ECServer = new SSh2Tools();
            }
            else
            {
                ECServer = new TelentTools();
            }
            ECServer.RetMessageEvent += SSh_RetMessageEvent;
            ECServer.RetPressEvent += SSh_RetPressEvent;
            ECServer.RetStateEnevt += SSh_RetStateEnevt;
            string IP = string.Format("{0}{1}", TxtIP.Text,TxtIP4.Text);
            ECServer.ExecCommand(IP, TxtUserName.Text, TxtPwd.Text, CmdString);
         
        }
        
        void ExecMultipleMachine(string IPHead,int StartIP,int Count,int Type,string Commandstring)
        {
            for (int i = 0; i < Count; i++)
            {
                string IP = string.Format("{0}{1}", IPHead, StartIP + i);

                ExecCommadFrm Frm = new ExecCommadFrm();
                Frm.IP = IP;
                Frm.UserName = TxtUserName.Text;
                Frm.Pwd = TxtPwd.Text;
                Frm.MyCommand = SelectCommd;
                Frm.CommandString = Commandstring;
                Frm.ExecType = Type;
                Frm.Show();
            }
        }
        void RunCommand()
        {
                if (null != SelectCommd)
                {                
                    
                    foreach (UploadFile tmp in SelectCommd.UploadFileList)
                    {
                        UploadFile(string.Format(@"Command\{0}", tmp.FilePath), string.Format(@"/mnt/{0}", tmp.FilePath));
                    }
                    ExecCmd(string.Format(@"chmod +x /mnt/ -R ", SelectCommd.ExecFileName));
                    ExecCmd(string.Format(@"/mnt/{0}", SelectCommd.ExecFileName));
                }
        }
        private void BtnExec_Click(object sender, EventArgs e)
        {
            SetCommand(CbxCommandList.Text);
            if (!CheckSinle.Checked)
            {
                LabMessage.Text = "Please Wait ……!";
                RetMsg = "";
                LabMessage.ForeColor = System.Drawing.Color.Cyan;
                Thread Th = new Thread(RunCommand);
                Th.Start();
            }
            else
            {
                
                ExecMultipleMachine(TxtIP.Text, Convert.ToInt32(TxtEStartIP.Text), Convert.ToInt32(TxtEcount.Text),0,"");
                ExecMultipleMachine(TxtIP.Text, Convert.ToInt32(TxtXStartIP.Text), Convert.ToInt32(TxtXcount.Text),0,"");              
            }   
        }
        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (!CheckSinle.Checked)
            {
                RetMsg = "";
                ExecCmd(TxtRunCommand.Text);
            }
            else
            {
               // RetMsg = ""; 
                ExecMultipleMachine(TxtIP.Text, Convert.ToInt32(TxtEStartIP.Text), Convert.ToInt32(TxtEcount.Text), 1, TxtRunCommand.Text);
                ExecMultipleMachine(TxtIP.Text, Convert.ToInt32(TxtXStartIP.Text), Convert.ToInt32(TxtXcount.Text), 1, TxtRunCommand.Text);  
            }
        }
        private void BtnConfig_Click(object sender, EventArgs e)
        {
            LanCommandConfigFrm frm = new LanCommandConfigFrm();
            frm.ShowDialog();
            LoadCommandFile();           
        }
    

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    

        private void BtnClearMsg_Click(object sender, EventArgs e)
        {
            RetMsg = "";
        }


   

        private void CheckSinle_CheckedChanged(object sender, EventArgs e)
        {
            TxtEcount.Enabled = CheckSinle.Checked;
            TxtXcount.Enabled = CheckSinle.Checked;
            TxtEStartIP.Enabled = CheckSinle.Checked;
            TxtXStartIP.Enabled = CheckSinle.Checked;
            TxtIP4.Enabled = !CheckSinle.Checked;
        }

        private void TmResfh_Tick(object sender, EventArgs e)
        {
            TxtRet.Text = RetMsg;
            PbExec.Value = RetValue;
            if (100 == PbExec.Value)
            {
                LabMessage.Text = "Command Run Success!";
                LabMessage.ForeColor = System.Drawing.Color.Green;
                
            }
            if (!RetState)
            {
               
                LabMessage.Text = "Command Run Failure!";
                LabMessage.ForeColor = System.Drawing.Color.Red;
               
            }
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            ReTranData Frm = new ReTranData();
            Frm.ShowDialog();
        }

        private void CbxRunCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtRunCommand.Text = Lts.Commands[CbxRunCmd.SelectedIndex].Command;
        }

        private void TxtRunCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                RetMsg = "";
                ExecCmd(TxtRunCommand.Text);
                TxtRunCommand.Text = "";
            }
        }

        private void BtnPut_Click(object sender, EventArgs e)
        {
            SFtptools.SftpUpload(TxtIP.Text+TxtIP4.Text, TxtUserName.Text, TxtPwd.Text, TxtFrom.Text, TxtTo.Text);
        }
    }
}
