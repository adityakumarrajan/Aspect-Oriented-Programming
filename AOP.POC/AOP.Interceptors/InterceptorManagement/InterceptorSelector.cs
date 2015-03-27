using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Interceptors.Interceptors;
using Castle.DynamicProxy;

namespace AOP.Interceptors.InterceptorManagement
{
    public class InterceptorSelector : IInterceptorSelector
    {
        /// <summary>
        /// This Piece of Code allows you to attach Interceptors to specific Method , 
        /// Property or class .i.e Caching in Required only for Classes in Reopsitory layer assembly.
        /// We can Also configure  this for each group of class/project to have there own Interceptor Selector.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="method"></param>
        /// <param name="interceptors"></param>
        /// <returns></returns>
        public IInterceptor[] SelectInterceptors(Type type, System.Reflection.MethodInfo method, IInterceptor[] interceptors)
        {
            if (method.Name == "CoreFunctionality001")
            {
                return interceptors.Where(x => x is LoggingInterceptor).ToArray();
            }
            if (method.Name == "CoreFunctionality002")
            {
                return interceptors.Where(x =>x is CacheInterceptor ).ToArray();
            }
            return null;
        }
    }
}
