using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterBuilder.Data.Memory
{
    public class MemoryEncounterBuilderDatabase : EncounterBuilderDatabase
    {
        protected override Encounter AddCore( Encounter encounter )
        {
            //Clone the object
            encounter.Id = _nextId++;
            _encounters.Add(Clone(encounter));

            //return a copy
            return encounter;
        }
 
        protected override Encounter GetCore( int id )
        {
            foreach (var encounter in _encounters)
            {
                if (encounter.Id == id)
                    return encounter;
            };

            return null;
        }
        protected override IEnumerable<Encounter> GetAllCore()
        {
            foreach (var encounter in _encounters)
            {
                if (encounter != null)
                    yield return Clone(encounter);
            };

        }
        protected override void RemoveCore( int id )
        {      
                var existing = GetCore(id);
                if (existing != null)
                _encounters.Remove(existing);
        }

        protected override Encounter UpdateCore( Encounter encounter )
        {
            var existing = GetCore(encounter.Id);

            //Clone the object
            //_products[existingIndex] = Clone(product);
            Copy(existing, encounter);

            //return a copy
            return encounter;
        }

        protected override Encounter GetEncounterByNameCore( string name )
        {
            foreach (var encounter in _encounters)
            {
                //case insensitive comparison
                if (String.Compare(encounter.Name, name, true) == 0)
                    return encounter;
            };

            return null;
        }

        private Encounter Clone( Encounter encounter )
        {
            var newEncounter = new Encounter();
            Copy(newEncounter, encounter);

            return newEncounter;
        }

        private void Copy( Encounter target, Encounter source )
        {
            var newEncounter = new Encounter();
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;
            target.LastEdit = DateTime.Now;
        }
 
        private readonly List<Encounter> _encounters = new List<Encounter>();
        private int _nextId = 1;
    }
}
