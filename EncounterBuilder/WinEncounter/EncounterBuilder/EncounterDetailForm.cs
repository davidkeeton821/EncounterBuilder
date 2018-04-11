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
            //Create Encounter
            var encounter = new Encounter
            {
                Name = _textName.Text,
                Description = _textDescription.Text,
                LastEdit = DateTime.Now,
                Characters = charList
            };

            //return from form
            Encounter = encounter;
            DialogResult = DialogResult.OK;
            Close();
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
            var form = new CharacterDetailForm
            {
                Text = "Edit Character",
                Character = existing
            };

            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //Update the Character
            CopyCharacter(existing, form.Character);

            RefreshUI();
        }

        private void CopyCharacter( Character existing, Character newChar )
        {
            var index = charList.IndexOf(existing);

            charList.ElementAt(index).Name = newChar.Name;
        }

        private void OnCharacterDelete( object sender, EventArgs e )
        {
            RefreshUI();
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
    }
}
