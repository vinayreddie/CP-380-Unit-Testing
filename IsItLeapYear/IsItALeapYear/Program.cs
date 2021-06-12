using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItALeapYear
{
   public class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            IsItLeapYear obj = new IsItLeapYear();
            var rslt = obj.IsItLeapYearCehck(y);
        }

        public class IsItLeapYear
        {
            public bool IsItLeapYearCehck(int LeapYear)
            {
                bool result = false;
                try
                {
                    if (((LeapYear % 4 == 0) && (LeapYear % 100 != 0)) || (LeapYear % 400 == 0))
                    {
                        //Console.WriteLine("{0} is a Leap Year.", LeapYear);
                        result = true;
                        return result;
                    }
                    else
                    {
                        result = false;
                        return result;
                    }

                }
                catch (Exception ex)
                {
                    return result;
                }
            }
        }

    }
}
