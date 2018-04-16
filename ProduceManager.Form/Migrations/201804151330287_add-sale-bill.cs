namespace ProduceManager.Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsalebill : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleBillItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Product_Id = c.Int(),
                        SaleBill_Id = c.Int()
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
                        Price = c.Double(nullable: false),
                        CustomeName = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleBillItems", "SaleBill_Id", "dbo.SaleBills");
            DropForeignKey("dbo.SaleBillItems", "Product_Id", "dbo.Products");
            DropIndex("dbo.SaleBillItems", new[] { "SaleBill_Id" });
            DropIndex("dbo.SaleBillItems", new[] { "Product_Id" });
            DropTable("dbo.SaleBills");
            DropTable("dbo.SaleBillItems");
        }
    }
}
