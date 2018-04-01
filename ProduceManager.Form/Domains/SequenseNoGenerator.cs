using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProduceManager.Form.Domains
{


    public class SequenseNoGenerator
    {
        public static string GetNextCode()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
