namespace ProduceManager.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newrecordentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProduceRecords", "Batch_Id", c => c.Int());
            AddColumn("dbo.ProduceRecords", "Procedure_Id", c => c.Int());
            AddColumn("dbo.ProduceRecords", "Product_Id", c => c.Int());
            AddColumn("dbo.ProduceRecords", "Worker_Id", c => c.Int());
            CreateIndex("dbo.ProduceRecords", "Batch_Id");
            CreateIndex("dbo.ProduceRecords", "Procedure_Id");
            CreateIndex("dbo.ProduceRecords", "Product_Id");
            CreateIndex("dbo.ProduceRecords", "Worker_Id");
            AddForeignKey("dbo.ProduceRecords", "Batch_Id", "dbo.Batches", "Id");
            AddForeignKey("dbo.ProduceRecords", "Procedure_Id", "dbo.Procedures", "Id");
            AddForeignKey("dbo.ProduceRecords", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.ProduceRecords", "Worker_Id", "dbo.Workers", "Id");
            DropColumn("dbo.ProduceRecords", "BatchId");
            DropColumn("dbo.ProduceRecords", "ProductId");
            DropColumn("dbo.ProduceRecords", "ProcedureId");
            DropColumn("dbo.ProduceRecords", "WorkerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProduceRecords", "WorkerId", c => c.Int(nullable: false));
            AddColumn("dbo.ProduceRecords", "ProcedureId", c => c.Int(nullable: false));
            AddColumn("dbo.ProduceRecords", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.ProduceRecords", "BatchId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProduceRecords", "Worker_Id", "dbo.Workers");
            DropForeignKey("dbo.ProduceRecords", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProduceRecords", "Procedure_Id", "dbo.Procedures");
            DropForeignKey("dbo.ProduceRecords", "Batch_Id", "dbo.Batches");
            DropIndex("dbo.ProduceRecords", new[] { "Worker_Id" });
            DropIndex("dbo.ProduceRecords", new[] { "Product_Id" });
            DropIndex("dbo.ProduceRecords", new[] { "Procedure_Id" });
            DropIndex("dbo.ProduceRecords", new[] { "Batch_Id" });
            DropColumn("dbo.ProduceRecords", "Worker_Id");
            DropColumn("dbo.ProduceRecords", "Product_Id");
            DropColumn("dbo.ProduceRecords", "Procedure_Id");
            DropColumn("dbo.ProduceRecords", "Batch_Id");
        }
    }
}
