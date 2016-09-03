using System;

namespace Leos.Helpers
{
    public static class CustomExtensions
    {
        public static bool In<T>(this T o, params T[] set)
        {
            if (set == null || set.Length < 1)
            {
                throw new Exception("At least one element must be provided in the set");
            }

            foreach (T element in set)
            {
                if (element.Equals(o))
                {
                    return true;
                }
            }
            return false;
        }

        public static Object IfOrThen(this Object o, params Object[] tuples)
        {
            if (tuples == null || tuples.Length < 2)
            {
                throw new Exception("At least one valid tuple [key, valueToReturn] must be provided");
            }

            Object objToReturn = null;

            for (int i = 0; i < tuples.Length; i += 2)
            {
                if (tuples[i].Equals(o))
                {
                    objToReturn = tuples[i + 1];
                }
            }

            bool hasElseStatement = tuples.Length % 2 != 0;

            if (objToReturn == null && hasElseStatement)
            {
                objToReturn = tuples[tuples.Length - 1];
            } 
            else
            {
                // TODO throw Exception? 
            }

            return objToReturn;
        }
    }

    public class Helpers
    {
    }
}
