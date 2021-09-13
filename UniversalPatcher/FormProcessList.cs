using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniversalPatcher
{
    public partial class FormProcessList : Form
    {
        UMPDataSet.ProcessListDataTableDataTable dataTable;
        private string filter;

        public TargetProcess SelectedTargetProcess { get; private set; }

        public FormProcessList(string filter)
        {
            InitializeComponent();
            this.filter = filter;            
        }

        private void FormProcessList_Load(object sender, EventArgs e)
        {
            LoadList();
            textBox1.Text = filter;
        }

        private void LoadList()
        {
            dataTable = new UMPDataSet.ProcessListDataTableDataTable();
            foreach(Process process in GetCurrentUserProcesses())
            {
                dataTable.Rows.Add(new string[] { process.ProcessName, process.Id.ToString(), process.MainWindowTitle });
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

        }

        public static IEnumerable<Process> GetCurrentUserProcesses()
        {
            int mySesId = Process.GetCurrentProcess().SessionId;
            return Process.GetProcesses().Where(p => p.SessionId == mySesId);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Format("name like '%{0}%'", textBox1.Text);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProcess();
        }

        private void SelectProcess()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose process from the list");
                return;
            }

            DataGridViewCellCollection cells = dataGridView1.SelectedRows[0].Cells;
            this.SelectedTargetProcess = new TargetProcess((string)cells[0].Value, (int)cells[1].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SelectProcess();

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectProcess();
            }

        }
    }
}
