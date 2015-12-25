using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes
{
    public class Character
    {
        public string _name;
        public bool _campaignSpecific = false;
        public StatBlock _characterSheet;
        public List<string> _skills;
        public List<List<string>> _spells;
        public List<string> _equipment;

        public Character()
        {
        }

        public Character(string[] charSheetVals, bool campaignSpecific, List<string> skills, List<List<string>> spells, List<string> equipment)
        {
            _characterSheet = new StatBlock(charSheetVals);
            _skills = skills;
            _name = _characterSheet.name;
            _campaignSpecific = campaignSpecific;
            _spells = spells;
            _equipment = equipment;
        }

        public StatBlock GetCharacterSheet()
        {
            return _characterSheet;
        }

        public List<string> GetSkills()
        {
            return _skills;
        }

        public string GetName()
        {
            if (_name == null) return string.Empty;
            return _name;
        }
    }
}
