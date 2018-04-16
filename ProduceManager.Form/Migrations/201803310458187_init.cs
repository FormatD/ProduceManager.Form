namespace ProduceManager.Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        price = c.Double(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prices", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Prices", "Procedure_Id", "dbo.Procedures");
            DropIndex("dbo.Prices", new[] { "Product_Id" });
            DropIndex("dbo.Prices", new[] { "Procedure_Id" });
            DropTable("dbo.Workers");
            DropTable("dbo.ProduceRecords");
            DropTable("dbo.Products");
            DropTable("dbo.Procedures");
            DropTable("dbo.Prices");
            DropTable("dbo.Batches");
        }
    }
}
