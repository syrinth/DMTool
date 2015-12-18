using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DM_Tool.Classes;
using DM_Tool.Controls;

namespace DM_Tool
{
    public partial class CalendarControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();
        public Calendar _calendar;
        private TabPage _parentPage;

        public CalendarControl()
        {
            InitializeComponent();
        }

        public CalendarControl(TabPage parentPage)
        {
            InitializeComponent();

            _parentPage = parentPage;
            _calendar = mgr.GetCalendar();


            tbYearName.Text = _calendar.GetYearName();

            List<String> months =_calendar.GetMonthNames();
            foreach (String m in months)
            {
                tbMonthNames.Text += m + ", ";
                tbNumDays.Text += _calendar.GetMonthDays(m) + ", ";
            }

            tbMonthNames.Text = tbMonthNames.Text.Trim(new char[] {',', ' '});
            tbNumDays.Text = tbNumDays.Text.Trim(new char[] { ',', ' ' });

            tbCurrentDate.Text = _calendar.GetCurrentMonth() + " " + _calendar.GetCurrentDay() + ", " + _calendar.GetCurrentYear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] date = ParseDate();
            _calendar.SetYearName(tbYearName.Text);
            _calendar.SetCurrentMonth(date[0]);
            _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[1]));
            _calendar.SetCurrentYear(PublicCode.ConvertToIntSafely(date[3]));

            string[] months = tbMonthNames.Text.Split(new string[] { ", " }, StringSplitOptions.None);
            string[] days = tbNumDays.Text.Split(new string[] { ", " }, StringSplitOptions.None);

            int i = 0;
            _calendar.ClearMonths();
            foreach (string m in months)
            {
                if(i <= days.Length){
                    _calendar.AddMonth(months[i], PublicCode.ConvertToIntSafely(days[i]));
                }
                i++;
            }

            PublicManager.SerializeCalendarToXML();
        }

        private void btnNewMonth_Click(object sender, EventArgs e)
        {
            if (!_calendar.GetMonthNames().Contains(tbMonthNames.Text))
            {
                _calendar.AddMonth(tbMonthNames.Text, PublicCode.ConvertToIntSafely(tbNumDays.Text));
            }
        }

        private string[] ParseDate()
        {
            return tbCurrentDate.Text.Split(new Char[] {',', ' '});
        }

        private void tbCurrentDate_Leave(object sender, EventArgs e)
        {
            string[] date = ParseDate();
            int maxDays = _calendar.GetMonthDays(date[0]);

            int curr = PublicCode.ConvertToIntSafely(date[1]);

            if (curr > 0 && curr <= maxDays)
            {
                _calendar.SetCurrentDay(curr);
            }
            else
            {
                if (curr <= 0)
                {
                    date[1] = "1";
                    _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[1]));
                }
                else if (curr > maxDays)
                {
                    date[1] = maxDays.ToString();
                    _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[1]));
                }

                tbCurrentDate.Text = date[0] + " " + date[1] + ", " + date[3];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string[] date = ParseDate();
            int maxDays = _calendar.GetMonthDays(date[0]);
            if (date.Length == 4)
            {
                int currDay = PublicCode.ConvertToIntSafely(date[1])+1;

                if (currDay > 0 && currDay <= maxDays)
                {
                    _calendar.SetCurrentDay(currDay);
                }
                else
                {
                    if (currDay <= 0)
                    {
                        date[1] = "1";
                        _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[1]));
                    }
                    else if (currDay > maxDays)
                    {
                        //increment the month
                        _calendar.GoToNextMonth();
                        date[0] = _calendar.GetCurrentMonth();
                        date[3] = _calendar.GetCurrentYear().ToString();
                        currDay = 1;
                        _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[1]));
                    }
                }
                tbCurrentDate.Text = date[0] + " " + currDay + ", " + date[3];
            }
        }
    }
}
