using ProduceManager.Forms.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProduceManager.Forms.Persistence
{
    public class ApplicationService
    {
        private static Lazy<ApplicationService> _service = new Lazy<ApplicationService>();

        public static ApplicationService Instanse { get { return _service.Value; } }

        ApplicationDbContext _dbContext = new ApplicationDbContext();

        #region Batches

        public void AddBatch(Batch batch)
        {
            _dbContext.Batchs.Add(batch);
            _dbContext.SaveChanges();
        }

        public Batch GetBatch(int id)
        {
            return _dbContext.Batchs.FirstOrDefault(x => x.Id == id);
        }

        public IList<BatchViewModel> GetAllBatches()
        {
            var xx = from b in _dbContext.Batchs
                     join p in _dbContext.Products on b.ProductId equals p.Id
                     select new BatchViewModel
                     {
                         Id = b.Id,
                         BatchNo = b.No,
                         ExpectedAmount = b.ExpectedAmount,
                         IsDeleted = b.IsDeleted,
                         StartDate = b.StartDate,
                         ProductId = p.Id,
                         ProductName = p.Name,
                         IsProductDeleted = p.IsDeleted,
                     };

            return xx.ToList();
        }

        internal void DeleteBatch(int p)
        {
            var batch = GetBatch(p);
            if (batch != null)
                batch.IsDeleted = true;

            _dbContext.SaveChanges();
        }

        #endregion

        #region Product

        internal IList<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return _dbContext.Products.FirstOrDefault(x => x.Id == id);
        }

        internal void AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        internal void DeleteProduct(int id)
        {
            var product = GetProduct(id);
            if (product != null)
                product.IsDeleted = true;

            _dbContext.SaveChanges();
        }

        #endregion

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        #region Procedure

        internal IList<Procedure> GetAllProcedures()
        {
            return _dbContext.Procedures.ToList();
        }

        internal Procedure GetProcedure(int id)
        {
            return _dbContext.Procedures.FirstOrDefault(x => x.Id == id);
        }

        internal void AddProcedure(Procedure procedure)
        {
            _dbContext.Procedures.Add(procedure);
            _dbContext.SaveChanges();
        }

        internal void DeleteProcedure(int id)
        {
            var procedure = GetProcedure(id);
            if (procedure != null)
                procedure.IsDeleted = true;

            _dbContext.SaveChanges();
        }
        #endregion

        #region Worker

        internal IList<Worker> GetAllWorkers()
        {
            return _dbContext.Workers.ToList();
        }

        public Worker GetWorker(int id)
        {
            return _dbContext.Workers.FirstOrDefault(x => x.Id == id);
        }

        internal void AddWorker(Worker worker)
        {
            _dbContext.Workers.Add(worker);
            _dbContext.SaveChanges();
        }

        internal void DeleteWorker(int id)
        {
            var worker = GetWorker(id);
            if (worker != null)
                worker.IsDeleted = true;

            _dbContext.SaveChanges();
        }

        internal void DeleteAllPrice()
        {
            foreach (var price in _dbContext.Prices)
            {
                _dbContext.Prices.Remove(price);
            }

            SaveChanges();
        }

        internal void AddPriceList(List<Price> prices)
        {
            foreach (var price in prices)
            {
                _dbContext.Prices.Add(price);
            }
            SaveChanges();
        }

        #endregion

        #region Produce Record

        internal IList<ProduceRecordViewModel> GetAllProduceRecords()
        {
            var xx = from pr in _dbContext.ProduceRecords
                         //join b in _dbContext.Batchs on pr.BatchId equals b.Id
                     join p in _dbContext.Products on pr.ProductId equals p.Id
                     join w in _dbContext.Workers on pr.WorkerId equals w.Id
                     join proc in _dbContext.Procedures on pr.ProcedureId equals proc.Id
                     select new ProduceRecordViewModel
                     {
                         Id = pr.Id,
                         Amount = pr.Amount,
                         IsDeleted = pr.IsDeleted,
                         Date = pr.Date,
                         // Batch
                         //BatchId = b.Id,
                         //BatchNo = b.No,
                         //IsBatchDeleted = b.IsDeleted,
                         // Product
                         ProductId = p.Id,
                         ProductName = p.Name,
                         IsProductDeleted = p.IsDeleted,
                         // Worker
                         WorkerId = w.Id,
                         WorkerName = w.Name,
                         IsWorkerDeleted = w.IsDeleted,

                         // Procedure
                         ProcedureId = proc.Id,
                         ProcedureName = proc.Name,
                         IsProcedureDeleted = proc.IsDeleted,
                     };

            return xx.ToList();
        }

        internal object SearchProduceRecord(Func<ProduceRecord, bool> func)
        {
            return _dbContext.ProduceRecords.Where(func);
        }

        public ProduceRecord GetProduceRecord(int id)
        {
            return _dbContext.ProduceRecords.FirstOrDefault(x => x.Id == id);
        }

        internal void AddProduceRecord(ProduceRecord produceRecord)
        {
            _dbContext.ProduceRecords.Add(produceRecord);
            _dbContext.SaveChanges();
        }

        internal void DeleteProduceRecord(int id)
        {
            var produceRecord = GetProduceRecord(id);
            if (produceRecord != null)
                produceRecord.IsDeleted = true;

            _dbContext.SaveChanges();
        }

        #endregion

        #region Report

        internal void AddReport(ReportItem report)
        {
            _dbContext.Reports.Add(report);
            _dbContext.SaveChanges();
        }

        internal ReportItem GetReport(int id)
        {
            return _dbContext.Reports.FirstOrDefault(x => x.Id == id);
        }

        internal IEnumerable<ReportItem> GetAllReports()
        {
            return _dbContext.Reports.ToList();
        }

        #endregion

        #region Price

        internal IList<Price> GetAllPriceConfig()
        {
            return _dbContext.Prices
                   .Include(x => x.Product)
                   .Include(x => x.Procedure)
                   .ToList();
        }

        #endregion

        #region SaleBills

        public SaleBill GetSaleBill(int id)
        {
            return _dbContext.SaleBills.Include(x => x.Items).FirstOrDefault(x => x.Id == id);
        }

        internal void AddSaleBill(SaleBill saleBill)
        {
            _dbContext.SaleBills.Add(saleBill);
            foreach (var item in saleBill.Items)
            {
                _dbContext.SaleBillItems.Add(item);
            }

            _dbContext.SaveChanges();
        }

        internal void DeleteSaleBill(int id)
        {
            var bill = GetSaleBill(id);
            _dbContext.SaleBills.Remove(bill);
        }

        internal IList<SaleBill> GetAllSaleBills()
        {
            return _dbContext.SaleBills.Include(x => x.Items).ToList();
        }

        internal void SaveSaleBill(SaleBill saleBill)
        {
            foreach (var item in saleBill.Items)
            {
                var state = _dbContext.Entry(item).State;
                switch (state)
                {
                    case EntityState.Detached:
                        _dbContext.SaleBillItems.Add(item);
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Added:
                        break;
                    case EntityState.Deleted:
                        break;
                    case EntityState.Modified:
                        break;
                    default:
                        break;
                }
            }

            _dbContext.SaveChanges();
        }
        #endregion
    }

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


    }

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
