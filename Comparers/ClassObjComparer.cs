using System;
using System.Linq;
using System.Reflection;
using ObjectComparer;
namespace ObjectComparer.Comparers
{
    public class ClassObjComparer:IComparer
    {
        public ClassObjComparer() { }

        public bool Compare(object firstObj, object secondObj)
        {
            if (firstObj.GetType() != secondObj.GetType())
                return false;
            var type = firstObj.GetType();
            var readableProperties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                                     .Where(p => p.CanRead == true)
                                     .ToArray();

            foreach (var property in readableProperties)
            {
                object firstObjVal = property.GetValue(firstObj);
                object secondObjVal = property.GetValue(secondObj);
                var areSame = ObjComparer.Compare(firstObjVal, secondObjVal);
                if (!areSame) return false;
            }
            return true;
        }
    }
}
