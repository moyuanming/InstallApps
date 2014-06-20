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
namespace InstallLaneApp
{
    public partial class ReTranData : Form
    {
        public ReTranData()
        {
            InitializeComponent();
        }
        public string IP
        {
            get { return TxtIP.Text; }
            set { TxtIP.Text = value; }
        }
        public string UserName
        {
            get { return TxtUserName.Text; }
            set { TxtUserName.Text = value; }
        }
        public string Pwd
        {
            get { return TxtPwd.Text; }
            set { TxtPwd.Text = value; }
        }
   
        /// <summary>
        /// 将字符串分割成数组
        /// </summary>
        /// <param name="strSource"></param>
        /// <param name="strSplit"></param>
        /// <returns></returns>
        public string[] StringSplit(string strSource, string strSplit)
        {
            string[] strtmp = new string[1];
            int index = strSource.IndexOf(strSplit, 0);
            if (index < 0)
            {
                strtmp[0] = strSource;
                return strtmp;
            }
            else
            {
                strtmp[0] = strSource.Substring(0, index);
                return StringSplit(strSource.Substring(index + strSplit.Length), strSplit, strtmp);
            }
        }
        // <summary>
        /// 采用递归将字符串分割成数组
        /// </summary>
        /// <param name="strSource"></param>
        /// <param name="strSplit"></param>
        /// <param name="attachArray"></param>
        /// <returns></returns>
        private string[] StringSplit(string strSource, string strSplit, string[] attachArray)
        {
            string[] strtmp = new string[attachArray.Length + 1];
            attachArray.CopyTo(strtmp, 0);

            int index = strSource.IndexOf(strSplit, 0);
            if (index < 0)
            {
                strtmp[attachArray.Length] = strSource;
                return strtmp;
            }
            else
            {
                strtmp[attachArray.Length] = strSource.Substring(0, index);
                return StringSplit(strSource.Substring(index + strSplit.Length), strSplit, strtmp);
            }
        }
        void ssh_RetStateEnevt(bool ret)
        {
            //throw new NotImplementedException();
        }
        int BrPress = 0;
        void ssh_RetPressEvent(int Message)
        {
            BrPress = Message;
        }
        bool ReloadRun = false;
        int RemoveCount = 0;
        void ssh_RetMessageEvent(string Message)
        {
            if (ReloadRun)
            {
                lock (Dt)
                {
                    RemoveCount++;
                }
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ReTranData_Load(object sender, EventArgs e)
        {

        }
        DataTable mux = new DataTable();
        DataTable Dt;
        void FillData(string Cmd)
        {
            SSh2Tools ssh = new SSh2Tools();
            ssh.RetMessageEvent += ssh_RetMessageEvent;
            ssh.RetPressEvent +=ssh_RetPressEvent;
            ssh.RetStateEnevt +=ssh_RetStateEnevt;
            string DataStr = ssh.SSHRSMC(TxtIP.Text, TxtUserName.Text, TxtPwd.Text, Cmd);
            string[] DataArry = StringSplit(DataStr, "\n");
            lock (mux)
            {
                Dt = new DataTable();
                Dt.Columns.Add("ID");
                Dt.Columns.Add("消息类型");
                Dt.Columns.Add("车道号");
                Dt.Columns.Add("收费员");
                Dt.Columns.Add("时间");
                Dt.Columns.Add("标志");
                lock (Dt)
                {
                    foreach (string Tmp in DataArry)
                    {
                        Dt.Rows.Add(StringSplit(Tmp, "|"));
                    }
                }
            }

         
           
        }
        void Query()
        {
          
            string Sqlstr = "select ID ,substr(MessageBody,19,2),substr(MessageBody,62,3),substr(MessageBody,65,6),messageTime,Mark from Tb_message";
            string Where = string.Format(TxtWhere.Text,
               DptStartTime.Value.AddDays(-1).ToString("yyyy-MM-dd"), DptEndTime.Value.AddDays(+1).ToString("yyyy-MM-dd"), TxtMsgType.Text, TxtCollect.Text, TxtUpFlag.Text);
                
            string Ordreby = string.Format("order by ID desc limit {0}",TxtReCounts.Text);

            Sqlstr = string.Format("{0} {1} {2}; ", Sqlstr, Where, Ordreby);
            string Cmd = string.Format("echo \"{0}\" | sqlite3 {1} ", Sqlstr,TxtDB.Text);

            FillData(Cmd);
            
        }
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            PbExec.Value = 0;
            DgView.DataSource = null;
            Dt = null;
            ReloadRun = false;
            Thread Tr = new Thread(Query);
            Tr.Start();
        }
        void ReLoadDate()
        {
           
            string[] Commands = new string[Dt.Rows.Count];
            int index = 0;
            foreach (DataRow Dr in Dt.Rows)
            {
           
                Commands[index++] = string.Format("echo \"update Tb_message set mark = 0 where ID = {0};\" |  sqlite3 {1} ",Dr[0].ToString(),TxtDB.Text);
            }
            SSh2Tools ssh = new SSh2Tools();
            ssh.RetMessageEvent += ssh_RetMessageEvent;
            ssh.RetPressEvent += ssh_RetPressEvent;
            ssh.RetStateEnevt += ssh_RetStateEnevt;
      
            string DataStr = ssh.SSHRSMC(TxtIP.Text, TxtUserName.Text, TxtPwd.Text, Commands);
        
          
        }
        private void TmResfh_Tick(object sender, EventArgs e)
        {
            PbExec.Value = BrPress;
            if (PbExec.Value == 100 && DgView.DataSource == null)
            {
                lock (mux)
                {

                    DgView.DataSource = Dt;
                }
               
            }
            if (ReloadRun)
            {
                try
                {
                    lock (Dt)
                    {
                        if (Dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < RemoveCount; i++)
                            {
                                Dt.Rows.RemoveAt(0);
                            }
                            RemoveCount = 0;
                        }
                     
                    }
                    
                }
                catch (System.Exception ex)
                {
                	
                }
               
            }
        }

        private void BtnReUpLoad_Click(object sender, EventArgs e)
        {
            PbExec.Value = 0;
            ReloadRun = true;
            Thread Tr = new Thread(ReLoadDate);          
            Tr.Start();
           
        }
    }
}
