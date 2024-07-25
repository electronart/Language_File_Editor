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
                richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center; 
            richTextBox1.Font = new Font("Courier New",14,FontStyle.Bold);
            richTextBox1.Text = "Language File Editor\r\n" +
                 "for eSearch .lang files\r\n\r\n" + "Version: " + version +  "\r\n" +
                 "See Online Help\r\nfor License & Support.\r\n\r\n" +
                 "© 2024 ElectronArt Design Ltd.";

            }
            
         
        }

    }
}
