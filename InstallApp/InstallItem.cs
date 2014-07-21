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
namespace InstallApp
{

     public class XMLRW<T>
    {
        public static T Clone(T param)
        {
            Type typeparam = typeof(T);
            Type defaultGeneratorType =
                typeof(XMLRW<>).MakeGenericType(typeparam);
            var bytes = (byte[])defaultGeneratorType.InvokeMember(
                "Write",
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.InvokeMethod,
                null, null, new object[] { param });
            var result = (T)defaultGeneratorType.InvokeMember(
                "Read",
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.InvokeMethod,
                null, null, new object[] { bytes });
            return result;
        }

        /// <summary>
        /// 从xml中反序列化一个对象
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T Read(byte[] xml)
        {
            T ke = default(T);
            var xs = new XmlSerializer(typeof(T));
            if (xml != null)
            {
                XmlReader xr = XmlReader.Create(new MemoryStream(xml));
                if (xs.CanDeserialize(xr))
                {
                    ke = (T)xs.Deserialize(xr);
                }
            }
            return ke;
        }

        /// <summary>
        /// 将一个对象序列化为二进制xml 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static byte[] Write(T t)
        {
            var xs = new XmlSerializer(typeof(T));
            var ms = new MemoryStream();
            xs.Serialize(ms, t);
            return ms.ToArray();
        }

        /// <summary>
        /// 将对象序列化后写入到XML
        /// </summary>
        /// <param name="t">对象</param>
        /// <param name="fileName">将xml 文件存放的路径包含文件名</param>
        /// <returns>成功true 失败false</returns>
        public static bool WriteToXml(T t,string fileName)
        {
            try
            {
                byte[] bt = Write(t);
                string strXml = System.Text.Encoding.UTF8.GetString(bt);
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.LoadXml(strXml);
                doc.Save(fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 将xml 读取到对象中
        /// </summary>
        /// <param name="fileName">xml 文件路径包含文件名</param>
        /// <returns>对象 读取失败返回Null</returns>
        public static T ReadFromXml(string fileName)
        {
            if (File.Exists(fileName))
            {
                byte[] data = System.IO.File.ReadAllBytes(fileName);
                return Read(data);
            }
            else
            {
                return default(T);
            }
        }
    }
   public   enum CommandType:int { All,Frist,Last };

    
     public class ExecCommands
     {


         CommandType _Ctype = CommandType.All;
         public InstallApp.CommandType Ctype
         {
             get { return _Ctype; }
             set { _Ctype = value; }
         }

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
     public class App
     {
         string _AppName;
         public string AppName
         {
             get { return _AppName; }
             set { _AppName = value; }
         }
         string _ICOName;
         public string ICOName
         {
             get { return _ICOName; }
             set { _ICOName = value; }
         }
         string _ExecName;
         public string ExecName
         {
             get { return _ExecName; }
             set { _ExecName = value; }
         }
         string _ShortcutName;
         public string ShortcutName
         {
             get { return _ShortcutName; }
             set { _ShortcutName = value; }
         }
         string _Svn = "@svn {0} --username @username --password @password  --non-interactive";

         public string Svn
         {
             get { return _Svn; }
             set { _Svn = value; }
         }
         string _SvnPathHead = "svn://@Server/LaneSoft/";
         public string SvnPathHead
         {
             get { return _SvnPathHead; }
             set { _SvnPathHead = value; }
         }
         List<AppPathList> _AppPathLists = new List<AppPathList>();
         public List<AppPathList> AppPathLists
         {
             get { return _AppPathLists; }
             set { _AppPathLists = value; }
         }

         List<ExecCommands> _PCommands = new List<ExecCommands>();
         public List<ExecCommands> PCommands
         {
             get { return _PCommands; }
             set { _PCommands = value; }
         }
         List<ExecCommands> _NCommands = new List<ExecCommands>();
         public List<ExecCommands> NCommands
         {
             get { return _NCommands; }
             set { _NCommands = value; }
         }
        public string[] GetInstallSvnCommands()
         {
             string Svnco = string.Format(Svn,"co");
             string[] InstallSvnCommands = new string[AppPathLists.Count];
             for (int i = 0; i < AppPathLists.Count; i++)
             {
                 InstallSvnCommands[i] = string.Format(@"{0} {3}{1} @InstallPath\{2}", Svnco, AppPathLists[i].Source, AppPathLists[i].Dest, SvnPathHead);
             }
             return InstallSvnCommands;
         }
         public string[] GetUpdateSvnCommands()
         {
             string Svnco = string.Format(Svn, "up");
             string[] UpdateSvnCommands = new string[AppPathLists.Count];
             for (int i = 0; i < AppPathLists.Count; i++)
             {
                 UpdateSvnCommands[i] = string.Format(@"{0}  @InstallPath\{1}", Svnco,  AppPathLists[i].Dest);
             }
             return UpdateSvnCommands;
         }
         public string[] GetLastCommands()
         {

             string[] cmd = new string[NCommands.Count];
             for (int i = 0; i < NCommands.Count; i++)
             {
                 cmd[i] = NCommands[i].Command;
             }
             return cmd;
         }
         public string[] GetFristCommands()
         {

             string[] cmd = new string[PCommands.Count];
             for (int i = 0; i < PCommands.Count; i++)
             {
                 cmd[i] = PCommands[i].Command;
             }
             return cmd;
         }
    }

     public class AppPathList
     {
         string _Source;
         public string Source
         {
             get { return _Source; }
             set { _Source = value; }
         }
         string _Dest;
         public string Dest
         {
             get { return _Dest; }
             set { _Dest = value; }
         }
     }
  
   
    [Serializable]
    public class InstallItem
    {


        public static InstallItem LoadFile(string FileName)
        {
            return XMLRW<InstallItem>.Read(

                System.IO.File.ReadAllBytes(FileName)

                ) as InstallItem;

         
            
        }
        public static void SaveFile(InstallItem As, string FileName)
        {
            System.IO.File.WriteAllBytes(FileName, XMLRW<InstallItem>.Write(As));
        }
        string _SvnUserName;
        public string SvnUserName
        {
            get { return _SvnUserName; }
            set { _SvnUserName = value; }
        }
        string _SvnPwd;
        public string SvnPwd
        {
            get { return _SvnPwd; }
            set { _SvnPwd = value; }
        }
        List<App> _AppList = new List<App>();
        public List<App> AppList
        {
            get { return _AppList; }
            set { _AppList = value; }
        }
        List<ExecCommands> _Commands = new List<ExecCommands>();
        public List<ExecCommands> Commands
        {
            get { return _Commands; }
            set { _Commands = value; }
        }
    }

}
