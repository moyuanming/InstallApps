using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chilkat;
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
        public  void SSHRSMC(string hostname,string UserName,string  Pwd,string Command)
        {
            try
            {
                RetPressEvent(10);
                RetMessageEvent("New Ssh Exec ");
                SshExec exec = new SshExec(hostname, UserName);
                RetPressEvent(30);
                exec.Password = Pwd;
                RetMessageEvent("SSh  Connect");
                exec.Connect();
                RetPressEvent(50);
                RetMessageEvent("Run Command " + Command);
                string output = exec.RunCommand(Command);
                RetPressEvent(80);
                RetMessageEvent("Get Output Txt");
                RetMessageEvent(output.Replace("\n", "\r\n"));
                exec.Close();
                RetMessageEvent("Exec Success !");
                RetPressEvent(100);
            }
            catch (System.Exception ex)
            {
                RetMessageEvent(ex.Message);
                RetStateEnevt(false);
            }
         
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
