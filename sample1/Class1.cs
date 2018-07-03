using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1
{
    class CommonCode
    {
        public bool Validate(string CustomerName)
        {
            if (CustomerName.Length == 0)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}
