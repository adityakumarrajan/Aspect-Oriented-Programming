using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace AOP.UnityInterceptors
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer().LoadConfiguration();
            IUnityContainer container = new UnityContainer();
            container.AddNewExtension<Interception>();
            container.RegisterType<IBusinessFunctionality, BusinessFunctionality>()
                     .Configure<Interception>()
                     .SetInterceptorFor<IBusinessFunctionality>(new InterfaceInterceptor());

            // Resolve the proxy-sample
            var objBusinessFunctionality = Microsoft.Practices.Unity.UnityContainerExtensions.Resolve<IBusinessFunctionality>(container);

            var result = objBusinessFunctionality.CoreFunctionality002(2, 3);
            
            Console.ReadLine();
        }
    }
}
