using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retos2023._00
{
    public class BuzzFizz
    {
        public string GetLabel (int value)
        {
            if (value % 3 == 0)
            {
                return "fizz";
            }
            if (value % 5 == 0)
            {
                return "buzz";
            }
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "fizzbuzz";
            }

            return value.ToString();
        }
    }
}
