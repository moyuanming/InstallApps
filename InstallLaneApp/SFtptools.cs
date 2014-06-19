using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace InstallLaneApp
{
    public class SFtptools
    {
        public static string   SftpUpload( string hostname, string UserName ,string Pwd ,string localFilePath,string remoteFilePath)
        {
            //  Important: It is helpful to send the contents of the
            //  sftp.LastErrorText property when requesting support.

            Chilkat.SFtp sftp = new Chilkat.SFtp();

            //  Any string automatically begins a fully-functional 30-day trial.
            bool success;
            success = sftp.UnlockComponent("Anything for 30-day trial");
            if (success != true)
            {

                return sftp.LastErrorText;
            }

            //  Set some timeouts, in milliseconds:
            sftp.ConnectTimeoutMs = 15000;
            sftp.IdleTimeoutMs = 15000;

            //  Connect to the SSH server.
            //  The standard SSH port = 22
            //  The hostname may be a hostname or IP address.
            int port;
            
        
            port = 22;
            success = sftp.Connect(hostname, port);
            if (success != true)
            {
               
                return sftp.LastErrorText;
            }

            //  Authenticate with the SSH server.  Chilkat SFTP supports
            //  both password-based authenication as well as public-key
            //  authentication.  This example uses password authenication.
            success = sftp.AuthenticatePw(UserName, Pwd);
            if (success != true)
            {
                return sftp.LastErrorText;
            }

            //  After authenticating, the SFTP subsystem must be initialized:
            success = sftp.InitializeSftp();
            if (success != true)
            {
                return sftp.LastErrorText;
            }

            //  Upload from the local file to the SSH server.
            //  Important -- the remote filepath is the 1st argument,
            //  the local filepath is the 2nd argument;
           
       

            success = sftp.UploadFileByName(remoteFilePath, localFilePath);
            if (success != true)
            {
                return sftp.LastErrorText;
            }

            return "Success.";
        }
    }
}
