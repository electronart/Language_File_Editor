namespace LangUpdater
{
    partial class LangDiff
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxNewStrings = new System.Windows.Forms.ListBox();
            this.listBoxRemovedStrings = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelNumNewStrings = new System.Windows.Forms.Label();
            this.labelNumRemovedStrings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Strings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Removed Strings";
            // 
            // listBoxNewStrings
            // 
            this.listBoxNewStrings.FormattingEnabled = true;
            this.listBoxNewStrings.Location = new System.Drawing.Point(15, 25);
            this.listBoxNewStrings.Name = "listBoxNewStrings";
            this.listBoxNewStrings.Size = new System.Drawing.Size(157, 173);
            this.listBoxNewStrings.TabIndex = 0;
            // 
            // listBoxRemovedStrings
            // 
            this.listBoxRemovedStrings.FormattingEnabled = true;
            this.listBoxRemovedStrings.Location = new System.Drawing.Point(184, 25);
            this.listBoxRemovedStrings.Name = "listBoxRemovedStrings";
            this.listBoxRemovedStrings.Size = new System.Drawing.Size(157, 173);
            this.listBoxRemovedStrings.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(299, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(218, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "&OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelNumNewStrings
            // 
            this.labelNumNewStrings.AutoSize = true;
            this.labelNumNewStrings.Location = new System.Drawing.Point(12, 201);
            this.labelNumNewStrings.Name = "labelNumNewStrings";
            this.labelNumNewStrings.Size = new System.Drawing.Size(13, 13);
            this.labelNumNewStrings.TabIndex = 4;
            this.labelNumNewStrings.Text = "0";
            // 
            // labelNumRemovedStrings
            // 
            this.labelNumRemovedStrings.AutoSize = true;
            this.labelNumRemovedStrings.Location = new System.Drawing.Point(181, 201);
            this.labelNumRemovedStrings.Name = "labelNumRemovedStrings";
            this.labelNumRemovedStrings.Size = new System.Drawing.Size(13, 13);
            this.labelNumRemovedStrings.TabIndex = 5;
            this.labelNumRemovedStrings.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 45);
            this.panel1.TabIndex = 6;
            // 
            // LangDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(386, 275);
            this.Controls.Add(this.labelNumRemovedStrings);
            this.Controls.Add(this.labelNumNewStrings);
            this.Controls.Add(this.listBoxRemovedStrings);
            this.Controls.Add(this.listBoxNewStrings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LangDiff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diff";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxNewStrings;
        private System.Windows.Forms.ListBox listBoxRemovedStrings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelNumNewStrings;
        private System.Windows.Forms.Label labelNumRemovedStrings;
        private System.Windows.Forms.Panel panel1;
    }
}