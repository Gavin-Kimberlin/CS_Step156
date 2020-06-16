using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step156
{
    class Class1
    {
        public static int Method(int input1, int input2 = 0)
        {
            int output = (input1 + input2) * 4;
            return output;
        }

    }
}
