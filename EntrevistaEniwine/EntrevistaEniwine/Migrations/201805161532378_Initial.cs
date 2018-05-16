namespace EntrevistaEniwine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arma",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descricao = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Local",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descricao = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Suspeito",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descricao = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.id);


            Sql("Insert Into Arma Values ('Cajado Devastador')");
            Sql("Insert Into Arma Values ('Phaser')");
            Sql("Insert Into Arma Values ('Peixeira')");
            Sql("Insert Into Arma Values ('Trezoitão')");
            Sql("Insert Into Arma Values ('Sabre de Luz')");
            Sql("Insert Into Arma Values ('Bomba')");

            Sql("Insert Into Local Values ('Etérnia')");
            Sql("Insert Into Local Values ('Vulcano')");
            Sql("Insert Into Local Values ('Tatooine')");
            Sql("Insert Into Local Values ('Springfield')");
            Sql("Insert Into Local Values ('Gotham')");
            Sql("Insert Into Local Values ('Nova York')");
            Sql("Insert Into Local Values ('Sibéria')");
            Sql("Insert Into Local Values ('Machu Picchu')");
            Sql("Insert Into Local Values ('Show do Katinguele')");
            Sql("Insert Into Local Values ('São Paulo')");

            Sql("Insert Into Suspeito Values ('Esqueleto')");
            Sql("Insert Into Suspeito Values ('Khan')");
            Sql("Insert Into Suspeito Values ('Darth vader')");
            Sql("Insert Into Suspeito Values ('Sideshow Bob')");
            Sql("Insert Into Suspeito Values ('Coringa')");
            Sql("Insert Into Suspeito Values ('Duende Verde')");

        }

        public override void Down()
        {
            DropTable("dbo.Suspeito");
            DropTable("dbo.Local");
            DropTable("dbo.Arma");
        }
    }
}
