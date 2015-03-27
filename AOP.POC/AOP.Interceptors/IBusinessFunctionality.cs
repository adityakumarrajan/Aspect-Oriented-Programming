using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Interceptors
{
    public interface IBusinessFunctionality
    {
        void CoreFunctionality001(string message);
        int CoreFunctionality002(int num1, int num2);
    }
}
