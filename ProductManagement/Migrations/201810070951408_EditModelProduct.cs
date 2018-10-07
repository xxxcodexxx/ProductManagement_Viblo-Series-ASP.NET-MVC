namespace ProductManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditModelProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "ModifyDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ModifyDate");
            DropColumn("dbo.Products", "CreateDate");
            DropColumn("dbo.Products", "Price");
        }
    }
}
