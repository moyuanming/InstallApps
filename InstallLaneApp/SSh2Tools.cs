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

        public static void SSHRSMC(string hostname,string UserName,string  Pwd,string Command ,TextBox SSHMessage)
        {
            Chilkat.Ssh ssh = new Chilkat.Ssh();

            //  Any string automatically begins a fully-functional 30-day trial.
            bool success;
            success = ssh.UnlockComponent("30-day trial");
            if (success != true)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }

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
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }
            //  Wait a max of 10 seconds when reading responses..
            ssh.IdleTimeoutMs = 10000;
            //  Authenticate using login/password:
            success = ssh.AuthenticatePw(UserName, Pwd);
            if (success != true)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }
            //  Open a session channel.  (It is possible to have multiple
            //  session channels open simultaneously.)
            int channelNum;
            channelNum = ssh.OpenSessionChannel();
            if (channelNum < 0)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
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
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }

            //  Start a shell on the channel:
            success = ssh.SendReqShell(channelNum);
            if (success != true)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }
            //   Run the 1st command in the remote shell, which will be to
            //   "cd" to a subdirectory.
            success = ssh.ChannelSendString(channelNum, string.Format("{0} \r\n",Command), "ansi");
            if (success != true)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }
            //  Retrieve the output.
            success = ssh.ChannelReceiveUntilMatch(channelNum, myPrompt, "ansi", true);
            if (success != true)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }
            //   Display what we've received so far.  This clears
            //   the internal receive buffer, which is important.
            //   After we send the command, we'll be reading until
            //   the next command prompt.  If the command prompt
            //   is already in the internal receive buffer, it'll think it's
            //   already finished...
            cmdOutput = ssh.GetReceivedText(channelNum, "ansi");
            if (cmdOutput == null)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }

            SSHMessage.Text += cmdOutput.Replace("[0m", "") +"\r\n";

            
           
            //  Send an EOF.  This tells the server that no more data will
            //  be sent on this channel.  The channel remains open, and
            //  the SSH client may still receive output on this channel.
            success = ssh.ChannelSendEof(channelNum);
            if (success != true)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }
            //  Read whatever output may already be available on the
            //  SSH connection.  ChannelReadAndPoll returns the number of bytes
            //  that are available in the channel's internal buffer that
            //  are ready to be "picked up" by calling GetReceivedText
            //  or GetReceivedData.
            //  A return value of -1 indicates failure.
            //  A return value of -2 indicates a failure via timeout.

            //  The ChannelReadAndPoll method waits
            //  for data to arrive on the connection usingi the IdleTimeoutMs
            //  property setting.  Once the first data arrives, it continues
            //  reading but instead uses the pollTimeoutMs passed in the 2nd argument:
            //  A return value of -2 indicates a timeout where no data is received.
            int n;
            int pollTimeoutMs;
            pollTimeoutMs = 2000;
            n = ssh.ChannelReadAndPoll(channelNum, pollTimeoutMs);
            if (n < 0)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }
            //  Close the channel:
            success = ssh.ChannelSendClose(channelNum);
            if (success != true)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }
            //  Perhaps we did not receive all of the commands output.
            //  To make sure,  call ChannelReceiveToClose to accumulate any remaining
            //  output until the server's corresponding "channel close" is received.
            success = ssh.ChannelReceiveToClose(channelNum);
            if (success != true)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }

            cmdOutput = ssh.GetReceivedText(channelNum, "ansi").Replace("[0m", "");
            if (cmdOutput == null)
            {
                SSHMessage.Text += ssh.LastErrorText + "\r\n";
                return;
            }
            SSHMessage.Text += cmdOutput + "\r\n";
            //  Disconnect
            ssh.Disconnect();
        }

    }
}
