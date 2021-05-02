using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComparer
{
    public static class ObjComparer
    {
   
       public static bool Compare(object a, object b)
        {
            if (a == null || b == null)
                return a == b;
            else if (a == b || a.Equals(b)) return true;
            else
            {
                try
                {
                    IComparer comparer = ComparerFactory.GetComparerInstance(a.GetType());
                    return comparer.Compare(a, b);
                }
                catch (Exception)
                {
                  
                    return false;
                }
            }
        }
    }
}
