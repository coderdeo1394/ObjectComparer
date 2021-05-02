using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComparer
{
    public sealed class Singleton<T> where T : class,new()

    {
    
        private static T instance = null;

        private Singleton()
        {
        }

        public static T GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }
}
