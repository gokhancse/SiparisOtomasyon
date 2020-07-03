using SiparisYonetim.Tablolar;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetim
{
    public class DB_Context : DbContext
    {
        private static DB_Context Nesne;
        //Data Source=DESKTOP-R2R6O6G\\SQLEXPRESS;Initial Catalog=Siparis;MultipleActiveResultSets=True;App=EntityFramework;User ID=sa;Password=1234567
        public DB_Context() : base("Data Source=DESKTOP-R2R6O6G\\SQLEXPRESS;Initial Catalog=Siparis;MultipleActiveResultSets=True;App=EntityFramework;User ID=sa;Password=1234567")
        {
        }
        protected override void Dispose(bool disposing)
        {
            return;
        }
        public static DB_Context Instance
        {
            get
            {
                if (Nesne == null)
                {
                    Nesne = new DB_Context();
                }
                return Nesne;
            }
        }
        public void Reload()
        {
            //Randevular.Load();
            //Hastalar.Load();
            //ChangeTracker.DetectChanges();
            //foreach (var item in ChangeTracker.Entries())
            //{
            //    item.Reload();
            //}
        }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Sirket> Sirketler { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }



        public DbSet<Siparis_Detay> SiparisDetaylar { get; set; }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Sirket>()
                .HasMany(x => x.Siparisler)
                .WithRequired(x => x.Sirket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sirket>()
                .HasMany(x => x.Siparisler)
                .WithRequired(x => x.SiparisVerenSirket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sirket>()
                .HasMany(x => x.SiparisDetaylar)
                .WithRequired(x => x.Sirket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
               .HasMany(x => x.Siparisler)
               .WithRequired(x => x.Kullanici)
               .WillCascadeOnDelete(false);



            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Kategori>().ToTable("Kategori");
            modelBuilder.Entity<Urun>().ToTable("Urun");
            modelBuilder.Entity<Siparis_Detay>().ToTable("Siparis_Detay");
            modelBuilder.Entity<Kullanici>().ToTable("Kullanici");
            modelBuilder.Entity<Sirket>().ToTable("Sirket");
            base.OnModelCreating(modelBuilder);
        }

    }
}
