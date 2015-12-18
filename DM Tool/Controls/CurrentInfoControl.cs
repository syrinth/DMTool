using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DM_Tool.Classes;

namespace DM_Tool.Controls
{
    public partial class CurrentInfoControl : UserControl
    {
        public PublicManager mgr = PublicManager.GetInstance();
        private TabPage _parent;
        public Calendar _calendar;

        public CurrentInfoControl()
        {
            InitializeComponent();
        }

        public CurrentInfoControl(TabPage page)
        {
            InitializeComponent();
            _parent = page;
            _calendar = mgr.GetCalendar();

            tbCurrentDate.Text = _calendar.GetCurrentMonth() + " " + _calendar.GetCurrentDay() + ", " + _calendar.GetCurrentYear() + " " + _calendar.GetYearName();
            dtpTime.Text = _calendar.GetTime();
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
           // dtpTime.
        }

        private string[] ParseDate()
        {
            return tbCurrentDate.Text.Split(new Char[] { ',', ' ' });
        }

        private void tbCurrentDate_Leave(object sender, EventArgs e)
        {
            string[] date = ParseDate();
            int maxDays = _calendar.GetMonthDays(date[0]);
            if (date.Length == 4)
            {
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

                    tbCurrentDate.Text = date[0] + " " + date[1] + ", " + date[3] + " " + _calendar.GetYearName();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string[] date = ParseDate();
            int maxDays = _calendar.GetMonthDays(date[0]);
            int currDay = PublicCode.ConvertToIntSafely(date[1]) + 1;

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
            dtpTime.Text = "08:00 AM";
            tbCurrentDate.Text = date[0] + " " + currDay + ", " + date[3] + " " + _calendar.GetYearName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] date = ParseDate();
            _calendar.SetCurrentMonth(date[0]);
            _calendar.SetCurrentDay(PublicCode.ConvertToIntSafely(date[1]));
            _calendar.SetCurrentYear(PublicCode.ConvertToIntSafely(date[3]));

            _calendar.SetTime(dtpTime.Text);

            PublicManager.SerializeCalendarToXML();
        }
    }
}
