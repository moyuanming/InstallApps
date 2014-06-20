using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

using System.IO;
using System.Reflection;

using System.Threading.Tasks;

namespace InstallLaneApp
{
    [Serializable]
    public class UploadFile
    {
        string _FilePath;
        public string FilePath
        {
            get { return _FilePath; }
            set { _FilePath = value; }
        }
    }
    [Serializable]
    public class ExecCommands
    {
        string _commandName = "";
        public string CommandName
        {
            get { return _commandName; }
            set { _commandName = value; }
        }
        string _Command;
        public string Command
        {
            get { return _Command; }
            set { _Command = value; }
        }
       
    }
    [Serializable]
 public   class LaneCommand
    {
        string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        string _ExecFileName;
        public string ExecFileName
        {
            get { return _ExecFileName; }
            set { _ExecFileName = value; }
        }
        
        string _CommandLeve;
        public string CommandLeve
        {
            get { return _CommandLeve; }
            set { _CommandLeve = value; }
        }
        List<UploadFile> _UploadFileList = new List<UploadFile>();
        public List<UploadFile> UploadFileList
	    {
		    get { return _UploadFileList; }
		    set { _UploadFileList = value; }
	    }
    }
}
