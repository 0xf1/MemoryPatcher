
namespace UniversalPatcher
{
    partial class FormPatchCard
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
            this.textBoxPatchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SearchBytes = new System.Windows.Forms.TextBox();
            this.textBox_ReplaceBytes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patch Name";
            // 
            // textBoxPatchName
            // 
            this.textBoxPatchName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPatchName.Location = new System.Drawing.Point(97, 12);
            this.textBoxPatchName.Name = "textBoxPatchName";
            this.textBoxPatchName.Size = new System.Drawing.Size(356, 20);
            this.textBoxPatchName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Bytes";
            // 
            // textBox_SearchBytes
            // 
            this.textBox_SearchBytes.Location = new System.Drawing.Point(97, 38);
            this.textBox_SearchBytes.Name = "textBox_SearchBytes";
            this.textBox_SearchBytes.Size = new System.Drawing.Size(356, 20);
            this.textBox_SearchBytes.TabIndex = 1;
            // 
            // textBox_ReplaceBytes
            // 
            this.textBox_ReplaceBytes.Location = new System.Drawing.Point(97, 64);
            this.textBox_ReplaceBytes.Name = "textBox_ReplaceBytes";
            this.textBox_ReplaceBytes.Size = new System.Drawing.Size(356, 20);
            this.textBox_ReplaceBytes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Replace Bytes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormPatchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 127);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_ReplaceBytes);
            this.Controls.Add(this.textBox_SearchBytes);
            this.Controls.Add(this.textBoxPatchName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPatchCard";
            this.Text = "Patch Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SearchBytes;
        private System.Windows.Forms.TextBox textBox_ReplaceBytes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}