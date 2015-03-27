using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace AOP.Interceptors.Interceptors
{
    public class CacheInterceptor:IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("****BeforeStart check the cache****");
            invocation.Proceed();
            Console.WriteLine(string.Format("After Method Execution add to cache"));
        }
    }
}
