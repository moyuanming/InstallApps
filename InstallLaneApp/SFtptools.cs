using System;
using System.Collections;
using Tamir.SharpSsh;
namespace InstallLaneApp
{
    public class SFtptools
    {
        public static string   SftpUpload( string hostname, string UserName ,string Pwd ,string localFilePath,string remoteFilePath)
        {





            try
            {

               
                SshTransferProtocolBase sshCp;
                sshCp = new Sftp(hostname, UserName);
                sshCp.Password = Pwd;               
                       
                sshCp.Connect();
                sshCp.Put(localFilePath, remoteFilePath);             
                sshCp.Close();
           
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "Success.";
        }
    

      

        
    }
}
