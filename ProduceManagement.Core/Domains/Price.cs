using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Core.Domains
{

    public class Price : Entity
    {
        public Procedure Procedure { get; set; }

        public Product Product { get; set; }

        public double price { get; set; }
    }

}
