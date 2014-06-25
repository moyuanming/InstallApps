using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstallLaneApp
{
    public delegate void RetMessage(string Message);
    public delegate void RetPress(int Message);
    public delegate void RetState(bool ret);
    interface ECToolsInterface
    {
         event RetMessage RetMessageEvent;
         event RetPress RetPressEvent;
         event RetState RetStateEnevt;
         string ExecCommand(string hostname, string UserName, string Pwd, string Command);
         string ExecCommand(string hostname, string UserName, string Pwd, string[] Command);
    }
}
