using ProduceManager.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Core.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base(SystemConfig.ConnectionName)
        {
        }

        public ApplicationDbContext(DbConnection sQLiteConnection)
            : base(sQLiteConnection, false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SaleBillItem>()
                .Ignore(t => t.ProductName)
                .Ignore(x => x.TotalPrice);
        }

        public IDbSet<Worker> Workers { get; set; }

        public IDbSet<Procedure> Procedures { get; set; }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<Price> Prices { get; set; }

        public IDbSet<Batch> Batchs { get; set; }

        public IDbSet<ProduceRecord> ProduceRecords { get; set; }

        public IDbSet<ReportItem> Reports { get; set; }

        public IDbSet<SaleBill> SaleBills { get; set; }

        public IDbSet<SaleBillItem> SaleBillItems { get; set; }

        public void RejectChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

    }
}
