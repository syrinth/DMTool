﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes
{
    public class Character
    {
        public string _name;
        public bool _campaignSpecific = false;
        public CharacterSheet _characterSheet;
        public List<string> _skills;

        public Character()
        {
        }

        public Character(string[] charSheetVals, bool campaignSpecific, List<string> skills)
        {
            _characterSheet = new CharacterSheet(charSheetVals);
            _skills = skills;
            _name = _characterSheet.name;
            _campaignSpecific = campaignSpecific;
        }

        public CharacterSheet GetCharacterSheet()
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
