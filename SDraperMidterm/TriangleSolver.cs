using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDraperMidterm
{
    public static class TriangleSolver
    {
        public static string Analyze(int firstLength, int secondLength, int thirdLength)
        {
            bool valid = true;
            string validString="";
            if ((firstLength + secondLength > thirdLength) && (firstLength + thirdLength > secondLength) && (secondLength + thirdLength > firstLength))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }


            if(valid)
            {
                if(firstLength == secondLength && firstLength == thirdLength)
                {
                    validString = "equilateral";
                }
                else if(firstLength == secondLength || firstLength == thirdLength || secondLength == thirdLength)
                {
                    validString = "isosceles";
                }
                else
                {
                    validString = "scalene";
                }
            }
            else
            {
                validString = "invalid";
            }

            return validString;
        }
    }
}
