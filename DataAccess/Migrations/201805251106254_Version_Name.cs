namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version_Name : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InstalledTickets",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TicketId = c.String(nullable: false),
                        NoyeService = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false),
                        NahveyeBastanANtenBaBasyFelizi = c.Boolean(nullable: false),
                        MakanNasbAntenDarFilmMojodAst = c.Boolean(nullable: false),
                        AmozeshSHarjKardan = c.Boolean(nullable: false),
                        AyaAntenRoyeSolehAst = c.Boolean(nullable: false),
                        TestGerftanSignal = c.Boolean(nullable: false),
                        CcqTx = c.String(),
                        CcqRx = c.String(),
                        SignalTx = c.String(),
                        SignalRx = c.String(),
                        NasbmahalJoghrafiyaye = c.Boolean(nullable: false),
                        NasbVaAmozeshehTShark = c.Boolean(nullable: false),
                        TahvilKartKarbar = c.Boolean(nullable: false),
                        AgahiyehKarbarAzMoshkelat = c.Boolean(nullable: false),
                        DaryafteEtelateKarbar = c.Boolean(nullable: false),
                        CheckKardanNamkarbaroVaRamzObor = c.Boolean(nullable: false),
                        DownloadTestSoraat = c.Boolean(nullable: false),
                        BwTestTx = c.String(),
                        BwTestRx = c.String(),
                        TestSorat = c.String(),
                        CheckKardanLanAntenDarErtebatBaRadio = c.Boolean(nullable: false),
                        EtminanAzKhoshkBodanKabl = c.Boolean(nullable: false),
                        TesteAdaptor = c.Boolean(nullable: false),
                        NahveyeAshnayeBaSherkat = c.String(),
                        Tozehat = c.String(),
                        TakhfifBeRiyal = c.String(),
                        MablaghBeRiyal = c.String(),
                        TozihatA = c.String(),
                        HazinehBeRiyal = c.String(),
                        TozihabB = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Installers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InstallLists",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TicketId = c.String(nullable: false),
                        Username = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        ErtefayeSakhteman = c.String(),
                        TajhezatDara = c.Boolean(nullable: false),
                        Latitude = c.String(),
                        Longitude = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RepairTickets",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TicketId = c.String(nullable: false),
                        NoyeService = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false),
                        NahveyeBastanANtenBaBasyFelizi = c.Boolean(nullable: false),
                        MakanNasbAntenDarFilmMojodAst = c.Boolean(nullable: false),
                        AmozeshSHarjKardan = c.Boolean(nullable: false),
                        AyaAntenRoyeSolehAst = c.Boolean(nullable: false),
                        TestGerftanSignal = c.Boolean(nullable: false),
                        CcqTx = c.String(),
                        CcqRx = c.String(),
                        SignalTx = c.String(),
                        SignalRx = c.String(),
                        NasbmahalJoghrafiyaye = c.Boolean(nullable: false),
                        NasbVaAmozeshehTShark = c.Boolean(nullable: false),
                        TahvilKartKarbar = c.Boolean(nullable: false),
                        AgahiyehKarbarAzMoshkelat = c.Boolean(nullable: false),
                        DaryafteEtelateKarbar = c.Boolean(nullable: false),
                        CheckKardanNamkarbaroVaRamzObor = c.Boolean(nullable: false),
                        DownloadTestSoraat = c.Boolean(nullable: false),
                        BwTestTx = c.String(),
                        BwTestRx = c.String(),
                        TestSorat = c.String(),
                        CheckKardanLanAntenDarErtebatBaRadio = c.Boolean(nullable: false),
                        EtminanAzKhoshkBodanKabl = c.Boolean(nullable: false),
                        TesteAdaptor = c.Boolean(nullable: false),
                        NahveyeAshnayeBaSherkat = c.String(),
                        Tozehat = c.String(),
                        TakhfifBeRiyal = c.String(),
                        MablaghBeRiyal = c.String(),
                        TozihatA = c.String(),
                        HazinehBeRiyal = c.String(),
                        TozihabB = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RepairTickets");
            DropTable("dbo.InstallLists");
            DropTable("dbo.Installers");
            DropTable("dbo.InstalledTickets");
        }
    }
}
