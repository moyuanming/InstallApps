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
        private void BtnInstall_Click(object sender, EventArgs e)
        {


            App InstallApps = GetApp(CbxApp.Text);

            string svncmdHead = string.Format(@"{1}\Subversion\bin\svn co --username mym --password future  --non-interactive svn://{0}/LaneSoft/", TxtIP.Text,  System.Environment.CurrentDirectory );
            TxtResult.Text += string.Format("svn co {0}  …… ",InstallApps.AppName);
            string svncmd = string.Format(@"{0}{2}/ {1}", svncmdHead, TxtInstallPath.Text, InstallApps.SvnPath);
            TxtResult.Text = Execute(svncmd) ;
            string svncmdConfig = string.Format(@"{0}{1}{2}/CONFIG {3}\CONFIG", svncmdHead, TxtNet.Text, CbxPlaza.Text, TxtInstallPath.Text);
            TxtResult.Text += Execute(svncmdConfig) + TxtResult.Text;
            svncmdConfig = string.Format(@"{0}/ICO {1}\ICO", svncmdHead, TxtInstallPath.Text);
            TxtResult.Text += Execute(svncmdConfig) + TxtResult.Text;

            CreateShortcut(string.Format(@"{0}\BIN\{1}", TxtInstallPath.Text, InstallApps.ExecName), InstallApps.AppName, TxtInstallPath.Text + @"\BIN", TxtInstallPath.Text + @"\ICO\" + InstallApps.ICOName);
       


            
           
          

           

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
            string svnUpdateCmd = string.Format(@"{1}\Subversion\bin\svn up --username mym --password future  --non-interactive {0}", TxtInstallPath.Text, System.Environment.CurrentDirectory);

           
            TxtResult.Text += Execute(svnUpdateCmd) ;
            svnUpdateCmd = string.Format(@"{1}\Subversion\bin\svn up --username mym --password future  --non-interactive {0}\CONFIG", TxtInstallPath.Text, System.Environment.CurrentDirectory);
        
            TxtResult.Text += Execute(svnUpdateCmd) ;
        }
        InstallItem InsApp;
        private void InstallFrom_Load(object sender, EventArgs e)
        {
            try
            {
                InsApp = InstallItem.LoadFile("Apps.xml");

                foreach (App tmp in InsApp.AppList )
                {
                    CbxApp.Items.Add(tmp.AppName);
                }
                CbxApp.SelectedIndex = 0;

               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("没有可以安装的程序！！检查Apps.xml是否存在");

            }
        }
        private void BtnClearMsg_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigInstallApp Frm = new ConfigInstallApp();
            Frm.ShowDialog();
        }
    }
}
