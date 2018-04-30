using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncounterBuilder
{
    public partial class RunEncounterForm : Form
    {
        public RunEncounterForm(Encounter encounter)
        {
            InitializeComponent();
            Encounter = encounter;
            charList = new List<Character>(Encounter.Characters);
            characterBindingSource.DataSource = charList.ToList();
            Text = Encounter.Name;           
            DialogResult = DialogResult.Cancel;
        }

        public Encounter Encounter { get; set; }
        private List<Character> charList = null;
        private bool _editFlag = false;

        private void OnSave( object sender, EventArgs e )
        {
            var result = MessageBox.Show(this, "Save changes?", "Save Encounter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Encounter.LastEdit = DateTime.Now;
                Encounter.Characters = characterBindingSource.List as List<Character>;
                _editFlag = true;
            }                     
        }

        private bool ShowConfirmation( string message, string title )
        {
            return (MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        private void _dataGridViewRunEncounter_CellEndEdit( object sender, DataGridViewCellEventArgs e )
        {
           
        }

        private void OnExit( object sender, EventArgs e )
        {
            if (_editFlag)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
