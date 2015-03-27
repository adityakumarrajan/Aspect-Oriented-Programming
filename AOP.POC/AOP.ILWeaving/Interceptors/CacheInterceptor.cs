using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using PostSharp.Extensibility;

namespace AOP.ILWeaving.Interceptors
{
    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method,TargetTypeAttributes=MulticastAttributes.Instance)]
    public class CacheInterceptor:OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
            var aa = args.Arguments.Count() != 0 ? args.Arguments[0] : string.Empty;
            Console.WriteLine(string.Format("Before Method Entry {0}",aa));
        }
    }
}
