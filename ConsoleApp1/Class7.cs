using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class7
    {
        enum Months
        {
            January,
            February,
            March=4,
            April,
            May,
            June,
            July,
            january


        }

        static void Main(string[] args)
        {
            int myNum = (int)Months.January;
            Console.WriteLine(myNum);

            try
            {

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
