using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using Routrek.Crypto;
using Routrek.SSHC;
using Routrek.SSHCV1;
using Routrek.SSHCV2;
using Routrek.Toolkit;
using Routrek.PKI;
namespace InstallLaneApp
{
    public partial class InstalllanAppFrom : Form,ISSHConnectionEventReceiver, ISSHChannelEventReceiver
    {
        public InstalllanAppFrom()
        {
            InitializeComponent();
        }
        private static SSHConnection _conn;
        string ret = "";
        public void OnData(byte[] data, int offset, int length)
        {
            ret = Encoding.ASCII.GetString(data, offset, length);
        }
        public void OnDebugMessage(bool always_display, byte[] data)
        {
            Debug.WriteLine("DEBUG: " + Encoding.ASCII.GetString(data));
        }
        public void OnIgnoreMessage(byte[] data)
        {
            Debug.WriteLine("Ignore: " + Encoding.ASCII.GetString(data));
        }
        public void OnAuthenticationPrompt(string[] msg)
        {
            Debug.WriteLine("Auth Prompt " + msg[0]);
        }

        public void OnError(Exception error, string msg)
        {
            Debug.WriteLine("ERROR: " + msg);
        }
        public void OnChannelClosed()
        {
            Debug.WriteLine("Channel closed");
            _conn.Disconnect("");
            //_conn.AsyncReceive(this);
        }
        public void OnChannelEOF()
        {
            _pf.Close();
            Debug.WriteLine("Channel EOF");
        }
        public void OnExtendedData(int type, byte[] data)
        {
            Debug.WriteLine("EXTENDED DATA");
        }
        public void OnConnectionClosed()
        {
            Debug.WriteLine("Connection closed");
        }
        public void OnUnknownMessage(byte type, byte[] data)
        {
            Debug.WriteLine("Unknown Message " + type);
        }
        public void OnChannelReady()
        {
            
        }
        public void OnChannelError(Exception error, string msg)
        {
            Debug.WriteLine("Channel ERROR: " + msg);
        }
        public void OnMiscPacket(byte type, byte[] data, int offset, int length)
        {
        }
        public SSHChannel _pf;
        public PortForwardingCheckResult CheckPortForwardingRequest(string host, int port, string originator_host, int originator_port)
        {
            PortForwardingCheckResult r = new PortForwardingCheckResult();
            r.allowed = true;
            r.channel = this;
            return r;
        }
        public void EstablishPortforwarding(ISSHChannelEventReceiver rec, SSHChannel channel)
        {
            _pf = channel;
        }

      
        private void BtnExec_Click(object sender, EventArgs e)
        {
            SSHConnectionParameter f = new SSHConnectionParameter();
            f.UserName = "root";
            f.Password = "kissme";
            f.Protocol = SSHProtocol.SSH2;
            f.AuthenticationType = AuthenticationType.Password;
            f.WindowSize = 0x1000;
            Reader reader = new Reader();
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(new IPEndPoint(IPAddress.Parse("10.3.55.51"), 22));
            _conn = SSHConnection.Connect(f, this, s);
            SSHChannel ch = _conn.OpenShell(this);
            _pf = ch;
            SSHConnectionInfo ci = _conn.ConnectionInfo;
            Thread.Sleep(1000);
          
            string cmd = ">mym \n";
            byte[] data = (new UnicodeEncoding()).GetBytes(cmd);
            _pf.Transmit(data);
            _conn.Close();
        }
    }
}
