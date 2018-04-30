﻿using System;
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
            pictureBox1.Image = SystemIcons.Question.ToBitmap();
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
                SetFixed(true);
                SetRandom(false);              
            }

            //Random dice, disable fixed health stats
            if (_radioRandom.Checked)
            {
                _radioFixed.Checked = false;
                SetFixed(false);
                SetRandom(true);
            }
        }

        private void SetRandom(bool status)
        {
            _textNumOfDiceHP.Enabled = status;
            _textNumOfDiceTHP.Enabled = status;
            _textDieSizeHP.Enabled = status;
            _textDieSizeTHP.Enabled = status;
            _textModNumHP.Enabled = status;
            _textModNumTHP.Enabled = status;
            _textDisplayHPFormula.Enabled = status;
            _textDisplayTHPFormula.Enabled = status;
        }

        private void SetFixed(bool status)
        {
            _textFixedHP.Enabled = status;
            _textFixedTHP.Enabled = status;
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
                //Class = 
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
                return $"{value}";                     
        }

        private void OnRawStatFocus( object sender, EventArgs e )
        {
            HideMask(sender,e);           
        }

        private void OnRawStatFocusLeave( object sender, EventArgs e )
        {
            ShowMask(sender, e);
        }

        private void HideMask( object sender, EventArgs e )
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Equals("RAW"))
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                textBox.ForeColor = Color.Black;
                textBox.Text = "";
            }
        }

        private void ShowMask (object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text == "")
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Italic);
                textBox.ForeColor = Color.Gray;
                textBox.Text = "RAW";
            }
        }
    }
}
