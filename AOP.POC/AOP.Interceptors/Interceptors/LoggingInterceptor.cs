using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Castle.Windsor;

namespace AOP.Interceptors.Interceptors
{
    public class LoggingInterceptor:IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                Console.WriteLine("Logging before calling " + invocation.Method.Name);
                invocation.Proceed();
                Console.WriteLine("Loggin after calling " + invocation.Method.Name);
            }
            catch (Exception exp)
            {
                Console.WriteLine(string.Format("Error occured while executing {0}, exp is {1}", invocation.Method.Name, exp.Message));
            }
            finally
            {
                Console.WriteLine("On exit call");
            }
        }

    }
}
