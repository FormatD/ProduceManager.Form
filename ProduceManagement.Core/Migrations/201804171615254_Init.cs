namespace ProduceManager.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No = c.String(),
                        ProductId = c.Int(nullable: false),
                        ExpectedAmount = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        price = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Procedure_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Procedures", t => t.Procedure_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Procedure_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Procedures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Order = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProduceRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BatchId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ProcedureId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReportItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DataSource = c.String(),
                        Content = c.Binary(),
                        IsSystem = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SaleBillItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Product_Id = c.Int(),
                        SaleBill_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.SaleBills", t => t.SaleBill_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.SaleBill_Id);
            
            CreateTable(
                "dbo.SaleBills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BillNo = c.String(),
                        CustomeName = c.String(),
                        Date = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleBillItems", "SaleBill_Id", "dbo.SaleBills");
            DropForeignKey("dbo.SaleBillItems", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Prices", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Prices", "Procedure_Id", "dbo.Procedures");
            DropIndex("dbo.SaleBillItems", new[] { "SaleBill_Id" });
            DropIndex("dbo.SaleBillItems", new[] { "Product_Id" });
            DropIndex("dbo.Prices", new[] { "Product_Id" });
            DropIndex("dbo.Prices", new[] { "Procedure_Id" });
            DropTable("dbo.Workers");
            DropTable("dbo.SaleBills");
            DropTable("dbo.SaleBillItems");
            DropTable("dbo.ReportItems");
            DropTable("dbo.ProduceRecords");
            DropTable("dbo.Products");
            DropTable("dbo.Procedures");
            DropTable("dbo.Prices");
            DropTable("dbo.Batches");
        }
    }
}
