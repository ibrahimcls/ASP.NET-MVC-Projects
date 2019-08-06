using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace mvcEntityF_CodeFirst.Models.Manager
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Kisi> kisiler { get; set; }
        public DbSet<Adres> adresler { get; set; }

        public DatabaseContext(){
            Database.SetInitializer(new VeritabanıOlusturucu());
        }
    }
    public class VeritabanıOlusturucu : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                Kisi kisi = new Kisi();
                kisi.Ad = FakeData.NameData.GetFirstName();
                kisi.soyad = FakeData.NameData.GetSurname();
                kisi.yas = FakeData.NumberData.GetNumber(10, 90);

                context.kisiler.Add(kisi);
            }
            context.SaveChanges();

            List<Kisi> tumkisiler =context.kisiler.ToList();

            foreach (Kisi thkisi  in tumkisiler)
            {
                for (int i = 0; i < FakeData.NumberData.GetNumber(1,3); i++)
                {
                    Adres adres = new Adres();
                    adres.adreskisi = thkisi;
                    adres.AdresTanım = FakeData.PlaceData.GetAddress();
                    context.adresler.Add(adres);
                }
                context.SaveChanges();

            }
        }
    }
}