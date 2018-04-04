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
    public partial class EncounterDetailForm : Form
    {
        public EncounterDetailForm()
        {
            InitializeComponent();
        }

        public EncounterDetailForm (Encounter encounter)
        {
            Text = ("Edit Encounter");
            Encounter = encounter;
        }

        public Encounter Encounter { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            //Create Encounter
            var encounter = new Encounter();
            encounter.Name = _textName.Text;
            encounter.Description = _textDescription.Text;
            encounter.LastEdit = DateTime.Now;
            encounter.Characters = _characters;

            //return from form
            Encounter = encounter;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            //DialogResult set to Cancel, no method needed
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //Load Encounter
            if (Encounter != null)
            {
                _textName.Text = Encounter.Name;
                _textDescription.Text = Encounter.Description;
                _characters = Encounter.Characters;
            }
        }

        private void OnCharacterAdd( object sender, EventArgs e )
        {
            var form = new CharacterDetailForm();
            form.Text = "Add Character";

            //Show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //"Add" the Character
            _characters.Add(form.Character);
        }

        private List<Character> _characters;
    }
}
