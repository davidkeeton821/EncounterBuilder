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
        public LoadEncounterForm(IEncounterBuilderDatabase database)
        {          
            _source = database;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            IEnumerable<Encounter> encounters = _source.GetAll();;
            //try
            //{
                //enumDatabase = 
                encounterBindingSource.DataSource = encounters.ToList();
            //}
            //catch (Exception ex)
            //{
               // MessageBox.Show("Error loading encounters");
                //return;
            //}
        }

        public LoadEncounterForm()
        {
            InitializeComponent();
        }

        private IEncounterBuilderDatabase _source {get; set;}

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
