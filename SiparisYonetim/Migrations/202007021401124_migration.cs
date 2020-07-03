namespace SiparisYonetim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bilesen", "KategoriId", "dbo.Kategori");
            DropForeignKey("dbo.ObjectCaches", "SirketId", "dbo.Sirket");
            DropForeignKey("dbo.Renk", "SirketId", "dbo.Sirket");
            DropForeignKey("dbo.Kullanici", "Rol_RolId", "dbo.Rol");
            DropForeignKey("dbo.KullaniciRol", "Kullanici_KullaniciId", "dbo.Kullanici");
            DropForeignKey("dbo.KullaniciRol", "Rol_RolId", "dbo.Rol");
            DropForeignKey("dbo.Bilesen", "SirketId", "dbo.Sirket");
            DropIndex("dbo.Bilesen", new[] { "SirketId" });
            DropIndex("dbo.Bilesen", new[] { "KategoriId" });
            DropIndex("dbo.ObjectCaches", new[] { "SirketId" });
            DropIndex("dbo.Renk", new[] { "SirketId" });
            DropIndex("dbo.Kullanici", new[] { "Rol_RolId" });
            DropIndex("dbo.KullaniciRol", new[] { "Kullanici_KullaniciId" });
            DropIndex("dbo.KullaniciRol", new[] { "Rol_RolId" });
            DropColumn("dbo.Siparis_Detay", "RenkBedenDetayi");
            DropColumn("dbo.Siparis_Detay", "RenkAdet");
            DropColumn("dbo.Siparis_Detay", "Gramaj");
            DropColumn("dbo.Siparis_Detay", "oran");
            DropColumn("dbo.Siparis_Detay", "Ayar2");
            DropColumn("dbo.Siparis_Detay", "ToplamGramaj");
            DropColumn("dbo.Siparis_Detay", "Ayar");
            DropColumn("dbo.Kullanici", "Rol_RolId");
            DropTable("dbo.Bilesen");
            DropTable("dbo.ObjectCaches");
            DropTable("dbo.Renk");
            DropTable("dbo.Rol");
            DropTable("dbo.KullaniciRol");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.KullaniciRol",
                c => new
                    {
                        Kullanici_KullaniciId = c.Int(nullable: false),
                        Rol_RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Kullanici_KullaniciId, t.Rol_RolId });
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        Adi = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.Renk",
                c => new
                    {
                        RenkId = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 25),
                        SirketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RenkId);
            
            CreateTable(
                "dbo.ObjectCaches",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Data = c.Binary(),
                        CacheDate = c.DateTime(nullable: false),
                        ModelName = c.String(),
                        SirketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.Bilesen",
                c => new
                    {
                        BilesenId = c.Int(nullable: false, identity: true),
                        BilesenAdi = c.String(nullable: false, maxLength: 25),
                        SirketId = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BilesenId);
            
            AddColumn("dbo.Kullanici", "Rol_RolId", c => c.Int());
            AddColumn("dbo.Siparis_Detay", "Ayar", c => c.String(maxLength: 16));
            AddColumn("dbo.Siparis_Detay", "ToplamGramaj", c => c.Double(nullable: false));
            AddColumn("dbo.Siparis_Detay", "Ayar2", c => c.String());
            AddColumn("dbo.Siparis_Detay", "oran", c => c.Double(nullable: false));
            AddColumn("dbo.Siparis_Detay", "Gramaj", c => c.Double(nullable: false));
            AddColumn("dbo.Siparis_Detay", "RenkAdet", c => c.Int(nullable: false));
            AddColumn("dbo.Siparis_Detay", "RenkBedenDetayi", c => c.String());
            CreateIndex("dbo.KullaniciRol", "Rol_RolId");
            CreateIndex("dbo.KullaniciRol", "Kullanici_KullaniciId");
            CreateIndex("dbo.Kullanici", "Rol_RolId");
            CreateIndex("dbo.Renk", "SirketId");
            CreateIndex("dbo.ObjectCaches", "SirketId");
            CreateIndex("dbo.Bilesen", "KategoriId");
            CreateIndex("dbo.Bilesen", "SirketId");
            AddForeignKey("dbo.Bilesen", "SirketId", "dbo.Sirket", "SirketId", cascadeDelete: true);
            AddForeignKey("dbo.KullaniciRol", "Rol_RolId", "dbo.Rol", "RolId");
            AddForeignKey("dbo.KullaniciRol", "Kullanici_KullaniciId", "dbo.Kullanici", "KullaniciId");
            AddForeignKey("dbo.Kullanici", "Rol_RolId", "dbo.Rol", "RolId");
            AddForeignKey("dbo.Renk", "SirketId", "dbo.Sirket", "SirketId", cascadeDelete: true);
            AddForeignKey("dbo.ObjectCaches", "SirketId", "dbo.Sirket", "SirketId");
            AddForeignKey("dbo.Bilesen", "KategoriId", "dbo.Kategori", "KategoriId", cascadeDelete: true);
        }
    }
}
