using ProduceManager.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ProduceManager.Core.Persistence
{
    public class ApplicationService
    {
        private static readonly Lazy<ApplicationService> _service = new Lazy<ApplicationService>();

        public static ApplicationService Instanse { get { return _service.Value; } }

        readonly ApplicationDbContext _dbContext = SystemConfig.ConnectionName.Length > 10
            ? new ApplicationDbContext(new SQLiteConnection(SystemConfig.ConnectionName))
            : new ApplicationDbContext();

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

        public void DeleteBatch(int p)
        {
            var batch = GetBatch(p);
            if (batch != null)
                batch.IsDeleted = true;

            _dbContext.SaveChanges();
        }

        #endregion

        #region Product

        public IList<Product> GetAllProducts()
        {
            return _dbContext.Products
                .Where(p => !p.IsDeleted)
                .ToList();
        }

        public Product GetProduct(int id)
        {
            return _dbContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public void AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(int id)
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

        public IList<Procedure> GetAllProcedures()
        {
            return _dbContext.Procedures
                .Where(p => !p.IsDeleted)
                .ToList();
        }

        public Procedure GetProcedure(int id)
        {
            return _dbContext.Procedures.FirstOrDefault(x => x.Id == id);
        }

        public void AddProcedure(Procedure procedure)
        {
            _dbContext.Procedures.Add(procedure);
            _dbContext.SaveChanges();
        }

        public void DeleteProcedure(int id)
        {
            var procedure = GetProcedure(id);
            if (procedure != null)
                procedure.IsDeleted = true;

            _dbContext.SaveChanges();
        }
        #endregion

        #region Worker

        public IList<Worker> GetAllWorkers()
        {
            return _dbContext.Workers
                .Where(w => !w.IsDeleted)
                .ToList();
        }

        public Worker GetWorker(int id)
        {
            return _dbContext.Workers.FirstOrDefault(x => x.Id == id);
        }

        public void AddWorker(Worker worker)
        {
            _dbContext.Workers.Add(worker);
            _dbContext.SaveChanges();
        }

        public void DeleteWorker(int id)
        {
            var worker = GetWorker(id);
            if (worker != null)
                worker.IsDeleted = true;

            _dbContext.SaveChanges();
        }

        public void DeleteAllPrice()
        {
            foreach (var price in _dbContext.Prices)
            {
                _dbContext.Prices.Remove(price);
            }

            SaveChanges();
        }

        public void AddPriceList(List<Price> prices)
        {
            foreach (var price in prices)
            {
                _dbContext.Prices.Add(price);
            }
            SaveChanges();
        }

        #endregion

        #region Produce Record

        public IList<ProduceRecordViewModel> GetAllProduceRecords()
        {
            var xx = from pr in _dbContext.ProduceRecords
                                    .Include(x => x.Procedure)
                                    .Include(x => x.Product)
                                    .Include(x => x.Worker)
                         //join price in _dbContext.Prices on new { productId = pr.Product.Id, procedureId = pr.Procedure.Id } equals new { productId = price.Product.Id, procedureId = price.Procedure.Id }
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
                         ProductId = pr.Product.Id,
                         ProductName = pr.Product.Name,
                         IsProductDeleted = pr.Product.IsDeleted,
                         // Worker
                         WorkerId = pr.Worker.Id,
                         WorkerName = pr.Worker.Name,
                         IsWorkerDeleted = pr.Worker.IsDeleted,

                         // Procedure
                         ProcedureId = pr.Procedure.Id,
                         ProcedureName = pr.Procedure.Name,
                         IsProcedureDeleted = pr.Procedure.IsDeleted,

                         //Price = price.price,
                     };
            var prices = _dbContext.Prices
                .Include(x => x.Product)
                .Include(x => x.Procedure)
                .Where(x => x.Product != null && x.Procedure != null).ToDictionary(x => $"{x.Product.Id}|{x.Procedure.Id}");

            var viewModels = xx.ToList();
            foreach (var item in viewModels)
            {
                if (prices.TryGetValue($"{item.ProductId}|{item.ProcedureId}", out Price price))
                    item.Price = price.price;
            }

            return viewModels;
        }

        public object SearchProduceRecord(Func<ProduceRecord, bool> func)
        {
            return _dbContext.ProduceRecords.Where(func);
        }

        public ProduceRecord GetProduceRecord(int id)
        {
            return _dbContext.ProduceRecords
                    .Include(x => x.Procedure)
                    .Include(x => x.Product)
                    .Include(x => x.Worker)
                    .FirstOrDefault(x => x.Id == id);
        }

        public void AddProduceRecord(ProduceRecord produceRecord)
        {
            _dbContext.ProduceRecords.Add(produceRecord);
            _dbContext.SaveChanges();
        }

        public void DeleteProduceRecord(int id)
        {
            var produceRecord = GetProduceRecord(id);
            if (produceRecord != null)
                produceRecord.IsDeleted = true;

            _dbContext.SaveChanges();
        }

        #endregion

        #region Report

        public void AddReport(ReportItem report)
        {
            _dbContext.Reports.Add(report);
            _dbContext.SaveChanges();
        }

        public ReportItem GetReport(int id)
        {
            return _dbContext.Reports.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<ReportItem> GetAllReports()
        {
            return _dbContext.Reports.ToList();
        }

        public void DeleteReport(ReportItem reportItem)
        {
            var report = _dbContext.Reports.FirstOrDefault(x => x.Id == reportItem.Id);
            _dbContext.Reports.Remove(report);
            _dbContext.SaveChanges();
        }

        public void DeleteAllReport()
        {
            foreach (var report in GetAllReports())
                _dbContext.Reports.Remove(report);

            _dbContext.SaveChanges();

        }

        #endregion

        #region Price

        public IList<Price> GetAllPriceConfig()
        {
            return _dbContext.Prices
                   .Include(x => x.Product)
                   .Include(x => x.Procedure)
                   .Where(x => !x.Product.IsDeleted && !x.Procedure.IsDeleted)
                   .ToList();
        }

        #endregion

        #region SaleBills

        public SaleBill GetSaleBill(int id)
        {
            return _dbContext.SaleBills
                .Where(b => !b.IsDeleted)
                .Include(x => x.Items).FirstOrDefault(x => x.Id == id);
        }

        public void AddSaleBill(SaleBill saleBill)
        {
            _dbContext.SaleBills.Add(saleBill);
            foreach (var item in saleBill.Items)
            {
                _dbContext.SaleBillItems.Add(item);
            }

            _dbContext.SaveChanges();
        }

        public void DeleteSaleBill(int id)
        {
            var bill = GetSaleBill(id);
            _dbContext.SaleBills.Remove(bill);

            _dbContext.SaveChanges();
        }

        public IList<SaleBill> GetAllSaleBills()
        {
            return _dbContext.SaleBills.Include(x => x.Items).ToList();
        }

        public void SaveSaleBill(SaleBill saleBill)
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
}
