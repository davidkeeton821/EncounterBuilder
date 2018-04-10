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

            //IEnumerable<Character> characters = null;
            //try
            //{
            //    characters = Encounter.Characters as IEnumerable<Character>;
            //    characterBindingSource.DataSource = characters.ToList();
            //} catch
            //{
            //    MessageBox.Show("Error loading characters");
            //    return;
            //}

           // _dataGridViewCharacters.ClearSelection();
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
                Characters = _characters
            };

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
                characterBindingSource.DataSource = Encounter.Characters;
            }
        }

        //private Character GetCharacter( bool edit )
        //{
        //    try
            //{

            //    var form = new CharacterDetailForm()
            //    {
                    
            //    };

            //    var button = form.Controls.Find("_btnLoad", true);
            //    if (edit)
            //    {
            //        form.Text = "Edit Encounter";
            //        button[0].Text = "Edit";
            //    } else
            //    {
            //        form.Text = "Delete Encounter";
            //        button[0].Text = "Delete";
            //    }
            //    while (true)
            //    {
            //        //Show form modally
            //        var result = form.ShowDialog(this);
            //        if (result != DialogResult.OK)
            //            return null;

            //        if (form.Encounter != null)
            //            return form.Encounter;
            //        else
            //            MessageBox.Show("No Encounter Selected");
            //    }
            //} catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return null;
            //}
        //}

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
            _characters.Add(form.Character);

            RefreshUI();
        }       

        private void OnCharacterEdit( object sender, EventArgs e )
        {
            var form = new CharacterDetailForm
            {
                Text = "Edit Character"
                //Character = getCharacter();
            };

            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //"Add" the Character
            _characters.Add(form.Character);

            RefreshUI();
        }

        private void OnCharacterDelete( object sender, EventArgs e )
        {


            RefreshUI();
        }

        private void RefreshUI()
        {
            List<Character> characters = new List<Character>();
            try
            {
                characters = _characters;            
            } catch (Exception)
            {
                MessageBox.Show("Error loading characters");
            }

            //Bind to grid
            characterBindingSource.DataSource = characters?.ToList();
        }
        private List<Character> _characters = new List<Character>();
    }
}
