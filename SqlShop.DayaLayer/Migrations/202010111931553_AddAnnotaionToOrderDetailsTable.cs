namespace SqlShop.DayaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotaionToOrderDetailsTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.OrderDetails", new[] { "Order_OrderId" });
            DropIndex("dbo.OrderDetails", new[] { "Product_ProductId" });
            RenameColumn(table: "dbo.OrderDetails", name: "Order_OrderId", newName: "OrderId");
            RenameColumn(table: "dbo.OrderDetails", name: "Product_ProductId", newName: "ProductId");
            AlterColumn("dbo.OrderDetails", "OrderId", c => c.Long(nullable: false));
            AlterColumn("dbo.OrderDetails", "ProductId", c => c.Long(nullable: false));
            CreateIndex("dbo.OrderDetails", "OrderId");
            CreateIndex("dbo.OrderDetails", "ProductId");
            AddForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            AlterColumn("dbo.OrderDetails", "ProductId", c => c.Long());
            AlterColumn("dbo.OrderDetails", "OrderId", c => c.Long());
            RenameColumn(table: "dbo.OrderDetails", name: "ProductId", newName: "Product_ProductId");
            RenameColumn(table: "dbo.OrderDetails", name: "OrderId", newName: "Order_OrderId");
            CreateIndex("dbo.OrderDetails", "Product_ProductId");
            CreateIndex("dbo.OrderDetails", "Order_OrderId");
            AddForeignKey("dbo.OrderDetails", "Product_ProductId", "dbo.Products", "ProductId");
            AddForeignKey("dbo.OrderDetails", "Order_OrderId", "dbo.Orders", "OrderId");
        }
    }
}
