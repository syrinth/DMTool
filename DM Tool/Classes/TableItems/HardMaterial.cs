using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes
{
    public class HardMaterial : DatabaseClass
    {
        public HardMaterial()
        {
        }

        public HardMaterial(string name, int minValue, int maxValue, int ratio)
        {
            this.name = name;
            this.minValueMod = minValue;
            this.maxValueMod = maxValue;
            this.ratio = ratio;
        }

        public HardMaterial(List<string> readItems)
        {
            int i = 0;
            this.name = readItems[i++];
            this.minValueMod = Convert.ToInt32(readItems[i++]);
            this.maxValueMod = Convert.ToInt32(readItems[i++]);

            this.ratio = Convert.ToInt32(readItems[i++]);
        }

        public List<string> GetStrings()
        {
            List<string> stringRep = new List<string>();

            stringRep.Add(name);
            stringRep.Add(minValueMod.ToString());
            stringRep.Add(maxValueMod.ToString());
            stringRep.Add(ratio.ToString());

            return stringRep;
        }

        public string name;
        public int minValueMod;
        public int maxValueMod;
        public int ratio;
    }
}
