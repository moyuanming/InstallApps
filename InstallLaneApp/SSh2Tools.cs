using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chilkat;
using System.Windows.Forms;
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
            Chilkat.Ssh ssh = new Chilkat.Ssh();

            //  Any string automatically begins a fully-functional 30-day trial.
            bool success;
            success = ssh.UnlockComponent("30-day trial");
            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }
            RetPressEvent(10);
            //  This is the prompt we'll be expecting to find in
            //  the output of the remote shell.
            string myPrompt;
            myPrompt = "#";
            string cmdOutput;
            //  Connect to an SSH server:
            int port;
            //  Hostname may be an IP address or hostname:     
            port = 22;
            success = ssh.Connect(hostname, port);

            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
              
                RetStateEnevt(false);
                return;
            }
            //  Wait a max of 10 seconds when reading responses..
            ssh.IdleTimeoutMs = 10000;
            //  Authenticate using login/password:
            success = ssh.AuthenticatePw(UserName, Pwd);
            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
              
                RetStateEnevt(false);
                return;
            }
            RetPressEvent(20);
            //  Open a session channel.  (It is possible to have multiple
            //  session channels open simultaneously.)
            int channelNum;
            channelNum = ssh.OpenSessionChannel();
            if (channelNum < 0)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }         
            string termType;
            termType = "dumb";
            int widthInChars;
            widthInChars = 120;
            int heightInChars;
            heightInChars = 40;
            //  Use 0 for pixWidth and pixHeight when the dimensions
            //  are set in number-of-chars.
            int pixWidth;
            pixWidth = 0;
            int pixHeight;
            pixHeight = 0;
            success = ssh.SendReqPty(channelNum, termType, widthInChars, heightInChars, pixWidth, pixHeight);
            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }
            RetPressEvent(30);
            //  Start a shell on the channel:
            success = ssh.SendReqShell(channelNum);
            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetPressEvent(100);
                return;
            }
            //   Run the 1st command in the remote shell, which will be to
            //   "cd" to a subdirectory.
            success = ssh.ChannelSendString(channelNum, string.Format("{0} \r\n",Command), "ansi");
            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }
            //  Retrieve the output.
            success = ssh.ChannelReceiveUntilMatch(channelNum, myPrompt, "ansi", true);
            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }
            RetPressEvent(40);
            cmdOutput = ssh.GetReceivedText(channelNum, "ansi");
            if (cmdOutput == null)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }
            RetMessageEvent( cmdOutput.Replace("[0m", "") +"\r\n");   
           
            //  Send an EOF.  This tells the server that no more data will
            //  be sent on this channel.  The channel remains open, and
            //  the SSH client may still receive output on this channel.
            success = ssh.ChannelSendEof(channelNum);
            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }
 
            int n;
            int pollTimeoutMs;
            pollTimeoutMs = 2000;
            n = ssh.ChannelReadAndPoll(channelNum, pollTimeoutMs);
            if (n < 0)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }
            RetPressEvent(80);
            //  Close the channel:
            success = ssh.ChannelSendClose(channelNum);
            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }
            //  Perhaps we did not receive all of the commands output.
            //  To make sure,  call ChannelReceiveToClose to accumulate any remaining
            //  output until the server's corresponding "channel close" is received.
            success = ssh.ChannelReceiveToClose(channelNum);
            if (success != true)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }

            cmdOutput = ssh.GetReceivedText(channelNum, "ansi").Replace("[0m", "");
            if (cmdOutput == null)
            {
                RetMessageEvent(ssh.LastErrorText + "\r\n");
                RetStateEnevt(false);
                return;
            }
            RetMessageEvent(cmdOutput + "\r\n");
            RetPressEvent(100);
            //  Disconnect
            ssh.Disconnect();
        }

    }
}
