namespace SqlShop.DayaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationToSupplierTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "ContactName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Suppliers", "Address", c => c.String(maxLength: 300));
            AlterColumn("dbo.Suppliers", "PhoneNumber", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Suppliers", "Address", c => c.String());
            AlterColumn("dbo.Suppliers", "ContactName", c => c.String());
        }
    }
}
