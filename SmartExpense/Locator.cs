using System;
using System.Collections.Generic;

namespace SmartExpense
{
    // class to combine services. 
    public static class Locator
    {
        private static readonly Dictionary<Type, object> Services = new Dictionary<Type, object>();
        
        // getting service by it's type.
        public static T GetService<T>()
        {
            return (T)Services[typeof(T)];
        }
        
        // bind service to locator.
        public static void Register<T>(T service)
        {
            Services[typeof(T)] = service;
        }
        
        // clear locator.
        public static void Reset()
        {
            Services.Clear();
        }
    }
}