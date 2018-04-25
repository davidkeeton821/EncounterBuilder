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
        public RunEncounterForm(List<Character> characters, string name)
        {
            InitializeComponent();
            characterBindingSource.DataSource = characters;
            Text = name;
        }

        public Encounter Encounter { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ShowConfirmation("Save changes to encounter, and exit?", "Save Encounter"))
                return;
        }

        private bool ShowConfirmation( string message, string title )
        {
            return (MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }
    }
}
