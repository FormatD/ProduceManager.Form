using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Core.Domains
{

    public class ReportItem : Entity
    {
        public string Name { get; set; }

        public string DataSource { get; set; }

        public byte[] Content { get; set; }

        public bool IsSystem { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
