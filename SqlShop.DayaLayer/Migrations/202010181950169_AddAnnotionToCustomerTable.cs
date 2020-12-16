namespace SqlShop.DayaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotionToCustomerTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Address", c => c.String(maxLength: 150));
            AlterColumn("dbo.Customers", "Email", c => c.String());
        }
    }
}
