namespace Praktika.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class conn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dostavkas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NamE = c.String(),
                        Adress = c.String(),
                        Phone = c.String(),
                        PriceDostavki = c.Int(nullable: false),
                        StatID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Status");
            DropTable("dbo.Dostavkas");
        }
    }
}
