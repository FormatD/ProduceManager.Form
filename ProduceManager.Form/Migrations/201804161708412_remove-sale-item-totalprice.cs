namespace ProduceManager.Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removesaleitemtotalprice : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SaleBillItems", "TotalPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaleBillItems", "TotalPrice", c => c.Double(nullable: false));
        }
    }
}
