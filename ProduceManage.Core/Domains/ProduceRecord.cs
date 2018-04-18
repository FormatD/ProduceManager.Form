using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Forms.Domains
{

    public class ProduceRecord : Entity
    {

        public int BatchId { get; set; }

        public int ProductId { get; set; }

        public int ProcedureId { get; set; }

        public DateTime Date { get; set; }

        public int WorkerId { get; set; }

        public int Amount { get; set; }

    }

}
