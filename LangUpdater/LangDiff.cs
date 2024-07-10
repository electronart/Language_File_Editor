using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangUpdater
{
    public partial class LangDiff : Form
    {
        public LangDiff()
        {
            InitializeComponent();
        }

        public LangDiff(List<string> newStrings, List<string> removedStrings)
        {
            InitializeComponent();

            listBoxNewStrings.BeginUpdate();
            foreach(var item in newStrings)
            {
                listBoxNewStrings.Items.Add(item);
            }
            listBoxNewStrings.EndUpdate();

            listBoxRemovedStrings.BeginUpdate();
            foreach(var item in removedStrings)
            {
                listBoxRemovedStrings.Items.Add(item);
            }
            listBoxRemovedStrings.EndUpdate();

            labelNumNewStrings.Text = newStrings.Count.ToString();
            labelNumRemovedStrings.Text = removedStrings.Count.ToString();
        }
    }
}
