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
        public static bool WriteToXml(T t, string fileName)
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
     [Serializable]
    public  class LanToolsConfig
    {

         public static LanToolsConfig LoadFile(string FileName)
        {
            return XMLRW<LanToolsConfig>.Read(

                System.IO.File.ReadAllBytes(FileName)

                ) as LanToolsConfig;



        }
         public static void SaveFile(LanToolsConfig As, string FileName)
        {
            System.IO.File.WriteAllBytes(FileName, XMLRW<LanToolsConfig>.Write(As));
        }
        List<LaneCommand> _AppList = new List<LaneCommand>();

        public List<LaneCommand> CommandList
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
        int _EStartIP = 71;
        public int EStartIP
        {
            get { return _EStartIP; }
            set { _EStartIP = value; }
        }
        int _XstartIP =51;
        public int XstartIP
        {
            get { return _XstartIP; }
            set { _XstartIP = value; }
        }
        int _ECount =3;
        public int ECount
        {
            get { return _ECount; }
            set { _ECount = value; }
        }
        int _Xcount =4;
        public int Xcount
        {
            get { return _Xcount; }
            set { _Xcount = value; }
        }
    }
}
