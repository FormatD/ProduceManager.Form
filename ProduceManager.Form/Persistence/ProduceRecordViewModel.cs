using ProduceManager.Forms.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ProduceManager.Forms.Persistence
{

    public class ProduceRecordViewModel
    {
        public int Id { get; set; }

        public int BatchId { get; set; }

        public string BatchNo { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int ProcedureId { get; set; }

        public string ProcedureName { get; set; }

        public int WorkerId { get; set; }

        public string WorkerName { get; set; }

        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsProductDeleted { get; set; }

        public bool IsBatchDeleted { get; set; }

        public bool IsWorkerDeleted { get; set; }

        public bool IsProcedureDeleted { get; set; }

        public double Price { get; set; }

        public double TotalPrice => Price * Amount;
    }
}
