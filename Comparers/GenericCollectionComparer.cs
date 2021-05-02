using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectComparer;
namespace ObjectComparer.Comparers
{
    class GenericCollectionComparer:IComparer
    {

        public bool Compare(object a, object b)
        {
            IEnumerable listA= a as IEnumerable;
            IEnumerable listB = b as IEnumerable;

           
            if (listA == null || listB == null) return listA == listB;

            List<object> a1 = listA.Cast<object>().ToList();
            List<object> a2 = listB.Cast<Object>().ToList();

            if (a1 == null || a2 == null) return a1 == a2;
            if (a1.Count != a2.Count) return false;

            a1.Sort();
            a2.Sort();

            for (int i = 0; i < a1.Count; i++)
            {
                var match = ObjComparer.Compare(a1[i], a2[i]);
                if (!match) return false;
            }
            return true;
        }
    }
}
