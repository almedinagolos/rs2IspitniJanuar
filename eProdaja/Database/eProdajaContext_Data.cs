using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eProdaja.Database
{
    public partial class eProdajaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            //Uloge
            modelBuilder.Entity<Uloge>().HasData(new eProdaja.Database.Uloge()
            {
                UlogaId = 1,
                Naziv = "Administrator"
            });
            modelBuilder.Entity<Uloge>().HasData(new eProdaja.Database.Uloge()
            {
                UlogaId = 2,
                Naziv = "Menadžer"
            });

            //Korisnici
            modelBuilder.Entity<Korisnici>().HasData(new eProdaja.Database.Korisnici()
            {
                KorisnikId = 1,
                Ime = "Test",
                Prezime = "Test",
                Email = "test@fit.ba",
                Telefon = "111/222-333",
                KorisnickoIme = "test",
                LozinkaHash = "HzoOkNHGE27Bfhd/8f1uxeQRCOM=",//test
                LozinkaSalt = "rHh+zm55r5AYhYbSovWIwA==",//test
                Status = true
            });
            modelBuilder.Entity<Korisnici>().HasData(new eProdaja.Database.Korisnici()
            {
                KorisnikId = 2,
                Ime = "Administrator",
                Prezime = "Administrator",
                Email = "admin@fit.ba",
                Telefon = "(   )    -",
                KorisnickoIme = "admin",
                LozinkaHash = "HzoOkNHGE27Bfhd/8f1uxeQRCOM=",//test
                LozinkaSalt = "rHh+zm55r5AYhYbSovWIwA==",//test
                Status = true
            });

            //Kupci
            modelBuilder.Entity<Kupci>().HasData(new eProdaja.Database.Kupci()
            {
                KupacId = 1,
                Ime = "Kupac 1",
                Prezime = "Kupac 1",
                DatumRegistracije = new DateTime(2018, 6, 13, 14, 27, 09, 003, DateTimeKind.Local),
                Email = "kupac1@fit.ba",
                KorisnickoIme = "kupac1",
                LozinkaHash = "HzoOkNHGE27Bfhd/8f1uxeQRCOM=",
                LozinkaSalt = "rHh+zm55r5AYhYbSovWIwA==",
                Status = true
            });
            modelBuilder.Entity<Kupci>().HasData(new eProdaja.Database.Kupci()
            {
                KupacId = 2,
                Ime = "Kupac 2",
                Prezime = "Kupac 2",
                DatumRegistracije = new DateTime(2018, 6, 13, 14, 28, 58, 693, DateTimeKind.Local),
                Email = "kupac2@fit.ba",
                KorisnickoIme = "kupac2",
                LozinkaHash = "HzoOkNHGE27Bfhd/8f1uxeQRCOM=",
                LozinkaSalt = "rHh+zm55r5AYhYbSovWIwA==",
                Status = true
            });
            modelBuilder.Entity<Kupci>().HasData(new eProdaja.Database.Kupci()
            {
                KupacId = 3,
                Ime = "Kupac 3",
                Prezime = "Kupac 3",
                DatumRegistracije = new DateTime(2018, 6, 13, 14, 29, 51, 650, DateTimeKind.Local),
                Email = "kupac3@fit.ba",
                KorisnickoIme = "kupac3",
                LozinkaHash = "HzoOkNHGE27Bfhd/8f1uxeQRCOM=",
                LozinkaSalt = "rHh+zm55r5AYhYbSovWIwA==",
                Status = true
            });

            //KorisniciUloge
            modelBuilder.Entity<KorisniciUloge>().HasData(new eProdaja.Database.KorisniciUloge()
            {
                KorisnikUlogaId = 1,
                DatumIzmjene = new DateTime(2018, 6, 13, 0, 0, 0, 0, DateTimeKind.Local),
                KorisnikId = 1,
                UlogaId = 1
            });
            modelBuilder.Entity<KorisniciUloge>().HasData(new eProdaja.Database.KorisniciUloge()
            {
                KorisnikUlogaId = 2,
                DatumIzmjene = new DateTime(2018, 6, 13, 0, 0, 0, 0, DateTimeKind.Local),
                KorisnikId = 1,
                UlogaId = 2
            });
            modelBuilder.Entity<KorisniciUloge>().HasData(new eProdaja.Database.KorisniciUloge()
            {
                KorisnikUlogaId = 3,
                DatumIzmjene = new DateTime(2018, 6, 13, 14, 19, 17, 883, DateTimeKind.Local),
                KorisnikId = 2,
                UlogaId = 1
            });

            // VrsteProizvoda

            modelBuilder.Entity<VrsteProizvodum>().HasData(Helpers.HelperClass.LoadJsonFromFile<VrsteProizvodum>
                ("VrsteProizvodumJson.json"));

            // Skladista
            modelBuilder.Entity<Skladistum>().HasData(new eProdaja.Database.Skladistum()
            {
                SkladisteId = 1,
                Naziv = "Mostar",
                Adresa = "Mostar"
            });
            modelBuilder.Entity<Skladistum>().HasData(new eProdaja.Database.Skladistum()
            {
                SkladisteId = 2,
                Naziv = "Sarajevo",
                Adresa = "Sarajevo"
            });
            modelBuilder.Entity<Skladistum>().HasData(new eProdaja.Database.Skladistum()
            {
                SkladisteId = 3,
                Naziv = "Tuzla",
                Adresa = "Tuzla"
            });
            // JediniceMjere
            modelBuilder.Entity<JediniceMjere>().HasData(Helpers.HelperClass.LoadJsonFromFile<JediniceMjere>("JediniceMjereJson.json"));

            // Proizvodi
            modelBuilder.Entity<Proizvodi>().HasData(Helpers.HelperClass.LoadJsonFromFile<Proizvodi>
               ("ProizvodiJson.json"));

            // Dobavljaci
            modelBuilder.Entity<Dobavljaci>().HasData(new eProdaja.Database.Dobavljaci()
            {
                DobavljacId = 1,
                Naziv = "Dobavljac 1",
                KontaktOsoba = "Kontakt 1",
                Adresa = "Mostar",
                Telefon = "036/589-998",
                Fax = "036/589-999",
                Web = "www.dobavljac1.com",
                Email = "dobavljac1@fit.ba",
                Status = true
            });
            modelBuilder.Entity<Dobavljaci>().HasData(new eProdaja.Database.Dobavljaci()
            {
                DobavljacId = 2,
                Naziv = "Dobavljac 2",
                KontaktOsoba = "Kontakt 2",
                Adresa = "Sarajevo",
                Telefon = "031/456-654",
                Fax = "034/456-655",
                Web = "www.dobavljac2.com",
                Email = "dobavljac2@fit.ba",
                Status = true
            });
            modelBuilder.Entity<Dobavljaci>().HasData(new eProdaja.Database.Dobavljaci()
            {
                DobavljacId = 3,
                Naziv = "Dobavljac 3",
                KontaktOsoba = "Kontakt 3",
                Adresa = "Tuzla",
                Telefon = "034/589-998",
                Fax = "034/589-999",
                Web = "www.dobavljac3.com",
                Email = "dobavljac3@fit.ba",
                Status = true
            });

            // Izlazi
            // IzlazStavke
            // NarudzbaStavke
            // Narudzbe
            modelBuilder.Entity<Narudzbe>().HasData(new eProdaja.Database.Narudzbe()
            {
               NarudzbaId=1,
               BrojNarudzbe = "AAA",
               KupacId = 1,
               Datum = DateTime.Now,
               Status = true,
               Otkazano = false
            });
            modelBuilder.Entity<Narudzbe>().HasData(new eProdaja.Database.Narudzbe()
            {
                NarudzbaId = 2,
                BrojNarudzbe = "BBB",
                KupacId = 1,
                Datum = DateTime.Now,
                Status = true,
                Otkazano = false
            });
            modelBuilder.Entity<Narudzbe>().HasData(new eProdaja.Database.Narudzbe()
            {
                NarudzbaId = 3,
                BrojNarudzbe = "CCC",
                KupacId = 2,
                Datum = DateTime.Now,
                Status = true,
                Otkazano = false
            });
            modelBuilder.Entity<Narudzbe>().HasData(new eProdaja.Database.Narudzbe()
            {
                NarudzbaId = 4,
                BrojNarudzbe = "DDD",
                KupacId = 2,
                Datum = DateTime.Now,
                Status = true,
                Otkazano = false
            });
            modelBuilder.Entity<NarudzbaStavke>().HasData(new eProdaja.Database.NarudzbaStavke()
            {
               NarudzbaStavkaId = 1,
               NarudzbaId = 1,
               ProizvodId = 1,
               Kolicina = 1
            });
            modelBuilder.Entity<NarudzbaStavke>().HasData(new eProdaja.Database.NarudzbaStavke()
            {
                NarudzbaStavkaId = 2,
                NarudzbaId = 2,
                ProizvodId = 2,
                Kolicina = 2
            });
            modelBuilder.Entity<NarudzbaStavke>().HasData(new eProdaja.Database.NarudzbaStavke()
            {
                NarudzbaStavkaId = 3,
                NarudzbaId = 3,
                ProizvodId = 3,
                Kolicina = 3
            });
            modelBuilder.Entity<NarudzbaStavke>().HasData(new eProdaja.Database.NarudzbaStavke()
            {
                NarudzbaStavkaId = 4,
                NarudzbaId = 4,
                ProizvodId = 4,
                Kolicina = 4
            });
            modelBuilder.Entity<NarudzbaStavke>().HasData(new eProdaja.Database.NarudzbaStavke()
            {
                NarudzbaStavkaId = 5,
                NarudzbaId = 1,
                ProizvodId = 2,
                Kolicina = 2
            });
            // Ocjene
            // Ulazi
            // UlazStavke
            //PregledNarudzbi
            modelBuilder.Entity<Izlazi>().HasData(new eProdaja.Database.Izlazi()
            {
               IzlazId = 1,
               BrojRacuna = "AAA",
               Datum = DateTime.Now,
               KorisnikId = 1,
               Zakljucen = false,
               IznosBezPdv = 950,
               IznosSaPdv = 1000,
               NarudzbaId = 1,
               SkladisteId = 1
            });
            modelBuilder.Entity<Izlazi>().HasData(new eProdaja.Database.Izlazi()
            {
                IzlazId = 2,
                BrojRacuna = "BBB",
                Datum = DateTime.Now,
                KorisnikId = 1,
                Zakljucen = false,
                IznosBezPdv = 950,
                IznosSaPdv = 1000,
                NarudzbaId = 2,
                SkladisteId = 2
            });
            modelBuilder.Entity<Izlazi>().HasData(new eProdaja.Database.Izlazi()
            {
                IzlazId = 3,
                BrojRacuna = "CCC",
                Datum = DateTime.Now,
                KorisnikId = 1,
                Zakljucen = false,
                IznosBezPdv = 950,
                IznosSaPdv = 1000,
                NarudzbaId = 3,
                SkladisteId = 1
            });
            modelBuilder.Entity<Izlazi>().HasData(new eProdaja.Database.Izlazi()
            {
                IzlazId = 4,
                BrojRacuna = "DDD",
                Datum = DateTime.Now,
                KorisnikId = 1,
                Zakljucen = false,
                IznosBezPdv = 950,
                IznosSaPdv = 1000,
                NarudzbaId = 4,
                SkladisteId = 1
            });
            modelBuilder.Entity<PregledNarudzbi>().HasData(new eProdaja.Database.PregledNarudzbi()
            {
               PregledNarudzbiId = 1,
               KupciId = 1,
               ProizvodiId = 1,
               MinIznosNarudzbe = 10,
               DatumOd = DateTime.Now.AddDays(-10),
               DatumDo = DateTime.Now,
               BrojNarudzbe ="AAA",
               IznosNarudzbe = 1000
            });
            modelBuilder.Entity<PregledNarudzbi>().HasData(new eProdaja.Database.PregledNarudzbi()
            {
                PregledNarudzbiId = 2,
                KupciId = 2,
                ProizvodiId = 2,
                MinIznosNarudzbe = 10,
                DatumOd = DateTime.Now.AddDays(-10),
                DatumDo = DateTime.Now,
                BrojNarudzbe = "BBB",
                IznosNarudzbe = 1000
            });

            //Add-Migration InitData
        }
    }
}

