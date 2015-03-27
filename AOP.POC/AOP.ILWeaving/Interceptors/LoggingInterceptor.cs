using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;


namespace AOP.ILWeaving.Interceptors
{
    [Serializable]
    public class LoggingInterceptor:OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
            Console.WriteLine(string.Format("Before Method Entry {0}", args.Arguments[0]));
        }
    }
}
