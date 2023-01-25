using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ogr = new Ogrenci { Ad = "ali", Soyad = "veli" };

            //add
            //using (var ctx = new OkulContext())
            //{
            //    ctx.Ogrenciler.Add(ogr);
            //    ctx.SaveChanges();
            //}

            //update
            //using (var ctx = new OkulContext())
            //{
            //    var ogrenci = ctx.Ogrenciler.Find(2);
            //    ogrenci.Ad = "osman";
            //    ctx.Entry(ogrenci).State = EntityState.Modified;
            //    ctx.SaveChanges();
            //}

            //delete
            //using (var ctx = new OkulContext())
            //{
            //    var ogrenci = ctx.Ogrenciler.Find(2);
            //    ctx.Ogrenciler.Remove(ogrenci);
            //    ctx.SaveChanges();
            //}

            // LINQ: Language Integrated Query
            using (var ctx = new OkulContext())
            {
                var lst = ctx.Ogrenciler.ToList();
                foreach (var item in lst)
                {
                    Console.WriteLine(item.Ad + " " + item.Soyad);
                }
            }


        }
    }
    //Attribute
    [Table("tblOgrenciler")]
    class Ogrenci
    {
        public int Ogrenciid { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(25)]
        public string Ad { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(35)]
        public string Soyad { get; set; }
    }
    class Ders
    {
        public int Dersid { get; set; }
        public string Dersad { get; set; }

        public int Kontenjan { get; set; }
    }
    class OkulContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        public DbSet<Ders> Dersler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=OkulAppDbSube1;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ders>().ToTable("tblDersler");
            modelBuilder.Entity<Ders>().Property(p => p.Dersad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
        }//Fluent Api

        //public override string ToString()
        //{
        //    return $"Öğrenci Adı:{this.Ad}\nÖğrenci Soyadı:{this.Soyad}";
        //}
        //MVC Model binder araştır
        //öğrenci ekle view oluştur
        //view içerisinde kulanıcıdan veri alma formu(ad soyad)
        //kaydet butonu ile db kaydı
        //projenin son halini githuba yükle
    }
}