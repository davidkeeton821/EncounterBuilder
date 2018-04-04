using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncounterBuilder.Data;
using EncounterBuilder.Data.Memory;

namespace EncounterBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _database = new MemoryEncounterBuilderDatabase();
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnEncounterNew( object sender, EventArgs e )
        {
            var form = new EncounterDetailForm
            {
                Text = "Add Encounter"
            };

            //Show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //"Add" the Encounter
            try
            {
                _database.Add(form.Encounter);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnEncounterDelete( object sender, EventArgs e )
        {
            var encounter = GetEncounter("Delete Encounter");
            if (encounter == null)
            {
                MessageBox.Show(this, "No Encounter Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            DeleteEncounter(encounter);
        }

        private Encounter GetEncounter(string title)
        {
            var form = new LoadEncounterForm();
            {
                Text = title
            };

            //Show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return null;

            return form;
        }

        private void DeleteEncounter( Encounter encounter )
        {
            if (!ShowConfirmation("Are you sure?", "Remove Encounter"))
                return;

            //Remove Encounter
            try
            {
                _database.Remove(encounter.Id);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void OnEncounterLoad( object sender, EventArgs e )
        {
            //Get selected Encounter
            var encounter = GetEncounter("");
            if (encounter == null)
            {
                MessageBox.Show(this, "No Encounter Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            EditEncounter(encounter);
        }

        private void EditEncounter( Encounter encounter )
        {
            var form = new EncounterDetailForm(encounter);

            //Show form modally
            var result = form.ShowDialog(this); //show child form (ProductRetailForm), return back dailog result
            if (result != DialogResult.OK)  //use dialog result from child form
                return;

            //Add to database
            form.Encounter.Id = encounter.Id;
            try
            {
                _database.Update(form.Encounter);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            };

            RefreshUI();
        }

            private void OnHelpAbout( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not Implemented", "Help About", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private bool ShowConfirmation( string message, string title )
        {
            return (MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        private IEncounterBuilderDatabase _database;
    }
}
