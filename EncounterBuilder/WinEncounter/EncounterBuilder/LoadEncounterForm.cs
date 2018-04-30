using EncounterBuilder.Data;
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
    public partial class LoadEncounterForm : Form
    {
        public LoadEncounterForm(bool edit)
        {
            InitializeComponent();
            Edit = edit;
            var button = Controls.Find("_btnLoad", true);
            if (edit)
            {
                Text = "Load Encounter";
                button[0].Text = "Load";
            } else
            {
                Text = "Delete Encounter";
                button[0].Text = "Delete";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            IEnumerable<Encounter> encounters = null;
            try
            {
                encounters = Source.GetAll();
                encounterBindingSource.DataSource = encounters.ToList();
            }
            catch
            {
                MessageBox.Show("Error loading encounters");
                return;
            }

            _dataGridViewLoadEncounter.ClearSelection();
        }

        public IEncounterBuilderDatabase Source {get; set;}

        public Encounter Encounter { get; set; }
        public bool Edit { get; set; }

        private void OnButtonActionClick(object sender, EventArgs e)
        {
            if (_dataGridViewLoadEncounter.SelectedRows.Count > 0)
            {
                if (Edit)
                {
                    var encounter = _dataGridViewLoadEncounter.SelectedRows[0].DataBoundItem as Encounter;
                    Encounter = encounter;
                }
                else
                {
                    if (!ShowConfirmation("Are you sure?", "Remove Encounter"))                    
                        return;

                    var encounter = _dataGridViewLoadEncounter.SelectedRows[0].DataBoundItem as Encounter;
                    Encounter = encounter;
                }
            }           
        }

        private void _dataGridViewLoadEncounter_ColumnHeaderMouseClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            //need to be able to implement a sortable BindingSource to be able to sort by column

            //var columnIndex = e.ColumnIndex;
            //// Check which column is selected, otherwise set NewColumn to null.
            //DataGridViewColumn newColumn = _dataGridViewLoadEncounter.Columns[columnIndex];
            //    //_dataGridViewLoadEncounter.Columns.GetColumnCount(
            //    //DataGridViewElementStates.Selected) == 1 ?
            //    //_dataGridViewLoadEncounter.SelectedColumns[0] : null;

            //DataGridViewColumn oldColumn = _dataGridViewLoadEncounter.SortedColumn;
            //ListSortDirection direction;

            //// If oldColumn is null, then the DataGridView is not currently sorted.
            //if (oldColumn != null)
            //{
            //    // Sort the same column again, reversing the SortOrder.
            //    if (oldColumn == newColumn &&
            //        _dataGridViewLoadEncounter.SortOrder == SortOrder.Ascending)
            //    {
            //        direction = ListSortDirection.Descending;
            //    } else
            //    {
            //        // Sort a new column and remove the old SortGlyph.
            //        direction = ListSortDirection.Ascending;
            //        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
            //    }
            //} else
            //{
            //    direction = ListSortDirection.Ascending;
            //}

            //// If no column has been selected, display an error dialog  box.
            //if (newColumn == null)
            //{
            //    MessageBox.Show("Select a single column and try again.",
            //        "Error: Invalid Selection", MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //} else
            //{
            //    _dataGridViewLoadEncounter.Sort(newColumn, direction);
            //    newColumn.HeaderCell.SortGlyphDirection =
            //        direction == ListSortDirection.Ascending ?
            //        SortOrder.Ascending : SortOrder.Descending;
            //}
        }

        private bool ShowConfirmation( string message, string title )
        {
            return (MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }
    }    
}
