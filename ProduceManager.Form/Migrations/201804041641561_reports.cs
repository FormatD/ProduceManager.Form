namespace ProduceManager.Form.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reports : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReportItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DataSource = c.String(),
                        Content = c.Binary(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReportItems");
        }
    }
}
