using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.UnityInterceptors.CustomAttributes;

namespace AOP.UnityInterceptors
{
    public interface IBusinessFunctionality
    {
        void CoreFunctionality001(string message);
        [LoggingInterceptor]
        int CoreFunctionality002(int num1, int num2);
    }
}
