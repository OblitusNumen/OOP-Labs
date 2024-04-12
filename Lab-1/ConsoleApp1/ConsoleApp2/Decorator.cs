using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Decorator : DateTime
    {
        protected readonly DateTime child;

        protected Decorator(DateTime child)
        {
            this.child = child;
        }

        public abstract string GetDateTime();
    }
}
