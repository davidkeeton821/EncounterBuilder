using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterBuilder
{
    public class Character
    {
        public int Id { get; set; }

        #region General Info
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        /// <summary>Gets or sets the class.</summary>
        public string Class
        {
            get { return _class ?? ""; }
            set { _class = value; }
        }

        /// <summary>Gets or sets the character race.</summary>
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }
        /// <summary>Gets or sets the exp value.</summary>
        public int Exp { get; set; }
        /// <summary>Gets or sets the character level.</summary>
        public int Level { get; set; }
        ///<summary> Gets or sets true if HP is fixed or false if HP is random</summary>
        public bool IsFixed { get; set; }
        /// <summary>Gets or sets the HP value.</summary>
        public int FixedHP { get; set; }
        /// <summary>Gets or sets the THP value.</summary>
        public int FixedTHP { get; set; }
        /// <summary>Formula string to generate random HP value.</summary>
        public string RandomFormulaHP { get; set; }
        /// <summary>Formula string to generate random THP value.</summary>
        public string RandomFormulaTHP { get; set; }
        /// <summary>Gets or sets the AC value.</summary>
        public int AC {get; set; }
        /// <summary>Gets or sets the speed value.</summary>
        public int Speed {get; set; }
        /// <summary>Gets or sets the proficiency bonus.</summary>
        public int ProfBonus {get; set; }
        /// <summary>Gets or sets the raw strength stat.</summary>
        public int StrRaw {get; set; }
        /// <summary>Gets or sets the raw dexterity stat.</summary>
        public int DexRaw {get; set; }
        /// <summary>Gets or sets the raw consitution stat.</summary>
        public int ConRaw {get; set; }
        /// <summary>Gets or sets the raw intelligence stat.</summary>
        public int IntRaw {get; set; }
        /// <summary>Gets or sets the raw wisdom stat.</summary>
        public int WisRaw {get; set; }
        /// <summary>Gets or sets the raw charisma stat.</summary>
        public int ChrRaw {get; set; }
        #endregion

        #region Proficiencies
        /// <summary>Gets or sets true of false for proficiency in Strength Saving throws.</summary>
        public int StrSvThrwProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in Dexterity saving throws.</summary>
        public int DexSvThrwProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in Constitution saving throw.</summary>
        public int ConSvThrwProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in Intelligence saving throws.</summary>
        public int IntSvThrwProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in Wisdom saving throws.</summary>
        public int WisSvThrwProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in Charisma saving throws.</summary>
        public int ChrSvThrwProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Acrobatics skill.</summary>
        public int AcrobaticsProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Animal Handling skill.</summary>
        public int AnimalHandlingProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Arcana skill.</summary>
        public int ArcanaProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Deception skill.</summary>
        public int DecpetionProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the History skill.</summary>
        public int HistoryProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Insight skill.</summary>
        public int InsightProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Intimidation skill.</summary>
        public int IntimidationProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Investigation skill.</summary>
        public int InvestigationProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Medicine skill.</summary>
        public int MedicineProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Nature skill.</summary>
        public int NatureProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Perception skill.</summary>
        public int PerceptionProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Performance skill.</summary>
        public int PerformanceProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Persuasion skill.</summary>
        public int PersuasionProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Religion skill.</summary>
        public int ReligionProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Slight of Hand skill.</summary>
        public int SleightOfHandProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Stealth skill.</summary>
        public int StealthProf { get; set; }
        /// <summary>Gets or sets true of false for proficiency in the Survival skill.</summary>
        public int SurvivalProf { get; set; }
        #endregion

        //#region Random HP/THP Properties
        ///// <summary>Gets or sets the number of dice for a random HP value.</summary>
        //public int NumOfDiceHP { get; set; }
        ///// <summary>Gets or sets the number of dice for a random THP value.</summary>
        //public int NumOfDiceTHP { get; set; }
        ///// <summary>Gets or sets the size of dice used for a random HP value.</summary>
        //public int DieSizeHP { get; set; }
        ///// <summary>Gets or sets the size of dice used for a random THP value.</summary>
        //public int DieSizeTHP { get; set; }
        ///// <summary>Gets or sets the char for keeping highest or lowest number of dice for a random HP value.</summary>
        //public char KeepOrLowestHP { get; set; }
        ///// <summary>Gets or sets the char for keeping highest or lowest number of dice for a random THP value.</summary>
        //public char KeepOrLowestTHP { get; set; }
        ///// <summary>Gets or sets the number of dice kept for a random HP value.</summary>
        //public int KeepOrLowestNumHP { get; set; }
        ///// <summary>Gets or sets the number of dice kept for a random THP value.</summary>
        //public int KeepOrLowestNumTHP { get; set; }
        ///// <summary>Gets or sets the sign for the mod for a random HP value.</summary>
        //public char ModPlusOrMinusHP { get; set; }
        ///// <summary>Gets or sets the sign for the mod a random THP value.</summary>
        //public char ModPlusOrMinusTHP { get; set; }
        ///// <summary>Gets or sets the mod value for a random HP value.</summary>
        //public int ModHP { get; set; }
        ///// <summary>Gets or sets the mod value for a random THP value.</summary>
        //public int ModTHP { get; set; }
        //#endregion

        private string _name;
        private string _class;
        private string _race;
    }
}