using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace AOP.Interceptors
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var container= new WindsorContainer();
            container.Install(FromAssembly.This());
            var objBusinessFunctionality = container.Resolve<IBusinessFunctionality>();
            objBusinessFunctionality.CoreFunctionality001("Hello World");
            var result= objBusinessFunctionality.CoreFunctionality002(45,54);
            Console.ReadLine(); 
        }
    }
}
