using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Interceptors.InterceptorManagement;
using AOP.Interceptors.Interceptors;
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;

namespace AOP.Interceptors.IOC
{
    public class MyResolver : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            //Registering My Interceptors
            container.Register(Component.For<LoggingInterceptor>().ImplementedBy<LoggingInterceptor>());
            container.Register(Component.For<CacheInterceptor>().ImplementedBy<CacheInterceptor>());
            
            //Simple Registeration of BusinessClass
            //container.Register(Component.For<IBusinessFunctionality>().ImplementedBy<BusinessFunctionality>());

            //Adding Logging Interceptor
            //container.Register(Component.For<IBusinessFunctionality>().ImplementedBy<BusinessFunctionality>()
            //.Interceptors(InterceptorReference.ForType<LoggingInterceptor>()).Anywhere);
            
            //Adding Mutiple Interceptors and deciding the sequence.
            //container.Register(Component.For<IBusinessFunctionality>().ImplementedBy<BusinessFunctionality>()
            //    .Interceptors(InterceptorReference.ForType<CacheInterceptor>()).First
            //    .Interceptors(InterceptorReference.ForType<LoggingInterceptor>()).Last);

            container.Register(
                    Component.For<IBusinessFunctionality>()
                    .ImplementedBy<BusinessFunctionality>()
                    .Interceptors(InterceptorReference.ForType<CacheInterceptor>()).SelectedWith(new InterceptorSelector()).Anywhere
                    .Interceptors(InterceptorReference.ForType<LoggingInterceptor>()).SelectedWith(new InterceptorSelector()).Anywhere);
            
        }
    }
}
