﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Interceptors
{
    public class BusinessFunctionality : IBusinessFunctionality
    {
        public void CoreFunctionality001(string message)
        {
            Console.WriteLine("*****");
            Console.WriteLine(message);
            Console.WriteLine("*****");
        }

        public int CoreFunctionality002(int num1, int num2)
        {
            Console.WriteLine(string.Format("the result is  {0}", num1 + num2));
            return num1 + num2;
        }
    }
}
