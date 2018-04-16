using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProduceManager.Forms.Domains
{
    public static class SequenseNoGenerator
    {
        public static string GetNextCode(string type)
        {
            return type.ToUpper() + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
