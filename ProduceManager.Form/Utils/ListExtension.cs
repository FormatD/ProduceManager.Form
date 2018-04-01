using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProduceManager.Form.Utils
{
    public static class ListExtension
    {

        public static int IndexOf<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            var index = -1;
            foreach (var item in source)
            {
                index++;
                if (func(item))
                    return index;
            }
            return index;
        }
    }
}
