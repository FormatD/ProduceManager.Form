namespace ProduceManager.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcansetprice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Procedures", "CanSetPrice", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Procedures", "CanSetPrice");
        }
    }
}
