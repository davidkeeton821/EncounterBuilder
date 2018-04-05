using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterBuilder.Data
{
    public interface IEncounterBuilderDatabase
    {
        Encounter Add( Encounter encounter);
        Encounter Update( Encounter encounter);
        IEnumerable<Encounter> GetAll();
        void Remove( int id );
    }
}
