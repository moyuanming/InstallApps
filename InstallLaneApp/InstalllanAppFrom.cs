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
    public partial class InstalllanAppFrom : Form,ISSHConnectionEventReceiver, ISSHChannelEventReceiver
    {
        public InstalllanAppFrom()
        {
            InitializeComponent();
        }
        private static SSHConnection _conn;
        string ret = "";
        public void OnData(byte[] data, int offset, int length)
        {
            ret = Encoding.ASCII.GetString(data, offset, length);
        }
        public void OnDebugMessage(bool always_display, byte[] data)
        {
            Debug.WriteLine("DEBUG: " + Encoding.ASCII.GetString(data));
        }
        public void OnIgnoreMessage(byte[] data)
        {
            Debug.WriteLine("Ignore: " + Encoding.ASCII.GetString(data));
        }
        public void OnAuthenticationPrompt(string[] msg)
        {
            Debug.WriteLine("Auth Prompt " + msg[0]);
        }

        public void OnError(Exception error, string msg)
        {
            Debug.WriteLine("ERROR: " + msg);
        }
        public void OnChannelClosed()
        {
            Debug.WriteLine("Channel closed");
            _conn.Disconnect("");
            //_conn.AsyncReceive(this);
        }
        public void OnChannelEOF()
        {
            _pf.Close();
            Debug.WriteLine("Channel EOF");
        }
        public void OnExtendedData(int type, byte[] data)
        {
            Debug.WriteLine("EXTENDED DATA");
        }
        public void OnConnectionClosed()
        {
            Debug.WriteLine("Connection closed");
        }
        public void OnUnknownMessage(byte type, byte[] data)
        {
            Debug.WriteLine("Unknown Message " + type);
        }
        public void OnChannelReady()
        {
            
        }
        public void OnChannelError(Exception error, string msg)
        {
            Debug.WriteLine("Channel ERROR: " + msg);
        }
        public void OnMiscPacket(byte type, byte[] data, int offset, int length)
        {
        }
        public SSHChannel _pf;
        public PortForwardingCheckResult CheckPortForwardingRequest(string host, int port, string originator_host, int originator_port)
        {
            PortForwardingCheckResult r = new PortForwardingCheckResult();
            r.allowed = true;
            r.channel = this;
            return r;
        }
        public void EstablishPortforwarding(ISSHChannelEventReceiver rec, SSHChannel channel)
        {
            _pf = channel;
        }

        string UploadFile(string localFilePath,string remoteFilePath)
        {
           return SFtptools.SftpUpload(TxtIP.Text, TxtUserName.Text, TxtPwd.Text, localFilePath, remoteFilePath);
        }
        void ExecCmd(string CmdString)
        {
            SSh2Tools.SSHRSMC(TxtIP.Text, TxtUserName.Text, TxtPwd.Text, CmdString, TxtRet);
         
        }
        void ExecMultipleMachine(string IPHead,int StartIP,int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                string IP = string.Format("{0}{1}", IPHead, StartIP + Count);

                ExecCommadFrm Frm = new ExecCommadFrm();
                Frm.IP = IP;
                Frm.UserName = TxtUserName.Text;
                Frm.Pwd = TxtPwd.Text;
                Frm.MyCommand = SelectCommd;
                Frm.Show();
            }
        }
        private void BtnExec_Click(object sender, EventArgs e)
        {
            SetCommand(CbxCommandList.Text);
            if (CheckSinle.Checked)
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
            else
            {

                ExecMultipleMachine(TxtIP.Text, Convert.ToInt32(TxtEStartIP.Text), Convert.ToInt32(TxtEcount.Text));
                ExecMultipleMachine(TxtIP.Text, Convert.ToInt32(TxtXStartIP.Text), Convert.ToInt32(TxtXcount.Text));              
            }
            
            return;




        }

     

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            LanCommandConfigFrm frm = new LanCommandConfigFrm();
            frm.ShowDialog();


            LoadCommandFile();
           
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
                    return ;
                }
            }
            SelectCommd = null;
        }
        void LoadCommandFile()
        {
            CbxCommandList.Items.Clear();
            try
            {
                Lts = LanToolsConfig.LoadFile("Command.xml");

                foreach (LaneCommand tmp in Lts.CommandList)
                {
                    CbxCommandList.Items.Add(tmp.Name);

                }
                CbxCommandList.SelectedIndex = 0;
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            ExecCmd(CbxRunCmd.Text);
        }

        private void BtnClearMsg_Click(object sender, EventArgs e)
        {
            TxtRet.Text = "";
        }


   

        private void CheckSinle_CheckedChanged(object sender, EventArgs e)
        {
            TxtEcount.Enabled = !CheckSinle.Checked;
            TxtXcount.Enabled = !CheckSinle.Checked;
            TxtEStartIP.Enabled = !CheckSinle.Checked;
            TxtXStartIP.Enabled = !CheckSinle.Checked;
            TxtIP4.Enabled = CheckSinle.Checked;
        }
    }
}
