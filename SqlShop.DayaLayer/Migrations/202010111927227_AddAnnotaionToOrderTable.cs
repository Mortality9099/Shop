namespace SqlShop.DayaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotaionToOrderTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_CustomerId" });
            RenameColumn(table: "dbo.Orders", name: "Customer_CustomerId", newName: "CustomerId");
            AlterColumn("dbo.Orders", "OrderCode", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.Orders", "OrderDate", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Orders", "CustomerId", c => c.Long(nullable: false));
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            AlterColumn("dbo.Orders", "CustomerId", c => c.Long());
            AlterColumn("dbo.Orders", "OrderDate", c => c.String());
            AlterColumn("dbo.Orders", "OrderCode", c => c.String());
            RenameColumn(table: "dbo.Orders", name: "CustomerId", newName: "Customer_CustomerId");
            CreateIndex("dbo.Orders", "Customer_CustomerId");
            AddForeignKey("dbo.Orders", "Customer_CustomerId", "dbo.Customers", "CustomerId");
        }
    }
}
