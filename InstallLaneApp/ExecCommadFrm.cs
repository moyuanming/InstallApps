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
namespace InstallLaneApp
{
    public partial class ExecCommadFrm : Form
    {
        public ExecCommadFrm()
        {
            InitializeComponent();
        }       
        public string IP
        {
            get { return TxtIP.Text; }
            set { TxtIP.Text = value; }
        }      
        public string UserName
        {
            get { return TxtUserName.Text; }
            set { TxtUserName.Text = value; }
        }       
        public string Pwd
        {
            get { return TxtPwd.Text; }
            set { TxtPwd.Text = value; }
        }
        LaneCommand _MyCommand;
        public InstallLaneApp.LaneCommand MyCommand
        {
            get { return _MyCommand; }
            set { _MyCommand = value;
            
            }
        }
        string _CommandString;
        public string CommandString
        {
            get { return _CommandString; }
            set { _CommandString = value; }
        }
        int _ExecType = 0;
        public int ExecType
        {
            get { return _ExecType; }
            set { 
                
                _ExecType = value;
                if (0 == _ExecType)
                {
                    txtCommaneName.Text = _MyCommand.Name;
                }
                else
                {
                    txtCommaneName.Text = _CommandString;
                }
            }
        }
        void RunCommand()
        {

            SSh2Tools SShTools = new SSh2Tools();
            SShTools.RetMessageEvent += SShTools_RetMessageEvent;
            SShTools.RetPressEvent += RetPress;
            SShTools.RetStateEnevt += SShTools_RetStateEnevt;
            if (0 == ExecType)
            {
                if (null != MyCommand)
                {
                    foreach (UploadFile tmp in MyCommand.UploadFileList)
                    {
                        SFtptools.SftpUpload(IP, UserName, Pwd, string.Format(@"Command\{0}", tmp.FilePath), string.Format(@"/mnt/{0}", tmp.FilePath));
                    }
                    SShTools.ExecCommand(IP, UserName, Pwd, string.Format(@"chmod +x /mnt/ -R ", MyCommand.ExecFileName));
                    SShTools.ExecCommand(IP, UserName, Pwd, string.Format(@"/mnt/{0}", MyCommand.ExecFileName));
                }
            }
            else
            {
                SShTools.ExecCommand(IP, UserName, Pwd, CommandString);
            }
        }
        bool ret = true;
        void SShTools_RetStateEnevt(bool retState)
        {
            ret = retState;
        }
        string Msg = "";
        void SShTools_RetMessageEvent(string Message)
        {
            Msg += Message +"\r\n";
        }
        int BrPress = 0;
        void RetPress(int Press )
        {
            BrPress = Press;
        }
        private void ExecCommadFrm_Load(object sender, EventArgs e)
        {
            Text = "Lane  " + IP + " " + LabTitle.Text;
            FunRunCommand();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        void FunRunCommand()
        {
            Thread RunThread = new Thread(RunCommand);
            RunThread.Start();
            PbExec.Value = 0;
            LabMessage.Text = "Command Run Failure!";
            LabMessage.ForeColor = System.Drawing.Color.Cyan; ;
            ret = true;
            LabMessage.Text = "Please Wait ……";
            BtnRetry.Enabled = false;
        }
        private void TmResfh_Tick(object sender, EventArgs e)
        {
            TxtRet.Text = Msg;
            PbExec.Value = BrPress;
            if (100 == PbExec.Value)
            {
                LabMessage.Text = "Command Run Success!";
                LabMessage.ForeColor = System.Drawing.Color.Green;
                BtnRetry.Enabled = true;
            }
            if (!ret)
            {
                BrPress = 100;
                LabMessage.Text = "Command Run Failure!";
                LabMessage.ForeColor = System.Drawing.Color.Red;
                BtnRetry.Enabled = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            FunRunCommand();
        }
    }
}
