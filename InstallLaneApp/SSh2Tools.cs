using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tamir.SharpSsh;
namespace InstallLaneApp
{
    class SSh2Tools
    {
        public delegate void RetMessage (string  Message);
        public delegate void RetPress(int Message);
        public delegate void RetState(bool ret);
        public event RetMessage RetMessageEvent;
        public event RetPress RetPressEvent;
        public event RetState  RetStateEnevt;

        string  ConvertBM(string inputstr)
        {
            Encoding utf8 = System.Text.Encoding.ASCII;
            Encoding gb2312 = Encoding.GetEncoding("ansi");//Encoding.Default ,936
            byte[] temp = utf8.GetBytes(inputstr);
            byte[] temp1 = Encoding.Convert(utf8, gb2312, temp);
            string result = gb2312.GetString(temp1);
            return result;
        }

        void ExecLog( string format, params object[] args)
        {
            string text =string.Format(format, args);
            Console.WriteLine(text);
            string path =  "log.txt";
            System.IO.File.AppendAllText(path, text + System.Environment.NewLine);
        }
        public  string  SSHRSMC(string hostname,string UserName,string  Pwd,string Command)
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
                    ExecLog(MsgEventstr);
                }
                else
                {
                    MsgEventstr = (string.Format("[{0}@{1}]#{2}{3}{4}", UserName, hostname, Command, Space.Substring(UserName.Length + UserName.Length + Command.Length + 4, Space.Length - (UserName.Length + UserName.Length + Command.Length + 4 + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Length)), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                     RetMessageEvent(MsgEventstr);
                    ExecLog(MsgEventstr);
                }
                string output = exec.RunCommand(Command);
                RetPressEvent(80);
                 if (output.Length <= 0)
                {
                   
                }
                else
                {

                    MsgEventstr = ("\r\n  " + (output.Replace("\n", "\r\n  ")));
                    RetMessageEvent(MsgEventstr);
                    ExecLog(MsgEventstr);
                    ret = output;
                }
                exec.Close();
                Command = "";
                MsgEventstr = (string.Format("[{0}@{1}]#{2}{3}{4}", UserName, hostname, Command, Space.Substring(UserName.Length + UserName.Length + Command.Length + 4, Space.Length - (UserName.Length + UserName.Length + Command.Length + 4 + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Length)), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                 RetMessageEvent(MsgEventstr);
                    ExecLog(MsgEventstr);
                RetPressEvent(100);
            }
            catch (System.Exception ex)
            {
                RetMessageEvent(ex.Message);
                RetStateEnevt(false);
            }
            return ret;
         
         }
        public string SSHRSMC(string hostname, string UserName, string Pwd, string[] Command)
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
        //public  void SSHRSMC(string hostname,string UserName,string  Pwd,string Command)
        //{
        //    Chilkat.Ssh ssh = new Chilkat.Ssh();

        //    //  Any string automatically begins a fully-functional 30-day trial.
        //    bool success;
        //    success = ssh.UnlockComponent("30277129240");
        //    if (success != true)
        //    {
        //        MessageBox.Show(ssh.LastErrorText);
        //        RetStateEnevt(false);
        //        return;
        //    }
        //    RetPressEvent(10);
        //    //  Connect to an SSH server:      
        //    int port = 22;
        //    success = ssh.Connect(hostname, port);
        //    if (success != true)
        //    {
        //        MessageBox.Show(ssh.LastErrorText);
        //        RetStateEnevt(false);
        //        return;
        //    }
        //    RetMessageEvent("Connect to " + hostname + "\r\n");
        //    //  Wait a max of 5 seconds when reading responses..
        //    ssh.IdleTimeoutMs = 0;
        //    //  Authenticate using login/password:
        //    success = ssh.AuthenticatePw(UserName, Pwd);
        //    if (success != true)
        //    {
        //        MessageBox.Show(ssh.LastErrorText);
        //        RetStateEnevt(false);
        //        return;
        //    }
        //    RetPressEvent(30);
        //    //  Open a session channel.  (It is possible to have multiple
        //    //  session channels open simultaneously.)
        //    int channelNum; 
        //    RetMessageEvent("Open Session Channel " + "\r\n");
        //    channelNum = ssh.OpenSessionChannel();
        //    if (channelNum < 0)
        //    {
        //        MessageBox.Show(ssh.LastErrorText);
        //        RetStateEnevt(false);
        //        return;
        //    }
        //    RetPressEvent(50);
        //    //  Request a directory listing on the remote server:
        //    //  If your server is Windows, change the string from "ls" to "dir"
        //    RetMessageEvent("SendReqExec: " + Command + "\r\n");
        //    success = ssh.SendReqExec(channelNum, Command);
        //    if (success != true)
        //    {
        //        MessageBox.Show(ssh.LastErrorText);
        //        RetStateEnevt(false);
        //        return;
        //    }
        //    RetPressEvent(60);
        //    //  Call ChannelReceiveToClose to read
        //    //  output until the server's corresponding "channel close" is received.
        //    success = ssh.ChannelReceiveToClose(channelNum);
        //    if (success != true)
        //    {
        //        MessageBox.Show(ssh.LastErrorText);
        //        RetStateEnevt(false);
        //        return;
        //    }
        //    RetPressEvent(70);
        //    //  Let's pickup the accumulated output of the command:
        //    string cmdOutput;
        //    RetMessageEvent("Get Received Text:" + "\r\n");
        //    cmdOutput = ssh.GetReceivedText(channelNum, "ansi");
        //    if (cmdOutput == null)
        //    {
        //        RetMessageEvent("Exec Command Not Ret Message !");
        //        RetStateEnevt(false);
        //        return;
        //    }
        //    else
        //    {
        //        RetMessageEvent( cmdOutput + "\r\n");
        //    }
        //    RetPressEvent(80);
        //    //  Display the remote shell's command output:
        //    //  Disconnect
        //    RetMessageEvent("Command Exec Success Disconnect" + "\r\n");
        //    ssh.Disconnect();
        //    RetMessageEvent("End Disconnect " + "\r\n");
        //    RetPressEvent(100);
        //}

    }
}
