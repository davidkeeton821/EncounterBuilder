using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterBuilder.Data
{
    public abstract class EncounterBuilderDatabase : IEncounterBuilderDatabase
    {
        public Encounter Add( Encounter encounter )
        {
            encounter = encounter ?? throw new ArgumentNullException(nameof(encounter));
            encounter.Validate();
            var existing = GetEncounterByNameCore(encounter.Name);
            if (existing != null)
                throw new Exception("Encounter Already Exists");
            return AddCore(encounter);
        }

        public Encounter Update( Encounter encounter )
        {
            if (encounter == null)
                throw new ArgumentNullException(nameof(encounter));

            encounter.Validate();

            var existing = GetEncounterByNameCore(encounter.Name);
            if (existing != null && existing.Id != encounter.Id)
                throw new Exception("Product already exists");

            existing = existing ?? GetCore(encounter.Id);
            if (existing == null)
                throw new ArgumentException("Encounter not found", nameof(encounter));

            return UpdateCore(encounter);
        }

        public IEnumerable<Encounter> GetAll()
        {
            return GetAllCore();
        }

        public void Remove( int id )
        {          
                if (id <= 0)
                    throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0");
                RemoveCore(id);
        }

        protected abstract IEnumerable<Encounter> GetAllCore();
        protected abstract Encounter AddCore( Encounter encounter );
        protected abstract Encounter GetCore( int id );
        protected abstract Encounter UpdateCore( Encounter encounter );
        protected abstract void RemoveCore( int id );
        protected abstract Encounter GetEncounterByNameCore( string name );
    }
}
