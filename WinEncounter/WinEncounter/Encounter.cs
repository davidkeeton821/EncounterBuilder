﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinEncounter
{
    public class Encounter
    {
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            //Accessors
            get { return _name ?? ""; }
            set { _name = value; }
        }

        /// <summary>Validates the product.</summary>
        /// <returns>Error message, if any</returns>
        public string Validate()
        {
            //Name is requried
            if (String.IsNullOrEmpty(_name))
                return "Name cannot be empty";

            return "";
        }

        private string _name;
        private string _description;
    }
}