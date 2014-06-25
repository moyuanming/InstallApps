using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using IWshRuntimeLibrary;//先添加Windows Script Host Object Model的引用 Com里
using System.Threading;
namespace InstallApp
{
   
    public partial class InstallFrom : Form
    {




        public InstallFrom()
        {
            InitializeComponent();
        }
        public string Execute(string dosCommand)
        {
            return Execute(dosCommand, 1000);
        }
        /// <summary>  
        /// 执行DOS命令，返回DOS命令的输出  
        /// </summary>  
        /// <param name="dosCommand">dos命令</param>  
        /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），  
        /// 如果设定为0，则无限等待</param>  
        /// <returns>返回DOS命令的输出</returns>  
        public static string Execute(string command, int seconds)
        {
            string output = ""; //输出字符串  
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象  
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";//设定需要执行的命令  
                startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出  
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动  
                startInfo.RedirectStandardInput = false;//不重定向输入  
                startInfo.RedirectStandardOutput = true; //重定向输出  
                startInfo.CreateNoWindow = true;//不创建窗口  
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程  
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束  
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒  
                        }
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出  
                       
                    }
                }
                catch
                {
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output;
        }


        private void CreateShortcut(string AppPath, string Appname, string WorkingDirectory,string ICOFileName)
        {
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(
              Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) +
              "\\" + Appname +  ".lnk"
            );
            shortcut.TargetPath = AppPath;          
            shortcut.WindowStyle = 1;
            shortcut.WorkingDirectory = WorkingDirectory;
            shortcut.IconLocation = ICOFileName;
            shortcut.Save();
            //结果 C:\WINDOWS\system32\netstat.exe -ano 没有双引号
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        App GetApp(string AppName)
        {
            App InstallApps =null;
            foreach (App tmp in InsApp.AppList)
            {
                if (AppName == tmp.AppName)
                {
                    InstallApps = tmp;
                }
            }
            return InstallApps;
        }
        string TxtMssage = "";
        int BarPress = 0;
        App InstallApps;
        string SvnName = "";
        string SvnPwd = "";
        string Plaza = "";
        string NetWork = "";
        
        void Install()
        {
            TxtMssage = "";
            BarPress = 10;
           
            string svncmdHead = string.Format(@"{1}\Subversion\bin\svn co --username {2} --password {3}  --non-interactive svn://{0}/LaneSoft/", TxtIP.Text, System.Environment.CurrentDirectory, TxtSvnName.Text, TxtSvnPwd.Text);
            TxtMssage += string.Format("Install：{0} \r\n ", InstallApps.AppName);
            BarPress = 20;
            string svncmd = string.Format(@"{0}{2}/ {1}", svncmdHead, TxtInstallPath.Text, InstallApps.SvnPath);
            TxtMssage += string.Format(@"C:\>{0}", svncmd) +  "\r\n";
            TxtMssage += Execute(svncmd) + "\r\n";
            BarPress = 50;
            string svncmdConfig = string.Format(@"{0}{1}{2}/CONFIG {3}\CONFIG", svncmdHead, TxtNet.Text, Plaza, TxtInstallPath.Text);
            TxtMssage += string.Format(@"C:\>{0}", svncmdConfig) + "\r\n";
            BarPress = 60;
            TxtMssage += Execute(svncmdConfig);


            svncmdConfig = string.Format(@"{0}/RHYSOFTCONFIG {1}\CONFIGTMP", svncmdHead,  TxtInstallPath.Text);
            TxtMssage += string.Format(@"C:\>{0}", svncmdConfig) + "\r\n";
            BarPress = 70;
            TxtMssage += Execute(svncmdConfig);

            svncmdConfig = string.Format(@"xcopy {0}\CONFIGTMP\* {0}\CONFIG\  /Y", TxtInstallPath.Text, InstallApps.SvnPath);
            TxtMssage += string.Format(@"C:\>{0}", svncmdConfig) + "\r\n";
            TxtMssage += Execute(svncmdConfig);
            BarPress = 80;
            svncmdConfig = string.Format(@"{0}/ICO {1}\ICO", svncmdHead, TxtInstallPath.Text);
            TxtMssage += string.Format(@"C:\>{0}", svncmdConfig) + "\r\n";
            BarPress = 90;
            TxtMssage += Execute(svncmdConfig) + "\r\n"; ;
            CreateShortcut(string.Format(@"{0}\BIN\{1}", TxtInstallPath.Text, InstallApps.ExecName), InstallApps.ShortcutName, TxtInstallPath.Text + @"\BIN", TxtInstallPath.Text + @"\ICO\" + InstallApps.ICOName);
            BarPress = 100;
        }
        void UpdateApp()
        {
            TxtMssage = "";
            BarPress = 10;

            TxtMssage += string.Format("Update Pro \r\n ");
            
            string svnUpdateCmd = string.Format(@"{1}\Subversion\bin\svn up --username {2} --password {3}  --non-interactive {0}", TxtInstallPath.Text, System.Environment.CurrentDirectory,TxtSvnName.Text,TxtSvnPwd.Text);
            BarPress = 20;
            TxtMssage += string.Format(@"C:\>{0}", svnUpdateCmd) + "\r\n";
            BarPress = 30;
            TxtMssage += Execute(svnUpdateCmd);
            BarPress = 60;
            svnUpdateCmd = string.Format(@"{1}\Subversion\bin\svn up --username {2} --password {3}  --non-interactive {0}\CONFIG", TxtInstallPath.Text, System.Environment.CurrentDirectory,TxtSvnName.Text,TxtSvnPwd.Text);
            BarPress = 70;
            TxtMssage += string.Format(@"C:\>{0}", svnUpdateCmd) + "\r\n";
            TxtMssage += Execute(svnUpdateCmd);


            svnUpdateCmd = string.Format(@"{1}\Subversion\bin\svn up --username {2} --password {3}  --non-interactive {0}\CONFIGTMP", TxtInstallPath.Text, System.Environment.CurrentDirectory, TxtSvnName.Text, TxtSvnPwd.Text);
            BarPress = 80;
            TxtMssage += string.Format(@"C:\>{0}", svnUpdateCmd) + "\r\n";
            TxtMssage += Execute(svnUpdateCmd);

            svnUpdateCmd = string.Format(@"xcopy {0}\CONFIGTMP\* {0}\CONFIG\  /Y", TxtInstallPath.Text, InstallApps.SvnPath);
            TxtMssage += string.Format(@"C:\>{0}", svnUpdateCmd) + "\r\n";
            BarPress = 90;
            TxtMssage += Execute(svnUpdateCmd);

            BarPress = 100;
        }
        private void BtnInstall_Click(object sender, EventArgs e)
        {
            InstallApps = GetApp(CbxApp.Text);
            Plaza = CbxPlaza.Text;
            Thread Tr = new Thread(Install);
            Tr.Start();

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Thread Tr = new Thread(UpdateApp);
            Tr.Start();
        }
        InstallItem InsApp;
        private void InstallFrom_Load(object sender, EventArgs e)
        {
            CbxRunCmd.Items.Clear();
            try
            {
                InsApp = InstallItem.LoadFile("Apps.xml");

                foreach (App tmp in InsApp.AppList )
                {
                    CbxApp.Items.Add(tmp.AppName);
                }
                CbxApp.SelectedIndex = 0;

                foreach (ExecCommands tmp in InsApp.Commands)
                {
                    CbxRunCmd.Items.Add(tmp.CommandName);

                }
                CbxRunCmd.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("没有可以安装的程序！！检查Apps.xml是否存在");

            }
        }
        private void BtnClearMsg_Click(object sender, EventArgs e)
        {
          TxtMssage = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigInstallApp Frm = new ConfigInstallApp();
            Frm.ShowDialog();
        }

        private void BtnSetTime_Click(object sender, EventArgs e)
        {
            SystemTime syst = new SystemTime();
            TimeZoneInformation newtzi = new TimeZoneInformation();
            syst.year = 0;
            syst.month = 0;
            syst.dayOfWeek = 0;
            syst.day = 0;
            syst.hour = 0;
            syst.minute = 0;
            syst.second = 0;


            newtzi.daylightDate = syst;
            newtzi.daylightName = "(UTC)协调世界时";
            newtzi.standardBias = 0;
            newtzi.standardDate = syst;
            newtzi.standardName = "协调世界时";
            TimeZoneControl.SetTimeZone(newtzi);
        }

        private void BtnSetTime8_Click(object sender, EventArgs e)
        {
            SystemTime syst = new SystemTime();
            TimeZoneInformation newtzi = new TimeZoneInformation();
            syst.year = 0;
            syst.month = 0;
            syst.dayOfWeek = 0;
            syst.day = 0;
            syst.hour = 0;
            syst.minute = 0;
            syst.second = 0;

            newtzi.bias = -480;
            newtzi.daylightDate = syst;
            newtzi.daylightName = "(UTC+08:00)北京，重庆，香港特别行政区，乌鲁木齐";
            newtzi.standardBias = 0;
            newtzi.standardDate = syst;
            newtzi.standardName = "中国标准时间";
            TimeZoneControl.SetTimeZone(newtzi);
        }

        private void TmResfh_Tick(object sender, EventArgs e)
        {
            TxtResult.Text = TxtMssage;
            PbExec.Value = BarPress;
        }

        private void BtnExeccmd_Click(object sender, EventArgs e)
        {
            TxtMssage += Execute(string.Format(@"{0}",TxtRunCommand.Text)) + "\r\n";
        }

        private void CbxRunCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtRunCommand.Text = InsApp.Commands[CbxRunCmd.SelectedIndex].Command;
        }

      
    }
}
