using DataLibrary.DataDb;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.SeedData
{
    public class SeedDataApp
    {
        static public void Run()
        {
            //---- inserimento dati in zone
            using (var ctx = new DataDbContext())
            {
                ctx.Zone.Add(new Zona() { Nome = "Nord Est" });
                ctx.Zone.Add(new Zona() { Nome = "Nord Ovest" });
                ctx.Zone.Add(new Zona() { Nome = "Centro" });
                ctx.Zone.Add(new Zona() { Nome = "Sud" });
                ctx.Zone.Add(new Zona() { Nome = "Isole" });
                ctx.SaveChanges();
            }
            //---- inserimento dati in zone
            using (var ctx = new DataDbContext())
            {
                ctx.Clienti.Add(new Cliente() { Nome = "Lazzaroni", ZonaId = 3 });
                ctx.Clienti.Add(new Cliente() { Nome = "Melchionni", ZonaId = 2 });
                ctx.Clienti.Add(new Cliente() { Nome = "Barbari Snc", ZonaId = 1 });
                ctx.Clienti.Add(new Cliente() { Nome = "Singer", ZonaId = 3 });
                ctx.Clienti.Add(new Cliente() { Nome = "Assi Edile slr", ZonaId = 4 });
                ctx.Clienti.Add(new Cliente() { Nome = "Vini del Veneto", ZonaId = 1 });
                ctx.Clienti.Add(new Cliente() { Nome = "Battigia snc", ZonaId = 3 });
                ctx.SaveChanges();
            }


            //---- inserimento dati in zone
            using (var ctx = new DataDbContext())
            {
                ctx.Categorie.Add(new Categoria() { Nome = "Computer" });
                ctx.Categorie.Add(new Categoria() { Nome = "Tastiere" });
                ctx.Categorie.Add(new Categoria() { Nome = "Mouse" });
                ctx.Categorie.Add(new Categoria() { Nome = "Monitor" });
                ctx.Categorie.Add(new Categoria() { Nome = "Stampanti" });
                ctx.SaveChanges();
            }
            //---- inserimento dati in zone
            using (var ctx = new DataDbContext())
            {
                ctx.Prodotti.Add(new Prodotto() { Nome = "HP 4560", Codice= "HP-4560", UnitaMisura="NR",PrezzoUnitario=345,CategoriaId=1});
                ctx.Prodotti.Add(new Prodotto() { Nome = "HP 4760", Codice= "HP-4760", UnitaMisura="NR",PrezzoUnitario=700, CategoriaId = 1 });
                ctx.Prodotti.Add(new Prodotto() { Nome = "Asus Monster", Codice = "AsusMonster", UnitaMisura = "NR", PrezzoUnitario = 700, CategoriaId = 1 });
                ctx.Prodotti.Add(new Prodotto() { Nome = "Monitor Philips 32", Codice = "MonitorPhilips32", UnitaMisura = "NR", PrezzoUnitario = 256, CategoriaId = 1 });
                ctx.Prodotti.Add(new Prodotto() { Nome = "Monitor Philips 27", Codice = "MonitorPhilips27", UnitaMisura = "NR", PrezzoUnitario = 160, CategoriaId = 1 });

                ctx.SaveChanges();
            }

 

        }
    }
}
