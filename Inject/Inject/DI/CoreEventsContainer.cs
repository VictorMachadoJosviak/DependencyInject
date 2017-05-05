﻿using System;
using System.Collections.Generic;
using Naylah.Kernel.Helpers.Contracts;
using XLabs.Ioc;

namespace Inject.DI
{
    public class CoreEventsContainer : IContainer
    {

        public object GetService(Type serviceType)
        {
            return Resolver.Resolve(serviceType);
            
        }

        public T GetService<T>()
        {
            return (T)Resolver.Resolve(typeof(T));
            
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Resolver.ResolveAll(serviceType);
            
        }

        public IEnumerable<T> GetServices<T>()
        {
            return (IEnumerable<T>)Resolver.ResolveAll(typeof(T));
            
        }
    }
}