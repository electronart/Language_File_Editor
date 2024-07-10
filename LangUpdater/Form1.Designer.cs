namespace LangUpdater
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.groupBoxLang = new System.Windows.Forms.GroupBox();
            this.buttonUpdateFromTemplate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalStrings = new System.Windows.Forms.Label();
            this.labelNumNotTranslated = new System.Windows.Forms.Label();
            this.buttonNextNotTranslated = new System.Windows.Forms.Button();
            this.groupBoxLang.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(94, 23);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Load File...";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // groupBoxLang
            // 
            this.groupBoxLang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLang.Controls.Add(this.buttonNextNotTranslated);
            this.groupBoxLang.Controls.Add(this.labelNumNotTranslated);
            this.groupBoxLang.Controls.Add(this.labelTotalStrings);
            this.groupBoxLang.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxLang.Controls.Add(this.buttonUpdateFromTemplate);
            this.groupBoxLang.Enabled = false;
            this.groupBoxLang.Location = new System.Drawing.Point(12, 41);
            this.groupBoxLang.Name = "groupBoxLang";
            this.groupBoxLang.Size = new System.Drawing.Size(664, 343);
            this.groupBoxLang.TabIndex = 1;
            this.groupBoxLang.TabStop = false;
            this.groupBoxLang.Text = "No file loaded";
            // 
            // buttonUpdateFromTemplate
            // 
            this.buttonUpdateFromTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdateFromTemplate.Location = new System.Drawing.Point(6, 306);
            this.buttonUpdateFromTemplate.Name = "buttonUpdateFromTemplate";
            this.buttonUpdateFromTemplate.Size = new System.Drawing.Size(161, 23);
            this.buttonUpdateFromTemplate.TabIndex = 1;
            this.buttonUpdateFromTemplate.Text = "Update from Template...";
            this.buttonUpdateFromTemplate.UseVisualStyleBackColor = true;
            this.buttonUpdateFromTemplate.Click += new System.EventHandler(this.buttonUpdateFromTemplate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 243);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(258, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 243);
            this.label2.TabIndex = 1;
            this.label2.Text = "Translation";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFile.Location = new System.Drawing.Point(589, 396);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(87, 23);
            this.buttonSaveFile.TabIndex = 2;
            this.buttonSaveFile.Text = "Save File...";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 31);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "ElectronArt Design Limited";
            // 
            // labelTotalStrings
            // 
            this.labelTotalStrings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalStrings.AutoSize = true;
            this.labelTotalStrings.Location = new System.Drawing.Point(6, 284);
            this.labelTotalStrings.Name = "labelTotalStrings";
            this.labelTotalStrings.Size = new System.Drawing.Size(13, 15);
            this.labelTotalStrings.TabIndex = 2;
            this.labelTotalStrings.Text = "0";
            // 
            // labelNumNotTranslated
            // 
            this.labelNumNotTranslated.AutoSize = true;
            this.labelNumNotTranslated.Location = new System.Drawing.Point(463, 290);
            this.labelNumNotTranslated.Name = "labelNumNotTranslated";
            this.labelNumNotTranslated.Size = new System.Drawing.Size(95, 15);
            this.labelNumNotTranslated.TabIndex = 3;
            this.labelNumNotTranslated.Text = "Not Translated: 0";
            // 
            // buttonNextNotTranslated
            // 
            this.buttonNextNotTranslated.Location = new System.Drawing.Point(577, 287);
            this.buttonNextNotTranslated.Name = "buttonNextNotTranslated";
            this.buttonNextNotTranslated.Size = new System.Drawing.Size(70, 23);
            this.buttonNextNotTranslated.TabIndex = 4;
            this.buttonNextNotTranslated.Text = ">>";
            this.buttonNextNotTranslated.UseVisualStyleBackColor = true;
            this.buttonNextNotTranslated.Click += new System.EventHandler(this.buttonNextNotTranslated_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(688, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.groupBoxLang);
            this.Controls.Add(this.buttonLoadFile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lang Editor";
            this.groupBoxLang.ResumeLayout(false);
            this.groupBoxLang.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.GroupBox groupBoxLang;
        private System.Windows.Forms.Button buttonUpdateFromTemplate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalStrings;
        private System.Windows.Forms.Label labelNumNotTranslated;
        private System.Windows.Forms.Button buttonNextNotTranslated;
    }
}

