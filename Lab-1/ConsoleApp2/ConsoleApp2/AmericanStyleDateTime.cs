using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AmericanStyleDateTime : DateTime
    {
        public string GetDateTime()
        {
            return System.DateTime.Now.ToString(new CultureInfo("us-US", false));
        }
    }
}
