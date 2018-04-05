using EncounterBuilder.Data;
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
    public partial class LoadEncounterForm : Form
    {
        public LoadEncounterForm()
        {
            InitializeComponent();
        }

        //public LoadEncounterForm(IEncounterBuilderDatabase database)
        //{
        //    InitializeComponent();
        //    _source = database;
        //}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            IEnumerable<Encounter> encounters = null;
            try
            {
                encounters = Source.GetAll();
                _dataGridViewLoadEncounter.DataSource = encounters.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading encounters");
                return;
            }
        }

        public IEncounterBuilderDatabase Source {get; set;}

        public Encounter Encounter { get; set; }

        private void OnButtonLoadClick(object sender, EventArgs e)
        {
            if (_dataGridViewLoadEncounter.SelectedRows.Count > 0)
            {
                var encounter = _dataGridViewLoadEncounter.SelectedRows[0].DataBoundItem as Encounter;
                Encounter = encounter;
            }           
        }
    }
}
