using ProduceManager.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ProduceManager.Core.Persistence
{

    public class BatchViewModel
    {
        public int Id { get; set; }

        public string BatchNo { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string CurrentWorker { get; set; }

        public int ExpectedAmount { get; set; }

        public int State { get; set; }

        public DateTime StartDate { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsProductDeleted { get; set; }
    }
}
