using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Core.Domains
{

    public class Procedure : Entity, IDisplayable
    {
        public string Name { get; set; }

        public int Order { get; set; }
        public string DisplayText => GetDisplayText();

        public bool CanSetPrice { get; set; }

        public string GetDisplayText()
        {
            return string.Format("{0}({1})", Name, Order);
        }

        public override string ToString()
        {
            return GetDisplayText();
        }
    }

}
