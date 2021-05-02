using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComparer.Comparers
{
     class ValueTypeComparer:IComparer
    {
        public bool Compare(object a, object b)
        {
            return a.Equals(b);
        }
    }
}
