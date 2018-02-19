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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not Implemented", "File Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void OnEncounterNew( object sender, EventArgs e )
        {
            var form = new EncounterDetailForm();
            form.Text = "Add Encounter";

            //Show for modally
            var result = form.ShowDialog();
            if (result != DialogResult.OK)
                return;

            _encounter = form.Encounter;

            MessageBox.Show(this, "Not Implemented", "Encounter New", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void OnEncounterDelete( object sender, EventArgs e )
        {
            if (ShowConfirmation("Are you sure?", "Remove Product"))
                return;

            //TODO: Remove Product
            MessageBox.Show("Not Implented");
        }

        private void OnEncounterLoad( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not Implemented", "Encounter Load", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not Implemented", "Help About", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private bool ShowConfirmation( string message, string title )
        {
            return (MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        private Encounter _encounter;
    }
}
