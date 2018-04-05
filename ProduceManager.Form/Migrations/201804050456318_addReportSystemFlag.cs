namespace ProduceManager.Form.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReportSystemFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReportItems", "IsSystem", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReportItems", "IsSystem");
        }
    }
}
