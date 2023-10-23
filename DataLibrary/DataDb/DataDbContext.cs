using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataDb
{
    /// <summary>
    /// Gestione del database
    /// DbContext è la classe di EF da cui ereditare 
    /// indipendentemente dal tipo di database utilizzato
    /// </summary>
    internal class DataDbContext:DbContext
    {
        //string connectionString = "Server=localhost;DataBase=Ecom;Trusted_Connection=True";
        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Zona> Zone { get; set; }
        
        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Categoria> Categorie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ReadStringaConnessione());
            base.OnConfiguring(optionsBuilder);
        }
        /// <summary>
        /// legge stringa connessione da progetto di avvio
        /// </summary>
        /// <returns></returns>
        private static string ReadStringaConnessione()
        {
            //** step 1: load file configurazione
           var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            //** step 2  leggfe sezione contenente la stringa di connessione
            var configSection = configBuilder.GetSection("ConnectionStrings");
            //** step 3 legge valore con key SqlServerConnection
            var connectionString = configSection["SqlServerConnection"];
            return connectionString;
        }
    }
}
