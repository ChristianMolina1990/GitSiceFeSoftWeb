namespace SiceFeWebDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Document",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RucEmisor = c.String(nullable: false, maxLength: 11, unicode: false),
                        NombreEmisor = c.String(),
                        TipoDocumentoSunat = c.String(),
                        NombreDocumentoSunat = c.String(),
                        SerieDocumento = c.String(),
                        NumeroDocumento = c.String(),
                        TipoDocumentoIdentidadCliente = c.String(),
                        NombreDocumentoIdentidadCliente = c.String(),
                        ImporteTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CodigoInterno = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OnQueue",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RucEmisor = c.String(),
                        TipoDocumentoSunat = c.String(),
                        SerieDocumento = c.String(),
                        NumeroDocumento = c.String(),
                        EmailRegistrado = c.String(),
                        EmailEnviado = c.Boolean(),
                        FechaEnviado = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OnQueue");
            DropTable("dbo.Document");
        }
    }
}
