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
            var encntr = new Encounter(encounter);
            Encounter = encntr;
            charList = new List<Character>(Encounter.Characters);
            var view = new SortableBindingList<Character>();           
            foreach(var chrc in charList)
            {
                view.Add(chrc);
            }

            characterBindingSource.DataSource = view;
            Text = Encounter.Name;
            _btnSave.Enabled = false;
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
                charList.Clear();
                Encounter.LastEdit = DateTime.Now;
                foreach (var chrc in characterBindingSource.List as List<Character>)
                {
                    charList.Add(new Character(chrc));
                }
                Encounter.Characters = charList;
                _editFlag = true;
                _btnSave.Enabled = false;
            }                     
        }

        private bool ShowConfirmation( string message, string title )
        {
            return (MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        private void _dataGridViewRunEncounter_CellEndEdit( object sender, DataGridViewCellEventArgs e )
        {
            _btnSave.Enabled = true;
        }

        private void OnExit( object sender, EventArgs e )
        {
            if (_editFlag)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
            Close();
        }

        ListSortDirection sort = new ListSortDirection();
        private void OnColumnHeaderClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            if (sort == ListSortDirection.Descending)
                sort = ListSortDirection.Ascending;
            else
                sort = ListSortDirection.Descending;
            _dataGridViewRunEncounter.Sort(_dataGridViewRunEncounter.Columns[e.ColumnIndex], sort);
        }
    }
}
