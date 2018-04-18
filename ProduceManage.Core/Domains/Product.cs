using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Forms.Domains
{

    public class Product : Entity, IDisplayable
    {

        public string Code { get; set; }

        public string Name { get; set; }

        public string GetDisplayText()
        {
            return string.Format("{0}({1})", Name, Code);
        }

        public override string ToString()
        {
            return GetDisplayText();
        }

    }

}
