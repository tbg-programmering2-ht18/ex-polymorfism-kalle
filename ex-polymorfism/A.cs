using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_polymorfism
{
    class A
    {
        public string Description()
        {
            return "the object is of type A";
        }
    }

    class B : A
    {
        public new string Description()
        {
            return "the object is of type B";
        }
    }
}
