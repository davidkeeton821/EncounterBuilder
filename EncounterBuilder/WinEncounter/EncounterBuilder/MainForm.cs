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
            var edit = false;
            Encounter encounter = null;

            encounter = GetEncounter(edit);              

            if(encounter != null)
                DeleteEncounter(encounter); 
        }

        private void OnEncounterLoad(object sender, EventArgs e)
        {
            var edit = true;
            Encounter encounter = null;

            encounter = GetEncounter(edit);
              
            if (encounter != null)
                EditEncounter(encounter);
        }

        private Encounter GetEncounter(bool edit)
        {       
            try
            {
                var source = _database.GetAll();
                if (!source.Any())
                    throw new Exception("No Encounters To Show");

                var form = new LoadEncounterForm()
                {
                    Source = _database                
                };

                var button = form.Controls.Find("_btnLoad", true);
                if (edit)
                {
                    form.Text = "Edit Encounter";                   
                    button[0].Text = "Edit";
                }
                else
                {
                    form.Text = "Delete Encounter";
                    button[0].Text = "Delete";
                }
                while (true)
                {
                    //Show form modally
                    var result = form.ShowDialog(this);
                    if (result != DialogResult.OK)
                        return null;

                    if (form.Encounter != null)
                        return form.Encounter;
                    else
                        MessageBox.Show("No Encounter Selected");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
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

        private void EditEncounter( Encounter encounter )
        {
            var form = new EncounterDetailForm(encounter);

            //Show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
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
