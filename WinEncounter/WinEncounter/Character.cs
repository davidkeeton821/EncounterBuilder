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
            get { return _name ?? ""; }
            set { _name = value; }
        }

        public string Class
        {
            get { return _class ?? ""; }
            set { _class = value; }
        }
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        public int Exp { get; set; }
        public int Level { get; set; }
        public int FixedHP { get; set; }
        public int FixedTHP { get; set; }
        public int AC {get; set; }
        public int Speed {get; set; }
        public int ProfBonus {get; set; }
        public int StrRaw {get; set; }
        public int DexRaw {get; set; }
        public int ConRaw {get; set; }
        public int IntRaw {get; set; }
        public int WisRaw {get; set; }
        public int ChrRaw {get; set; }
        public int ChallengeRating { get; set; }

        public bool StrSvThrwProf { get; set; }
        public bool DexSvThrwProf { get; set; }
        public bool ConSvThrwProf { get; set; }
        public bool IntSvThrwProf { get; set; }
        public bool WisSvThrwProf { get; set; }
        public bool ChrSvThrwProf { get; set; }
        public bool AcrobaticsProf { get; set; }
        public bool AnimalHandlingProf { get; set; }
        public bool ArcanaProf { get; set; }
        public bool DecpetionProf { get; set; }
        public bool HistoryProf { get; set; }
        public bool InsightProf { get; set; }
        public bool IntimidationProf { get; set; }
        public bool InvestigationProf { get; set; }
        public bool MedicineProf { get; set; }
        public bool NatureProf { get; set; }
        public bool PerceptionProf { get; set; }
        public bool PerformanceProf { get; set; }
        public bool PersuasionProf { get; set; }
        public bool ReligionProf { get; set; }
        public bool SleightOfHandProf { get; set; }
        public bool StealthProf { get; set; }
        public bool SurvivalProf { get; set; }

        public int NumOfDiceHP { get; set; }
        public int NumOfDiceTHP { get; set; }
        public int DieSizeHP { get; set; }
        public int DieSizeTHP { get; set; }
        public char KeepOrLowestHP { get; set; }
        public char KeepOrLowestTHP { get; set; }
        public int KeepOrLowestNumHP { get; set; }
        public int KeepOrLowestNumTHP { get; set; }
        public char ModPlusOrMinusHP { get; set; }
        public char ModPlusOrMinusTHP { get; set; }
        public int ModHP { get; set; }
        public int ModTHP { get; set; }

        private string _name;
        private string _class;
        private string _race;
    }
}