using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tamir.SharpSsh;
using System.Data;
namespace InstallLaneApp
{
    class SSh2Tools :ECToolsInterface
    {

        public event RetMessage RetMessageEvent;
        public event RetPress RetPressEvent;
        public event RetState RetStateEnevt;
        DataTable mux = new DataTable();
     

        void ExecLog( string namehost,string format, params object[] args)
        {
            lock (mux)
            {
                string text = string.Format(format, args);
                Console.WriteLine(text);
                string path = string.Format(@"LOG\log{0}.txt", namehost);
                System.IO.File.AppendAllText(path, text + System.Environment.NewLine);
            }
        }
        public  string  ExecCommand(string hostname,string UserName,string  Pwd,string Command)
        {
            string ret = "";
            try
            {
                RetPressEvent(10);              
                SshExec exec = new SshExec(hostname, UserName);
                RetPressEvent(30);
                exec.Password = Pwd;                
                exec.Connect();
                RetPressEvent(50);
                string Space = "                                                                                       ";
                string MsgEventstr = "";
                if (Command.Length > 50)
                {
                    MsgEventstr = string.Format("[{0}@{1}]#{2}", UserName, hostname, Command);
                    RetMessageEvent(MsgEventstr);
                    ExecLog(hostname,MsgEventstr);
                }
                else
                {
                    MsgEventstr = (string.Format("[{0}@{1}]#{2}{3}{4}", UserName, hostname, Command, Space.Substring(UserName.Length + UserName.Length + Command.Length + 4, Space.Length - (UserName.Length + UserName.Length + Command.Length + 4 + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Length)), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                     RetMessageEvent(MsgEventstr);
                    ExecLog(hostname,MsgEventstr);
                }
                string StdErr = "";
                string output = "";
               int exitStatus =   exec.RunCommand(Command,ref output,ref StdErr);
                RetPressEvent(80);

                MsgEventstr = ("\r\n  " + (StdErr.Replace("\n", "\r\n  ")));
                RetMessageEvent(MsgEventstr);
                ExecLog(hostname, MsgEventstr);

                ret = output;


                MsgEventstr = ("\r\n  " + (output.Replace("\n", "\r\n  ")));
                RetMessageEvent(MsgEventstr);
                ExecLog(hostname, MsgEventstr);
                ret = output;
               
                exec.Close();
                Command = "";
                MsgEventstr = (string.Format("[{0}@{1}]#{2}{3}{4}", UserName, hostname, Command, Space.Substring(UserName.Length + UserName.Length + Command.Length + 4, Space.Length - (UserName.Length + UserName.Length + Command.Length + 4 + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Length)), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                 RetMessageEvent(MsgEventstr);
                    ExecLog(hostname,MsgEventstr);
                RetPressEvent(100);
            }
            catch (System.Exception ex)
            {
                RetMessageEvent(ex.Message);
                RetStateEnevt(false);
            }
            return ret;
         
         }
        public string ExecCommand(string hostname, string UserName, string Pwd, string[] Command)
        {
            string ret = "";
            try
            {
                RetPressEvent(5);            
                SshExec exec = new SshExec(hostname, UserName);               
                exec.Password = Pwd;              
                exec.Connect();
                RetPressEvent(10);             
                string output  ;
                double start = 10;
                double fit =  88.0 / Command.Length;
                for(int i=0 ;i<Command.Length ;i++)
                {
                    output = exec.RunCommand(Command[i]);                   
                    start +=fit;
                    RetPressEvent(Convert.ToInt16(start));
                    RetMessageEvent("");
                }                
                RetPressEvent(98);               
                exec.Close();                
                RetPressEvent(100);
            }
            catch (System.Exception ex)
            {
              
                RetStateEnevt(false);
                MessageBox.Show(ex.Message);
            }
            return ret;

        }
        

    }
}
