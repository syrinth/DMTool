using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes
{
    public class BaseItem : DatabaseClass
    {
        public BaseItem()
        {
        }

        public BaseItem(string name, int minValue, int maxValue, int weight, int ratio)
        {
            this.name = name;
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.weight = weight;
            this.ratio = ratio;
        }

        public BaseItem(List<string> readItems)
        {
            int i = 0;
            this.name = readItems[i++];
            this.minValue = Convert.ToInt32(readItems[i++]);
            this.maxValue = Convert.ToInt32(readItems[i++]);
            this.weight = Convert.ToInt32(readItems[i++]);
            this.ratio = Convert.ToInt32(readItems[i++]);
        }

        public List<string> GetStrings()
        {
            List<string> stringRep = new List<string>();

            stringRep.Add(name);
            stringRep.Add(minValue.ToString());
            stringRep.Add(maxValue.ToString());
            stringRep.Add(weight.ToString());
            stringRep.Add(ratio.ToString());

            return stringRep;
        }

        public string name;
        public int minValue;
        public int maxValue;
        public int weight;
        public int ratio;
    }
}
