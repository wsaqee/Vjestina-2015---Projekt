using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PrinterStats
{
    public partial class Options : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            cBoxRunInBackGround.Checked = AppSettings.Default.RunInBackGround;
            cBoxAutoStart.Checked = AppSettings.Default.AutoStart = (rkApp.GetValue("PrintStats") != null) ;
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppSettings.Default.RunInBackGround = cBoxRunInBackGround.Checked;
            AppSettings.Default.AutoStart = cBoxAutoStart.Checked;
            AppSettings.Default.Save();

            //if Equal return without changes..
            if ((rkApp.GetValue("PrintStats") != null) == AppSettings.Default.AutoStart) return;
            
            //else set regKey
            if (AppSettings.Default.AutoStart)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("PrintStats", Application.ExecutablePath.ToString());
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("PrintStats", false);
            }
        }
    }
}
