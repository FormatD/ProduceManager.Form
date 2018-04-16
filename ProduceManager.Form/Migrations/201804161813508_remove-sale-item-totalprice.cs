namespace ProduceManager.Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removesaleitemtotalprice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SaleBills", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.SaleBills", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaleBills", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.SaleBills", "Date");
        }
    }
}
