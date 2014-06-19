using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallLaneApp
{
    public partial class LanCommandConfigFrm : Form
    {
        public LanCommandConfigFrm()
        {
            InitializeComponent();
        }
        LanToolsConfig Ltc;  
        private void LanCommandConfigFrm_Load(object sender, EventArgs e)
        {
            try
            {
                Ltc = LanToolsConfig.LoadFile("Command.xml");
            }
            catch (System.Exception ex)
            {
                Ltc = new LanToolsConfig();

            }
            PgApps.SelectedObject = Ltc;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            LanToolsConfig.SaveFile(Ltc, "Command.xml");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
