using PseudoLocalizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangUpdater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.AutoScroll = true;
            groupBoxLang.Enabled = false;
            compareToolStripMenuItem.Enabled = false;
           
        }

        int stringsToTranslate = 0;

        //private void buttonLoadFile_Click(object sender, EventArgs e)
        private void OpenFile()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Language Files|*.lang";
                ofd.Multiselect = false;
                ofd.Title = "Select Lang File to Update (*.lang)";
                var dialogResult = ofd.ShowDialog();
                if (dialogResult != DialogResult.OK) return;

                


                var file = ofd.FileName;
                var lang = Lang.LoadFromFile(file);
                groupBoxLang.Text = ofd.FileName;
                PopulateTableFromLang(lang);
                compareToolStripMenuItem.Enabled = true;
                //select first item to be translated
                GenerateCountOfNonTranslated(true);


            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tableLayoutPanel1.ResumeLayout(true);
            }
        }

        
        private void PopulateTableFromLang(Lang lang)
        {
            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.AutoScroll = true;

            int cell = tableLayoutPanel1.Controls.Count;
            tableLayoutPanel1.SuspendLayout();
            while (cell > 2)
            {
                // Remove everything but the first two cells.
                cell--;
                tableLayoutPanel1.Controls.RemoveAt(cell);
            }
            tableLayoutPanel1.ResumeLayout(true);
            int i = 0;

            tableLayoutPanel1.SuspendLayout();

            int row = 1;
            int totalStrings = 0;


            while (i < lang.LangItems.Count)
            {
                ++row;
                var item = lang.LangItems[i];
                if (item is string commentString)
                {
                    // Comment.

                    Panel backingPanel = new Panel();
                    backingPanel.Dock = DockStyle.Fill;
                    backingPanel.BackColor = Color.AliceBlue;

                    Label commentLabel = new Label();
                    commentLabel.Dock = DockStyle.Fill;
                    commentLabel.Text = commentString.Trim();
                    commentLabel.Margin = new Padding(8);
                    commentLabel.Width = 220;
                    backingPanel.Controls.Add(commentLabel);

                    tableLayoutPanel1.Controls.Add(backingPanel, 0, row);
                    tableLayoutPanel1.SetColumnSpan(backingPanel, 2);
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                }
                if (item is TranslationItem translationItem)
                {
                    ++totalStrings;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                    Label originalTextLabel = new Label();
                    originalTextLabel.Dock = DockStyle.Fill;
                    originalTextLabel.Text = translationItem.Original;
                    originalTextLabel.Margin = new Padding(8);
                    originalTextLabel.Width = 220;
                    tableLayoutPanel1.Controls.Add(originalTextLabel, 0, row);

                    TextBox translationTextBox = new TextBox();
                    //translationTextBox.Dock = DockStyle.Fill;
                    translationTextBox.Text = translationItem.Translation;
                    translationTextBox.Margin = new Padding(8);
                    translationTextBox.Width = 220;
                    translationTextBox.GotFocus += TranslationTextBox_GotFocus;
                    translationTextBox.LostFocus += TranslationTextBox_LostFocus;
                    translationTextBox.TextChanged += TranslationTextBox_TextChanged;
                    tableLayoutPanel1.Controls.Add(translationTextBox, 1, row);
                }

                ++i;
            }
            #region Fix vertical scroll bar
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            tableLayoutPanel1.Padding = new Padding(0, 0, vertScrollWidth, 0);
            #endregion

           //labelTotalStrings.Text = totalStrings.ToString() + " strings total.";   
            toolStripStatusLabel1.Text = "Total strings: " + totalStrings.ToString();
            stringsToTranslate = totalStrings;

            tableLayoutPanel1.RowCount = row;
            tableLayoutPanel1.ResumeLayout(true);
            tableLayoutPanel1.Refresh();

            groupBoxLang.Enabled = true;
            GenerateCountOfNonTranslated();

            
        }

        private void TranslationTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateCountOfNonTranslated();
        }

        private void TranslationTextBox_LostFocus(object sender, EventArgs e)
        {
            GenerateCountOfNonTranslated();
        }

        private void TranslationTextBox_GotFocus(object sender, EventArgs e)
        {
            GenerateCountOfNonTranslated();
        }

        private void GenerateCountOfNonTranslated(bool focusFirst = false)
        {
            int totalNotTranslated = 0;

            int totalControls = tableLayoutPanel1.Controls.Count;
            int i = 2; // Skip the headers.
            while (i < totalControls)
            {
                var control = tableLayoutPanel1.Controls[i];
                if (control is Panel panel)
                {
                    // Comment.
                }
                if (control is Label label)
                {
                    // Original string.
                    string original = label.Text;
                    string translation = tableLayoutPanel1.Controls[i + 1].Text;
                    //added 24 July 2024 Tom says needed for DBi template file
                    if (translation.Trim() == "TRANSLATE")
                    {
                        if (focusFirst) { tableLayoutPanel1.Controls[i + 1].Focus(); return; }
                        ++totalNotTranslated;
                    }
                    /*
                    if (original == translation)
                    {
                        if (focusFirst) { tableLayoutPanel1.Controls[i + 1].Focus(); return; }
                        ++totalNotTranslated;
                    }
                    */
                    if (translation.Trim() == "")
                    {
                        if (focusFirst) { tableLayoutPanel1.Controls[i + 1].Focus(); return; }
                        ++totalNotTranslated;
                        
                    }
                   // else if (translation == original.PseudoLocalize())
                   else if (translation.Trim().Contains('['))
                    {
                        if (focusFirst) { tableLayoutPanel1.Controls[i + 1].Focus(); return; }
                        ++totalNotTranslated;
                    }

                    ++i;
                }
                ++i;
            }
          
            //As at 16 July 2024 there are 207 rows to translate Including the RFC4646 row.
            //labelNumNotTranslated.Text = "Not Translated: " + totalNotTranslated;
            //prefer to also show % done
            toolStripStatusLabel2.Text = "Not Translated: " + totalNotTranslated;
            var percent = ((((double)stringsToTranslate - totalNotTranslated) /(double)stringsToTranslate)) *100;
            toolStripStatusLabel3.Text = "Translated: " + percent.ToString("F2") + " % " ;
        }

        //private void buttonUpdateFromTemplate_Click(object sender, EventArgs e)
        private void CompareWithTemplate()
        {
           /* OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Language Files|*.lang";
            ofd.Multiselect = false;
            ofd.Title = "Select Template Lang File (template.lang)";
            var dialogResult = ofd.ShowDialog();
            if (dialogResult != DialogResult.OK) return;*/

            try
            {

                //get template.lang file from same path as file being edited
                //assumption is that a new install always has a new template.lang file but leaves other lang files as-is.

               //var file = ofd.FileName;
                var path =  groupBoxLang.Text;
                string file = Path.GetFileName(path);
                string templateFile= path.Replace(file, "template.lang");
            
                var templateLang = Lang.LoadFromFile(templateFile);
                var editingLang  = GetLangFromTable();

                editingLang.GetUpdatedLangFromTemplate(templateLang, out Lang updatedLang, out List<string> newStrings, out List<string> removedStrings);

                LangDiff diffWindow = new LangDiff(newStrings, removedStrings);
                var res = diffWindow.ShowDialog(this);

                if (res == DialogResult.OK)
                {
                    PopulateTableFromLang(updatedLang);
                    //save to file next??

                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Lang GetLangFromTable()
        {
            Lang lang = new Lang();
            int totalControls = tableLayoutPanel1.Controls.Count;
            int i = 2; // Skip the headers.
            while (i < totalControls)
            {
                var control = tableLayoutPanel1.Controls[i];
                if (control is Panel panel)
                {
                    // Comment.
                    lang.LangItems.Add( panel.Controls[0].Text );
                }
                if (control is Label label)
                {
                    // Original string.
                    string original = label.Text;
                    string translation = tableLayoutPanel1.Controls[i + 1].Text;
                    lang.LangItems.Add(new TranslationItem(original, translation));
                    ++i;
                }
                ++i;
            }
            return lang;
        }

        //TODO
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonNextNotTranslated.PerformClick();//NOGO???
            }
        }

        private void buttonNextNotTranslated_Click(object sender, EventArgs e)
        {
            GenerateCountOfNonTranslated(true);
        }

       // private void buttonSaveFile_Click(object sender, EventArgs e)
        private void SaveFile()
        {
            try
            {
                var lang = GetLangFromTable();
                StringBuilder sb = new StringBuilder();
                foreach (var item in lang.LangItems)
                {
                    if (item is string comment)
                    {
                        sb.AppendLine(comment);
                    }
                    if (item is TranslationItem translationItem)
                    {
                        sb.AppendLine(translationItem.Original);
                        sb.AppendLine(translationItem.Translation);
                    }
                }
                string output = sb.ToString().Trim();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = groupBoxLang.Text;
                sfd.Title = "Save Lang File";
                sfd.Filter = "Language File (*.lang)|*.lang";
                var dr = sfd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string fileName = sfd.FileName;
                    File.WriteAllText(fileName, output);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompareWithTemplate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNumNotTranslated_Click(object sender, EventArgs e)
        {

        }

        private void characterMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("charmap.exe");
            }
            catch (System.ComponentModel.Win32Exception )
            {
                //handle exception
                throw;
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void onlineUserGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://searchcloudone.com/lfe-user-guide/LFE_User_Guide");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop == true)
            {
                Application.Exit();
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
