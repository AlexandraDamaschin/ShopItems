namespace ShopItems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Double(nullable: false),
                        Class = c.Int(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Balance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PurchaseDate = c.DateTime(nullable: false),
                        Item_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ShopItems", t => t.Item_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Purchases", "Item_ID", "dbo.ShopItems");
            DropIndex("dbo.Purchases", new[] { "User_ID" });
            DropIndex("dbo.Purchases", new[] { "Item_ID" });
            DropTable("dbo.Purchases");
            DropTable("dbo.Users");
            DropTable("dbo.ShopItems");
        }
    }
}
