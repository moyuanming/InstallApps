using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            set { _MyCommand = value; }
        }

        private void ExecCommadFrm_Load(object sender, EventArgs e)
        {
            if (null != MyCommand)
            {
                foreach (UploadFile tmp in MyCommand.UploadFileList)
                {
                    SFtptools.SftpUpload(IP,UserName,Pwd,string.Format(@"Command\{0}", tmp.FilePath), string.Format(@"/mnt/{0}", tmp.FilePath));
                }
                SSh2Tools.SSHRSMC(IP, UserName, Pwd, string.Format(@"chmod +x /mnt/ -R ", MyCommand.ExecFileName), TxtRet);
                SSh2Tools.SSHRSMC(IP, UserName, Pwd, string.Format(@"/mnt/{0}", MyCommand.ExecFileName),TxtRet);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
