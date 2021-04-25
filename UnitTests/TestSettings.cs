using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Properties;

namespace UnitTests
{
    public static class TestSettings
    {
        public static int UserNumber
        {
            get
            {
                return (int)(Settings.Default["TestUserNumber"]);
            }
            set
            {
                Settings.Default["TestUserNumber"] = value;
                Settings.Default.Save();
            }
        }

        public static int DialogNumber
        {
            get
            {
                return (int)(Settings.Default["TestDialogNumber"]);
            }
            set
            {
                Settings.Default["TestDialogNumber"] = value;
                Settings.Default.Save();
            }
        }
    }
}