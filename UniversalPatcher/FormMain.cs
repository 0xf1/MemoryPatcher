using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace UniversalPatcher
{
    public partial class FormMain : Form
    {
        TargetProcess TargetProcess;

        UMPDataSet.PatchListDataTableDataTable patchListDataTable;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            patchListDataTable = new UMPDataSet.PatchListDataTableDataTable();                        
            LoadLastProfile();
        }

        private void LoadLastProfile()
        {
            if (File.Exists("patcher.cfg"))
            {
                TextReader tr = new StreamReader("patcher.cfg");
                String lastProfile = tr.ReadLine();
                tr.Close();
                if (!string.IsNullOrEmpty(lastProfile))
                {
                    if (File.Exists(lastProfile)) {
                        LoadProfileFromFile(lastProfile);                        
                    }
                    
                }
            }
        }

  
        private void ButtonProcessListLookup_Click(object sender, EventArgs e)
        {
            FormProcessList formProcessList = new FormProcessList();
            if (formProcessList.ShowDialog() == DialogResult.OK)
            {
                this.TargetProcess = formProcessList.SelectedTargetProcess;
                this.textBox_TargetProcess.Text = string.Format("{0} ({1})", TargetProcess.Name, TargetProcess.Id);
            }
        }

        private void PatchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPatchCard patchCard = new FormPatchCard(new Patch());            
            if (patchCard.ShowDialog() == DialogResult.OK)
            {
                AddPatchToGrid(patchCard.Patch);
            }
        }

        private void AddPatchToGrid(Patch patch)
        {

            DataRow row = patchListDataTable.NewRow();
            row["Name"] = patch.Name;
            row["SearchBytes"] = patch.SearchBytes;
            row["ReplaceBytes"] = patch.ReplaceBytes;
            row["Applied"] = false;

            var oldRow = patchListDataTable.Rows.Find(patch.Name);
            if (oldRow != null)
            {
                oldRow.Delete();
            }

            patchListDataTable.Rows.Add(row);
            //dataGridView1.Refresh();
            RefreshPatchList();
        }

        private void EditSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Row not selected");
                return;
            }

            FormPatchCard patchCard = new FormPatchCard(GetPatchFromSelectedGridViewRow());
            Patch oldPatch = patchCard.Patch.ShallowCopy();
            if (patchCard.ShowDialog() == DialogResult.OK)
            {
                patchListDataTable.Rows.Find(oldPatch.Name).Delete();
                AddPatchToGrid(patchCard.Patch);
            }
        }
        

        private Patch GetPatchFromSelectedGridViewRow()
        {            
            return DataGridViewRowToPatch(dataGridView1.SelectedRows[0]);
        }

        private Patch DataGridViewRowToPatch(DataGridViewRow dataGridViewRow)
        {
            DataGridViewCellCollection cells = dataGridViewRow.Cells;
            Patch patch = new Patch
            {
                Name = (string)cells[0].Value,
                SearchBytes = (string)cells[1].Value,
                ReplaceBytes = (string)cells[2].Value
            };
            return patch;
        }

        private void DeleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
            {
                var row = patchListDataTable.Rows.Find(selectedRow.Cells[0].Value);
                if (row != null)
                {
                    row.Delete();
                }
            }

            RefreshPatchList();
        }

        private void RefreshPatchList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = patchListDataTable;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

        }

        private void DeleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patchListDataTable = new UMPDataSet.PatchListDataTableDataTable();
            RefreshPatchList();
        }

        private void SaveProfile()
        {
            if (TargetProcess == null)
            {
                MessageBox.Show("Target process not selected");
                return;
            }

            if (patchListDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Patch list is empty");
                return;
            }

            List<String> lines = new List<string> { TargetProcess.Name };
            foreach (DataRow row in patchListDataTable.Rows)
            {
                lines.Add(row["Name"].ToString());
                lines.Add(row["SearchBytes"].ToString());
                lines.Add(row["ReplaceBytes"].ToString());
            }


            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "profiles (*.profile)|*.profile",
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(dialog.FileName);
                foreach (String s in lines)
                {
                    tw.WriteLine(s);
                }

                tw.Close();
                SaveLastProfile(dialog.FileName);
            }
        }

        private void SaveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProfile();
        }

        private void LoadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProfile();
        }

        private void OpenProfile()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "profiles (*.profile)|*.profile",
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadProfileFromFile(dialog.FileName);
            }
        }

        private TargetProcess GetFirstProcessByName(string v)
        {
            IEnumerable<Process> procs = Process.GetProcessesByName(v)
                .Where(p => p.SessionId == Process.GetCurrentProcess().SessionId);
            ;
            if (procs.Count() == 1)
            {
                //Process proc = procs[0];
                Process proc = procs.First();
                return new TargetProcess(proc.ProcessName, proc.Id);
            }
            return null;
        }

        private void RunAllPatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Patch> patches = new List<Patch>();
            foreach(DataRow row in patchListDataTable.Rows)
            {
                Patch patch = DataRow2Patch(row);
                patches.Add(patch);
            }

            ApplyPatches(patches);
        }

        private Patch DataRow2Patch(DataRow row)
        {
            Patch patch = new Patch
            {
                Name = (string)row["Name"],
                SearchBytes = (string)row["SearchBytes"],
                ReplaceBytes = (string)row["ReplaceBytes"]
            };

            return patch;
        }

        private void ApplyPatches(List<Patch> patches)
        {
            if (TargetProcess == null)
            {
                MessageBox.Show("Target process not selected");
                return;
            }
            if (patches.Count == 0)
            {
                MessageBox.Show("No patches to apply");
                return;
            }
            Patcher.ApplyPatches(this.TargetProcess,ref patches);

            listBox1.DataSource = Patcher.logs;

            tabControl1.SelectTab(1);
            
            foreach(Patch patch in patches)
            {
                DataRow row = patchListDataTable.Rows.Find(patch.Name);
                if (row != null)
                {
                    row["Applied"] = patch.Applied;
                }
            }

            RefreshPatchList();
        }


        private void LoadProfileFromFile(string profilePath)
        {
            TextReader tr = new StreamReader(profilePath);
            List<String> lines = new List<string>();
            String l;
            while ((l = tr.ReadLine()) != null)
            {
                lines.Add(l);
            }
            tr.Close();

            List<Patch> patches = new List<Patch>();
            Patch patch = new Patch();
            int i = 0;
            foreach (String line in lines)
            {
                if (i == 0)
                {
                    TargetProcess = GetFirstProcessByName(line);
                    if (TargetProcess != null)
                    {
                        this.textBox_TargetProcess.Text = string.Format("{0} ({1})", TargetProcess.Name, TargetProcess.Id);
                    }
                }
                else if (i == 1)
                {
                    patch = new Patch
                    {
                        Name = line
                    };
                }
                else if (i == 2)
                {
                    patch.SearchBytes = line;
                }
                else if (i == 3)
                {
                    patch.ReplaceBytes = line;
                    patches.Add(patch);
                    i = 0;
                }

                i++;
            }

            if (i != 1)
            {
                MessageBox.Show("Profile corrupted");
                return;
            }

            foreach (Patch patch1 in patches)
            {
                DataRow row = patchListDataTable.NewRow();
                row["Name"] = patch1.Name;
                row["SearchBytes"] = patch1.SearchBytes;
                row["ReplaceBytes"] = patch1.ReplaceBytes;
                row["Applied"] = false;


                patchListDataTable.Rows.Add(row);

            }

            RefreshPatchList();
            SaveLastProfile(profilePath);
        }

        private static void SaveLastProfile(string path)
        {
            TextWriter tw = new StreamWriter("patcher.cfg", false);
            tw.WriteLine(path);
            tw.Close();
        }

        private void RunSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Patch> patches = new List<Patch>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                patches.Add(DataGridViewRowToPatch(row));
            }
            ApplyPatches(patches);
        }
    }
}

