using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ObjectComparer.Comparers;

namespace ObjectComparer
{
    static class ComparerFactory
    {
        public static IComparer GetComparerInstance(Type type)
        {
            if (type.IsClass && type.GetInterface(nameof(IEnumerable)) == null)
            {
                return Singleton<ClassObjComparer>.GetInstance;

            }
            else if (type.IsValueType)
            {
                return Singleton<ValueTypeComparer>.GetInstance;

            }
            else if (type.GetInterface(nameof(IEnumerable)) != null)
            {
                return Singleton<GenericCollectionComparer>.GetInstance;
            }
            else
                return Singleton<DefaultComparer>.GetInstance;
        }
    }
}
