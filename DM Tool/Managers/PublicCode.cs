using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace DM_Tool.Controls
{
    public static class PublicCode
    {
        public static int ConvertToIntSafely(string val)
        {
            int rv = 0;

            if (!int.TryParse(val, NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out rv))
            {
                rv = 0;
            }

            return rv;
        }
    }
}
