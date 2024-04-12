using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SuffixDateTimeDecorator : Decorator
    {
        public SuffixDateTimeDecorator(DateTime child) : base(child)
        {
        }

        public override string GetDateTime()
        {
            return new StringBuilder().Append(child.GetDateTime()).Append("kin").ToString();
        }
    }
}
