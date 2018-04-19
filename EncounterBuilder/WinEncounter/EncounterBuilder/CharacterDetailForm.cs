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
    public partial class CharacterDetailForm : Form
    {
        public CharacterDetailForm()
        {
            InitializeComponent();
        }

        public CharacterDetailForm(Character character)
        {
            InitializeComponent();

            Text = "Edit Character";
            _textName.Text = character.Name;
        }
        //protected override void OnLoad( EventArgs e )
        //{
        //    base.OnLoad(e);
        //}

        public Character Character { get; set; }

        private void OnCheckedChange( object sender, EventArgs e )
        {
            //TODO: implement on load, including UpdateUI() 
            UpdateUI(sender, e);
        }

        private void UpdateUI (object sender, EventArgs e)
        {            
            //Fixed health, disable random health stats
            if (_radioFixed.Checked)
            {
                _radioRandom.Checked = false;
                _textFixedHP.Enabled = true;
                _textFixedTHP.Enabled = true;

                _textNumOfDiceHP.Enabled = false;
                _textNumOfDiceTHP.Enabled = false;
                _textDieSizeHP.Enabled = false;
                _textDieSizeTHP.Enabled = false;
                _listBoxKeepLowHP.Enabled = false;
                _listBoxKeepLowTHP.Enabled = false;
                _textNumOfKeepLowHP.Enabled = false;
                _textNumOfKeepLowTHP.Enabled = false;
                _listBoxPlusMinusHP.Enabled = false;
                _listBoxPlusMinusTHP.Enabled = false;
                _textModNumHP.Enabled = false;
                _textModNumTHP.Enabled = false;
            }

            //Random dice, disable fixed health stats
            if (_radioRandom.Checked)
            {
                _radioFixed.Checked = false;
                _textFixedHP.Enabled = false;
                _textFixedTHP.Enabled = false;

                _textNumOfDiceHP.Enabled = true;
                _textNumOfDiceTHP.Enabled = true;
                _textDieSizeHP.Enabled = true;
                _textDieSizeTHP.Enabled = true;
                _listBoxKeepLowHP.Enabled = true;
                _listBoxKeepLowTHP.Enabled = true;
                _textNumOfKeepLowHP.Enabled = true;
                _textNumOfKeepLowTHP.Enabled = true;
                _listBoxPlusMinusHP.Enabled = true;
                _listBoxPlusMinusTHP.Enabled = true;
                _textModNumHP.Enabled = true;
                _textModNumTHP.Enabled = true;
            }
        }

        private void OncheckStrSvThrwProfChecked(object sender, EventArgs e)
        {
            //Character.StrSvThrwProf = true;
            //_checkStrSvThrwProf.Checked = true;
        }

        private void OnSave(object sender, EventArgs e)
        {
            //Create Encounter
            var character = new Character
            {
                Name = _textName.Text,   
            };

            //return from form
            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnRawStrValueEntered(object sender, EventArgs e)
        {
            var result = Int32.TryParse(_textStrRaw.Text, out int value);
            if (result)
                _textStrMod.Text = CalculateMod(value);
            else
                _textStrMod.Text = "";          
        }
        private void OnRawDexValueEntered( object sender, EventArgs e )
        {
            var result = Int32.TryParse(_textDexRaw.Text, out int value);
            if (result)
                _textDexMod.Text = CalculateMod(value);
            else
                _textDexMod.Text = "";
        }


        private void OnRawConValueEntered( object sender, EventArgs e )
        {
            var result = Int32.TryParse(_textConRaw.Text, out int value);
            if (result)
                _textConMod.Text = CalculateMod(value);
            else
                _textConMod.Text = "";
        }

        private void OnRawIntValueEntered( object sender, EventArgs e )
        {
            var result = Int32.TryParse(_textIntRaw.Text, out int value);
            if (result)
                _textIntMod.Text = CalculateMod(value);
            else
                _textIntMod.Text = "";
        }

        private void OnRawWisValueEntered( object sender, EventArgs e )
        {
            var result = Int32.TryParse(_textWisRaw.Text, out int value);
            if (result)
                _textWisMod.Text = CalculateMod(value);
            else
                _textWisMod.Text = "";
        }

        private void OnRawChrValueEntered( object sender, EventArgs e )
        {
            var result = Int32.TryParse(_textChrRaw.Text, out int value);
            if (result)
                _textChrMod.Text = CalculateMod(value);
            else
                _textChrMod.Text = "";
        }

        private string CalculateMod(int value)
        {            
            value = Convert.ToInt32(Math.Floor((value - 10) / 2.0));
            if (value >= 0)
                return $"+{value}";
            else
                return $"-{value}";                     
        }


    }
}
