using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
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
