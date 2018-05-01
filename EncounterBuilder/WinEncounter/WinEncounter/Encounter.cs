using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterBuilder
{
    public class Encounter
    {
        public Encounter () { }
        public Encounter(Encounter encounter)
        {
            Id = encounter.Id;
            foreach (var chrc in encounter.Characters)
            {
                Characters.Add(new Character(chrc));
            }
            Name = encounter.Name;
            Description = encounter.Description;
            LastEdit = encounter.LastEdit;
        }

        public int Id { get; set; }
        public List<Character> Characters
        {
            get
            {
                return _characters;
            }
            set
            {
                _characters.Clear();
                foreach (var chrc in value)
                {
                    _characters.Add(chrc);
                }
            }
        }

        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            //Accessors
            get { return _name ?? ""; }
            set { _name = value; }
        }

        /// <summary>Gets or sets the Description.</summary>
        public string Description
        {
            get {return _description ?? ""; }
            set { _description = value; }
        }

        public DateTime LastEdit { get; set; }

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
        private List<Character> _characters = new List<Character>();
    }
}
