using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.ILWeaving;

namespace AOP.ILWeaving
{
    class Program
    {
        static void Main(string[] args)
        {
            IBusinessFunctionality businessFunctionality = new BusinessFunctionality();
            businessFunctionality.CoreFunctionality001("**argument**");
            var result= businessFunctionality.CoreFunctionality002(2, 3);
            Console.ReadLine();
        }
    }
}
