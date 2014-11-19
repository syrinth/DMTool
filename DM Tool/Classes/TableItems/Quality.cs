using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DM_Tool.Classes;

namespace DM_Tool
{
    public class Quality : DatabaseClass
    {
        public string _name;
        public int _weight;
        public int _minValueMod;
        public int _maxValueMod;

        public Quality()
        {
        }
        public Quality(string name, int minValueMod, int maxValueMod, int weight)
        {
            this._name = name;
            this._weight = weight;
            this._minValueMod = minValueMod;
            this._maxValueMod = maxValueMod;
        }

        public Quality(List<string> readItems)
        {
            int i = 0;
            this._name = readItems[i++];
            this._minValueMod = Convert.ToInt32(readItems[i++]);
            this._maxValueMod = Convert.ToInt32(readItems[i++]);
            this._weight = Convert.ToInt32(readItems[i++]);
        }

        public List<string> GetStrings()
        {
            List<string> stringRep = new List<string>();

            stringRep.Add(_name);
            stringRep.Add(_minValueMod.ToString());
            stringRep.Add(_maxValueMod.ToString());
            stringRep.Add(_weight.ToString());

            return stringRep;
        }
    }
}
