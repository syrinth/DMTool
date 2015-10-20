using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DM_Tool.Classes;

namespace DM_Tool
{
    public class CreatureType : DatabaseClass
    {
        public CreatureType()
        {
        }

        public CreatureType(string name, int bab, string hitDie, int fort, int reflex, int will, string skillPoints, string traits)
        {
            this._name = name;
            this._baseAttackBonus = bab;
            this._hitDieSize = Convert.ToInt32(hitDie);
            this._fortSave = fort;
            this._refSave = reflex;
            this._willSave = will;
            this._skillPoints = Convert.ToInt32(skillPoints);
            this._traits = traits;
        }

        public CreatureType(List<string> readItems)
        {
            int i = 0;
            this._name = readItems[i++];
            this._baseAttackBonus = Convert.ToInt32(readItems[i++]);
            this._hitDieSize = Convert.ToInt32(readItems[i++]);
            this._fortSave = Convert.ToInt32(readItems[i++]);
            this._refSave = Convert.ToInt32(readItems[i++]);
            this._willSave = Convert.ToInt32(readItems[i++]);
            this._skillPoints = Convert.ToInt32(readItems[i++]);
            this._traits = readItems[i++];
        }

        public List<string> GetStrings()
        {
            List<string> stringRep = new List<string>();

            stringRep.Add(_name);
            stringRep.Add(_baseAttackBonus.ToString());
            stringRep.Add(_hitDieSize.ToString());
            stringRep.Add(_fortSave.ToString());
            stringRep.Add(_refSave.ToString());
            stringRep.Add(_willSave.ToString());
            stringRep.Add(_skillPoints.ToString());;
            stringRep.Add(_traits);

            return stringRep;
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _hitDieSize;
        public int hitDieSize
        {
            get { return _hitDieSize; }
            set { _hitDieSize = value; }
        }

        private int _baseAttackBonus;
        public int baseAttackBonus
        {
            get { return _baseAttackBonus; }
            set { _baseAttackBonus = value; }
        }

        private int _fortSave;
        public int fortSave
        {
            get { return _fortSave; }
            set { _fortSave = value; }
        }

        private int _refSave;
        public int refSave
        {
            get { return _refSave; }
            set { _refSave = value; }
        }

        private int _willSave;
        public int willSave
        {
            get { return _willSave; }
            set { _willSave = value; }
        }

        private int _skillPoints;
        public int skillPoints
        {
            get { return _skillPoints; }
            set { _skillPoints = value; }
        }

        private string _traits;

        public string traits
        {
            get { return _traits; }
            set { _traits = value; }
        }
    }
}
