using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.UnityInterceptors.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LoggingInterceptorAttribute:Attribute
    {
        //This is a sample custom attribute created to decorate all methods on which we would like to apply our interception.
    }
}
