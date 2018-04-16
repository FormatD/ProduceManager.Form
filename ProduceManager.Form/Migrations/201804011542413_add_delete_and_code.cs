namespace ProduceManager.Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_delete_and_code : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Batches", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Prices", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Procedures", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Code", c => c.String());
            AddColumn("dbo.Products", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProduceRecords", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Workers", "Code", c => c.String());
            AddColumn("dbo.Workers", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Workers", "IsDeleted");
            DropColumn("dbo.Workers", "Code");
            DropColumn("dbo.ProduceRecords", "IsDeleted");
            DropColumn("dbo.Products", "IsDeleted");
            DropColumn("dbo.Products", "Code");
            DropColumn("dbo.Procedures", "IsDeleted");
            DropColumn("dbo.Prices", "IsDeleted");
            DropColumn("dbo.Batches", "IsDeleted");
        }
    }
}
