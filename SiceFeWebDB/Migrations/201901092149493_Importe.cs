namespace SiceFeWebDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Importe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OnQueue", "ImporteDocumento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OnQueue", "ImporteDocumento");
        }
    }
}
