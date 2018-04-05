using ProduceManager.Form.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Form.Persistence
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
            : base("Mssql")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public IDbSet<Worker> Workers { get; set; }

        public IDbSet<Procedure> Procedures { get; set; }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<Price> Prices { get; set; }

        public IDbSet<Batch> Batchs { get; set; }

        public IDbSet<ProduceRecord> ProduceRecords { get; set; }

        public IDbSet<ReportItem> Reports { get; set; }

    }
}
