using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Core.Domains
{

    public class Worker : Entity, IDisplayable
    {

        public string Name { get; set; }

        public string Code { get; set; }

        public string DisplayText => GetDisplayText();

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
