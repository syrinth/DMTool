using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes
{
    public class EncounterTable
    {
        public string _name;
        public int _percentRate = 0;
        public List<String> _encWeights;
        public List<String> _encounters;

        public EncounterTable()
        {
        }

        public EncounterTable(string name, int percent, List<string> weights, List<string> encounters)
        {
            _name = name;
            _percentRate = percent;
            _encWeights = weights;
            _encounters = encounters;
        }

        public string GetName()
        {
            if (_name == null)
            {
                return string.Empty;
            }
            return _name;
        }

        public string GetPercent()
        {
            return _percentRate.ToString();
        }

        public List<String> GetWeights()
        {
            return _encWeights;
        }

        public List<String> GetEncounters()
        {
            return _encounters;
        }
    }
}
