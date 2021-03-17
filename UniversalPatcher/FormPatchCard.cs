using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniversalPatcher
{
    public partial class FormPatchCard : Form//, INotifyPropertyChanged
    {
        
        public Patch Patch { get; private set; }

        public FormPatchCard(Patch patch)
        {
            InitializeComponent();
            textBoxPatchName.DataBindings.Add("Text", this, "Patch.Name",false,DataSourceUpdateMode.OnPropertyChanged);
            textBox_SearchBytes.DataBindings.Add("Text", this, "Patch.SearchBytes", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox_ReplaceBytes.DataBindings.Add("Text", this, "Patch.ReplaceBytes", false, DataSourceUpdateMode.OnPropertyChanged);
            this.Patch = patch;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Patch.Name) || String.IsNullOrEmpty(Patch.ReplaceBytes) || String.IsNullOrEmpty(Patch.SearchBytes))
            {
                MessageBox.Show("All field must be supplied");
                return;
            }

            this.DialogResult = DialogResult.OK;
            Close();            
        }

    }
}
