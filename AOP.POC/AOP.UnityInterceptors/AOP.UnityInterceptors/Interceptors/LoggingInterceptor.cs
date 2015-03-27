using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace AOP.UnityInterceptors.Interceptors
{
    /// <summary>
    /// This is my logging Interceptor.
    /// </summary>
    public class LoggingInterceptor:ICallHandler
    {

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            Console.WriteLine("STARTING: INSIDE LOGGING INTERCEPTOR");
            IMethodReturn objMethodReturn = getNext()(input, getNext);
            Console.WriteLine("DONE: DONE WITH LOGGIN INTERCEPTOR");
            return null;
        }

        public int Order { get; set; }
        
    }
}
