using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Core.Utils
{
    public static class StringExtension
    {
        public static bool EqualsIgnoreCase(this string source, string target)
        {
            return source.Equals(target, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
