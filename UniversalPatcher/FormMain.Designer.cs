
namespace UniversalPatcher
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.processListDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processListDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processListDataSet = new UniversalPatcher.UMPDataSet();
            this.patchListDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pATCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAllPatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.runSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.processListDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patchListDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.processListDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_TargetProcess = new System.Windows.Forms.TextBox();
            this.buttonProcessListLookup = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBytesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaceBytesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Applied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patchListDataTableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.patchListDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.patchListDataTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Process";
            // 
            // processListDataTableBindingSource
            // 
            this.processListDataTableBindingSource.DataMember = "ProcessListDataTable";
            this.processListDataTableBindingSource.DataSource = this.processListDataSetBindingSource;
            // 
            // processListDataSetBindingSource
            // 
            this.processListDataSetBindingSource.DataSource = this.processListDataSet;
            this.processListDataSetBindingSource.Position = 0;
            // 
            // processListDataSet
            // 
            this.processListDataSet.DataSetName = "ProcessListDataSet";
            this.processListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patchListDataTableBindingSource
            // 
            this.patchListDataTableBindingSource.DataMember = "PatchListDataTable";
            this.patchListDataTableBindingSource.DataSource = this.processListDataSetBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.patchesToolStripMenuItem,
            this.pATCHToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProfileToolStripMenuItem,
            this.saveProfileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.fileToolStripMenuItem.Text = "Profile";
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.loadProfileToolStripMenuItem.Text = "Load";
            this.loadProfileToolStripMenuItem.Click += new System.EventHandler(this.LoadProfileToolStripMenuItem_Click);
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.saveProfileToolStripMenuItem.Text = "Save";
            this.saveProfileToolStripMenuItem.Click += new System.EventHandler(this.SaveProfileToolStripMenuItem_Click);
            // 
            // patchesToolStripMenuItem
            // 
            this.patchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editSelectedToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteSelectedToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
            this.patchesToolStripMenuItem.Name = "patchesToolStripMenuItem";
            this.patchesToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.patchesToolStripMenuItem.Text = "Patches";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // editSelectedToolStripMenuItem
            // 
            this.editSelectedToolStripMenuItem.Name = "editSelectedToolStripMenuItem";
            this.editSelectedToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.editSelectedToolStripMenuItem.Text = "Edit";
            this.editSelectedToolStripMenuItem.Click += new System.EventHandler(this.EditSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.deleteSelectedToolStripMenuItem.Text = "Delete selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.deleteAllToolStripMenuItem.Text = "Delete all";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllToolStripMenuItem_Click);
            // 
            // pATCHToolStripMenuItem
            // 
            this.pATCHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runAllPatchesToolStripMenuItem,
            this.toolStripSeparator2,
            this.runSelectedToolStripMenuItem});
            this.pATCHToolStripMenuItem.Name = "pATCHToolStripMenuItem";
            this.pATCHToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.pATCHToolStripMenuItem.Text = "Patcher";
            this.pATCHToolStripMenuItem.Click += new System.EventHandler(this.PatchToolStripMenuItem_Click);
            // 
            // runAllPatchesToolStripMenuItem
            // 
            this.runAllPatchesToolStripMenuItem.Name = "runAllPatchesToolStripMenuItem";
            this.runAllPatchesToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.runAllPatchesToolStripMenuItem.Text = "Run all ";
            this.runAllPatchesToolStripMenuItem.Click += new System.EventHandler(this.RunAllPatchesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // runSelectedToolStripMenuItem
            // 
            this.runSelectedToolStripMenuItem.Name = "runSelectedToolStripMenuItem";
            this.runSelectedToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.runSelectedToolStripMenuItem.Text = "Run selected";
            this.runSelectedToolStripMenuItem.Click += new System.EventHandler(this.RunSelectedToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
            // 
            // processListDataTableBindingSource1
            // 
            this.processListDataTableBindingSource1.DataMember = "ProcessListDataTable";
            this.processListDataTableBindingSource1.DataSource = this.processListDataSetBindingSource;
            // 
            // patchListDataTableBindingSource1
            // 
            this.patchListDataTableBindingSource1.DataMember = "PatchListDataTable";
            this.patchListDataTableBindingSource1.DataSource = this.processListDataSetBindingSource;
            // 
            // processListDataTableBindingSource2
            // 
            this.processListDataTableBindingSource2.DataMember = "ProcessListDataTable";
            this.processListDataTableBindingSource2.DataSource = this.processListDataSetBindingSource;
            // 
            // textBox_TargetProcess
            // 
            this.textBox_TargetProcess.Location = new System.Drawing.Point(98, 39);
            this.textBox_TargetProcess.Name = "textBox_TargetProcess";
            this.textBox_TargetProcess.ReadOnly = true;
            this.textBox_TargetProcess.Size = new System.Drawing.Size(165, 20);
            this.textBox_TargetProcess.TabIndex = 12;
            // 
            // buttonProcessListLookup
            // 
            this.buttonProcessListLookup.Location = new System.Drawing.Point(269, 38);
            this.buttonProcessListLookup.Name = "buttonProcessListLookup";
            this.buttonProcessListLookup.Size = new System.Drawing.Size(67, 22);
            this.buttonProcessListLookup.TabIndex = 13;
            this.buttonProcessListLookup.Text = "Browse...";
            this.buttonProcessListLookup.UseVisualStyleBackColor = true;
            this.buttonProcessListLookup.Click += new System.EventHandler(this.ButtonProcessListLookup_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.searchBytesDataGridViewTextBoxColumn,
            this.replaceBytesDataGridViewTextBoxColumn,
            this.Applied});
            this.dataGridView1.DataSource = this.patchListDataTableBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(310, 255);
            this.dataGridView1.TabIndex = 14;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // searchBytesDataGridViewTextBoxColumn
            // 
            this.searchBytesDataGridViewTextBoxColumn.DataPropertyName = "SearchBytes";
            this.searchBytesDataGridViewTextBoxColumn.HeaderText = "Search Bytes";
            this.searchBytesDataGridViewTextBoxColumn.Name = "searchBytesDataGridViewTextBoxColumn";
            this.searchBytesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // replaceBytesDataGridViewTextBoxColumn
            // 
            this.replaceBytesDataGridViewTextBoxColumn.DataPropertyName = "ReplaceBytes";
            this.replaceBytesDataGridViewTextBoxColumn.HeaderText = "Replace Bytes";
            this.replaceBytesDataGridViewTextBoxColumn.Name = "replaceBytesDataGridViewTextBoxColumn";
            this.replaceBytesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Applied
            // 
            this.Applied.DataPropertyName = "Applied";
            this.Applied.HeaderText = "Applied";
            this.Applied.Name = "Applied";
            this.Applied.ReadOnly = true;
            // 
            // patchListDataTableBindingSource4
            // 
            this.patchListDataTableBindingSource4.DataMember = "PatchListDataTable";
            this.patchListDataTableBindingSource4.DataSource = this.processListDataSetBindingSource;
            // 
            // patchListDataTableBindingSource2
            // 
            this.patchListDataTableBindingSource2.DataMember = "PatchListDataTable";
            this.patchListDataTableBindingSource2.DataSource = this.processListDataSetBindingSource;
            // 
            // patchListDataTableBindingSource3
            // 
            this.patchListDataTableBindingSource3.DataMember = "PatchListDataTable";
            this.patchListDataTableBindingSource3.DataSource = this.processListDataSetBindingSource;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 293);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patch List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 264);
            this.listBox1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 365);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonProcessListLookup);
            this.Controls.Add(this.textBox_TargetProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "MP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processListDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchListDataTableBindingSource3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource processListDataTableBindingSource;
        private System.Windows.Forms.BindingSource processListDataSetBindingSource;
        private UMPDataSet processListDataSet;
        private System.Windows.Forms.BindingSource patchListDataTableBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
        private System.Windows.Forms.BindingSource patchListDataTableBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem pATCHToolStripMenuItem;
        private System.Windows.Forms.BindingSource processListDataTableBindingSource1;
        private System.Windows.Forms.BindingSource processListDataTableBindingSource2;
        private System.Windows.Forms.TextBox textBox_TargetProcess;
        private System.Windows.Forms.Button buttonProcessListLookup;
        private System.Windows.Forms.ToolStripMenuItem patchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAllPatchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runSelectedToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.BindingSource patchListDataTableBindingSource2;
        private System.Windows.Forms.BindingSource patchListDataTableBindingSource4;
        private System.Windows.Forms.BindingSource patchListDataTableBindingSource3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchBytesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceBytesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Applied;
    }
}

