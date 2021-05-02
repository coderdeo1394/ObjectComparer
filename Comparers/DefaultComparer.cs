using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComparer.Comparers
{
    class DefaultComparer : IComparer
    {
        public bool Compare(object a, object b)
        {
            return false;
        }
    }
}
