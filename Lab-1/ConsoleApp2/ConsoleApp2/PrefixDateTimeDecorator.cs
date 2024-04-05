using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PrefixDateTimeDecorator : Decorator
    {
        public PrefixDateTimeDecorator(DateTime child) : base(child)
        {
        }

        public override string GetDateTime()
        {
            return new StringBuilder().Append("Ole").Append(child.GetDateTime()).ToString();
        }
    }
}
