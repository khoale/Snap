﻿//using System;
//using System.Reflection;
//using Castle.Core.Interceptor;
//using LinFu.IoC;
//using LinFu.IoC.Configuration;
//using Snap.LinFu;

//namespace Snap.Sample
//{
//    public static class SampleLinFuAopConfig
//    {
//        public readonly static ServiceContainer _container;
//        static SampleLinFuAopConfig()
//        {
//            _container = new ServiceContainer();
//            _container.LoadFrom(AppDomain.CurrentDomain.BaseDirectory, "*.dll");

//            SnapConfiguration.For(new LinFuAspectContainer(_container)).Configure(c =>
//            {
//                c.IncludeNamespace("Snapp*");
//                c.Bind<SampleInterceptor>().To<SampleAttribute>();
//            });
//        }

//        public static void Intercept()
//        {
//            var instance = _container.GetService<ISampleClass>();
//            instance.Run();
//        }
//    }


//    public interface ISampleClass
//    {
//        void Run();
//    }

//    [Implements(typeof(ISampleClass))]  // Attribute for LinFu configuration
//    public class SampleClass : ISampleClass
//    {
//        [Sample] // Don't forget your attribute!
//        public void Run()
//        {
//            Console.WriteLine("inside the method");
//        }
//    }

//    public class SampleInterceptor : MethodInterceptor
//    {
//        public override void BeforeInvocation()
//        {
//            Console.WriteLine("this is executed before your method");
//            base.BeforeInvocation();
//        }

//        public override void InterceptMethod(IInvocation invocation, MethodBase method, Attribute attribute)
//        {
//            // Just keep running for this demo.  
//            invocation.Proceed(); // the underlying method call
//        }

//        public override void AfterInvocation()
//        {
//            Console.WriteLine("this is executed after your method");
//            base.AfterInvocation();
//        }
//    }

//    public class SampleAttribute : MethodInterceptAttribute
//    { }
//}
