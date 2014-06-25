using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telnet;
using System.Threading;
namespace InstallLaneApp
{
    class TelentTools:ECToolsInterface
    {
        public event RetMessage RetMessageEvent;
        public event RetPress RetPressEvent;
        public event RetState RetStateEnevt;
        public string ExecCommand(string hostname, string UserName, string Pwd, string Command)
        {
            RetPressEvent(10);
            Terminal Server = new Terminal(hostname);
            string retstr;
            if (Server.Connect() == false)
            {
                Console.WriteLine("连接失败");
                return "连接失败";
            }
            retstr = Server.WaitForString("login:");
            RetPressEvent(20);
            Server.SendResponse(UserName,true);
            Thread.Sleep(200);
            RetPressEvent(40);
            retstr = Server.WaitForString("password");
            Server.SendResponse(Pwd, true);
            RetPressEvent(50);
            Thread.Sleep(200);
            Server.WaitForString(">");
            Server.SendResponse(Command, true);
            RetPressEvent(80);
            Thread.Sleep(200);      
            Server.WaitForString(">");
            RetPressEvent(100);
            retstr = Server.VirtualScreen.Hardcopy();
            RetMessageEvent(retstr);
            Server.Close();
            return retstr; 
        }
        public string ExecCommand(string hostname, string UserName, string Pwd, string[] Command)
        {
            return "";
        }
    }
}
