using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.IO;
using System.Diagnostics;

namespace LangUpdater
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

         
            {
                //had to edit .csprj Project file to Deterministic false, to use wildcard in Assembly Version.
                var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(4);
                labelVersion.Text = $"Version: {version}";

            }
            
         
        }

        private void buttonLicenseAndNotices_Click(object sender, EventArgs e)
        {
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "docs");
            if (Directory.Exists(dir))
            {
                Process.Start("explorer.exe", dir);
            } else
            {
                MessageBox.Show("/docs folder is missing", "Error");
            }
        }
    }
}
