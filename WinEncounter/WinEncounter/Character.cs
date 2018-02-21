using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterBuilder
{
    public class Character
    {
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            //Accessors
            get { return _name ?? ""; }
            set { _name = value; }
        }

        private string _name;
    }
}
