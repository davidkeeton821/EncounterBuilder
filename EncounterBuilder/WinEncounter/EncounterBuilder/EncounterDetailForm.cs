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
            InitializeComponent();
            Text = ("Edit Encounter");
            Encounter = encounter;
        }

        public Encounter Encounter { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            var encounter = SaveEncounter();

            //return from form
            Encounter = encounter;
            DialogResult = DialogResult.OK;
            Close();
        }

        private Encounter SaveEncounter()
        {
            //Create Encounter
            return new Encounter
            {
                Name = _textName.Text,
                Description = _textDescription.Text,
                LastEdit = DateTime.Now,
                Characters = charList
            };
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //Load Encounter
            if (Encounter != null)
            {
                _textName.Text = Encounter.Name;
                _textDescription.Text = Encounter.Description;
                charList = Encounter.Characters;
                characterBindingSource.DataSource = Encounter.Characters;
            }
        }

        private Character GetCharacter()
        {
            try
            {
                var character = _dataGridViewCharacters.SelectedRows[0].DataBoundItem as Character;
                return character;
            } catch
            {
                MessageBox.Show("No Character Selected");
                return null;
            }
        }

        private void OnCharacterAdd( object sender, EventArgs e )
        {
            var form = new CharacterDetailForm
            {
                Text = "Add Character"
            };

            //Show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //"Add" the Character
            charList.Add(form.Character);

            RefreshUI();
        }       

        private void OnCharacterEdit( object sender, EventArgs e )
        {
            
            var existing = GetCharacter();
            if (existing == null)
                return;

            var form = new CharacterDetailForm(existing);

            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //Update the Character
            //CopyCharacter(existing, form.Character);
            charList.ElementAt(charList.IndexOf(existing)).Name = form.Character.Name;

            RefreshUI();           
        }

        private void CopyCharacter( Character copyTo, Character copyFrom )
        {
            //var index = charList.IndexOf(existing);

            //charList.ElementAt(index).Name = newChar.Name;
        }

        private void OnCharacterDelete( object sender, EventArgs e )
        {
            if (GetCharacter() == null)
                return;
            
            if (!ShowConfirmation("Are you sure?", "Remove Encounter"))
                return;

            charList.RemoveAt(_dataGridViewCharacters.SelectedRows[0].Index);
            
            RefreshUI();
        }

        private bool ShowConfirmation( string message, string title )
        {
            return (MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        private void RefreshUI()
        {
            try
            {
                characterBindingSource.DataSource = charList.ToList();           
            } catch (Exception)
            {
                MessageBox.Show("Error loading characters");
            }           
        }

        private List<Character> charList = new List<Character>();

        private void OnEncounterRun( object sender, EventArgs e )
        {
            if (!ShowConfirmation("You must save before running an encounter, save now?", "Save Encounter"))
                return;

            var encounter = SaveEncounter();
            Encounter = encounter;

            var form = new RunEncounterForm( encounter.Characters, encounter.Name);     

            //Show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            Encounter = form.Encounter;           
        }

        private void OnCancel( object sender, EventArgs e )
        {
            if (Encounter != null)
                DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCopy( object sender, EventArgs e )
        {
            var existing = GetCharacter();
            if (existing == null)
                return;

            var chrc = new Character()
            {
                Name = existing.Name
            };

            charList.Add(chrc);
            RefreshUI();
        }
    }
}
