namespace ClimaTempoSimples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        CidadeID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        EstadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CidadeID)
                .ForeignKey("dbo.Estado", t => t.EstadoID, cascadeDelete: true)
                .Index(t => t.EstadoID);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        EstadoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        UF = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.EstadoID);
            
            CreateTable(
                "dbo.PrevisaoClima",
                c => new
                    {
                        PrevisaoClimaID = c.Int(nullable: false, identity: true),
                        Clima = c.String(nullable: false, maxLength: 15),
                        TemperaturaMaxima = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TemperaturaMinima = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataPrevisao = c.DateTime(nullable: false),
                        CidadeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PrevisaoClimaID)
                .ForeignKey("dbo.Cidade", t => t.CidadeID, cascadeDelete: true)
                .Index(t => t.CidadeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrevisaoClima", "CidadeID", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "EstadoID", "dbo.Estado");
            DropIndex("dbo.PrevisaoClima", new[] { "CidadeID" });
            DropIndex("dbo.Cidade", new[] { "EstadoID" });
            DropTable("dbo.PrevisaoClima");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
        }
    }
}
