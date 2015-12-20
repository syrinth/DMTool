using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes
{
    public class Calendar
    {
        public string _time;
        public string _yearName;
        public int _currYear;
        public List<Month> _totalMonths;
        public string _currMonth;
        public int _currDay;
        public string _currDayOfWeek;
        public List<string> _daysOfWeek;

        public Calendar(){
            _totalMonths = new List<Month>();
            _daysOfWeek = new List<string>();
        }

        public void AddMonth(string name, int days)
        {
            _totalMonths.Add(new Month(name, days));
        }

        public void ClearMonths()
        {
            _totalMonths.Clear();
        }

        public void GoToNextMonth()
        {
            int index = GetMonthNames().FindIndex(x => x.Equals(_currMonth));
            index++;
            if (index < _totalMonths.Count)
            {
                _currMonth = _totalMonths[index].GetName();
            }
            else if (index >= _totalMonths.Count)
            {
                _currMonth = _totalMonths[0].GetName();
                _currYear++;
            }
        }

        public void GoToNextDayOfWeek()
        {
            foreach (string s in _daysOfWeek)
            {
                if (s == _currDayOfWeek)
                {
                    int i = _daysOfWeek.IndexOf(s) +1;

                    if (i < _daysOfWeek.Count)
                    {
                        _currDayOfWeek = _daysOfWeek[i];
                    }
                    else
                    {
                        _currDayOfWeek = _daysOfWeek[0];
                    }
                    break;
                }
            }
        }

        public int GetMonthDays(string name)
        {
            foreach (Month m in _totalMonths)
            {
                if (m.GetName().Equals(name))
                {
                    return m.GetNumDays();
                }
            }
            return 0;
        }

        public List<String> GetMonthNames()
        {
            List<String> monthNames = new List<String>();
            foreach (Month m in _totalMonths)
            {
                monthNames.Add(m.GetName());
            }

            return monthNames;
        }

        public void SetYearName(string val)
        {
            _yearName = val;
        }

        public string GetYearName()
        {
            return _yearName;
        }

        public void SetCurrentYear(int val)
        {
            _currYear = val;
        }

        public int GetCurrentYear()
        {
            return _currYear;
        }

        public void SetCurrentDay(int val)
        {
            _currDay = val;
        }

        public int GetCurrentDay()
        {
            return _currDay;
        }

        public void SetCurrentMonth(string val)
        {
            _currMonth = val;
        }

        public string GetCurrentMonth()
        {
            return _currMonth;
        }

        public void SetTime(string val)
        {
            _time = val;
        }

        public string GetTime()
        {
            return _time;
        }

        public void SetCurrentDayOfWeek(string val)
        {
            _currDayOfWeek = val;
        }

        public string GetCurrentDayOfWeek()
        {
            return _currDayOfWeek;
        }

        public void SetDaysOfWeek(string[] val)
        {
            _daysOfWeek.Clear();
            foreach (string s in val)
            {
                string temp = s;
                if (s.Contains("{"))
                {
                    temp = s.Trim(new char[] { '{', '}' });
                    _currDayOfWeek = temp;
                }
                _daysOfWeek.Add(temp);
            }
        }

        public List<string> GetDaysOfWeek()
        {
            return _daysOfWeek;
        }

        public string PrintDaysOfWeek()
        {
            string val = string.Empty;
            foreach (string s in _daysOfWeek)
            {
                if (_currDayOfWeek == s)
                {
                    val = val + "{" + s + "}, ";
                }
                else
                {
                    val = val + s + ", ";
                }
            }

            return val.Trim(new char[] {',', ' '});
        }

        public class Month
        {
            public string _name;
            public int _numDays;

            public Month()
            {
                _name = string.Empty;
                _numDays = 0;
            }
            public Month(string name, int days) {
                _name = name;
                _numDays = days;
            }

            public int GetNumDays()
            {
                return _numDays;
            }

            public string GetName()
            {
                return _name;
            }

            public void SetNumDays(int val){
                _numDays = val;
            }

            public void SetName(string val)
            {
                _name = val;
            }
        }

        public class Day
        {
            public Day(){}
        }
    }
}
