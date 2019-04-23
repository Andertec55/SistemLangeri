namespace SistemLangeri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Client",
                    c => new
                    {
                        ClientId = c.Int(nullable: false),
                        QtdDeCompUnit = c.Int(nullable: false),
                        QtdDeCompUnitCalc = c.Int(nullable: false),
                        QtdDeCompUnitSut = c.Int(nullable: false),
                        QtdDeCompUnitConj = c.Int(nullable: false),
                        DateCli = c.DateTime(nullable: false, precision: 0),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId, cascadeDelete: true);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                        Nome = c.String(unicode: false),
                        Endereco = c.String(unicode: false),
                        Telefone = c.Int(nullable: false),
                        Email = c.String(unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaId);
            
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        EstoqueId = c.Int(nullable: false),
                        QtdTotal = c.Int(nullable: false),
                        QtdTotalConj = c.Int(nullable: false),
                        QtdTotalCal = c.Int(nullable: false),
                        QtdTotalSut = c.Int(nullable: false),
                        StatusInserirDados = c.Boolean(nullable: false),
                        DateEst = c.DateTime(nullable: false, precision: 0),
                        ValorTotalBras = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.EstoqueId);

            CreateTable(
                    "dbo.Revendedor",
                    c => new
                    {
                        RevendedorId = c.Int(nullable: false),
                        DateRev = c.DateTime(nullable: false, precision: 0),
                        QtdObtida = c.Int(nullable: false),
                        QtdDeConjuntos = c.Int(nullable: false),
                        QtdDeAvulsos = c.Int(nullable: false),
                        QtdVendConj = c.Int(nullable: false),
                        QtdVendAvul = c.Int(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RevendedorId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId, cascadeDelete: true);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Revendedor", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Client", "PessoaId", "dbo.Pessoa");
            DropIndex("dbo.Revendedor", new[] { "PessoaId" });
            DropIndex("dbo.Client", new[] { "PessoaId" });
            DropTable("dbo.Revendedor");
            DropTable("dbo.Estoque");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Client");
        }
    }
}
