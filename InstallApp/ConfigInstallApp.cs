using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallApp
{
    public partial class ConfigInstallApp : Form
    {
        public ConfigInstallApp()
        {
            InitializeComponent();
        }
        InstallItem InsApp;
        private void ConfigInstallApp_Load(object sender, EventArgs e)
        {
          
            try
            {
                InsApp = InstallItem.LoadFile("Apps.xml");
            }
            catch (System.Exception ex)
            {
                InsApp = new InstallItem();
            	
            }
            PgApps.SelectedObject = InsApp;
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            InstallItem.SaveFile(InsApp, "Apps.xml");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
