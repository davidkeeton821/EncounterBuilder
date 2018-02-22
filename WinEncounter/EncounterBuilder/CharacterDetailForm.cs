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

        public Character Character { get; set; }

        private void OnCharacterLoad( object sender, EventArgs e )
        {
            //TODO: implement on load, including UpdateUI() 
            UpdateUI(sender, e);
        }

        private void UpdateUI (object sender, EventArgs e)
        {
            //TODO: Implement dynamic changes to UI
            //
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

            //Random dice, disable fixed health statistics
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
    }
}
