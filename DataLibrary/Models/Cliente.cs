using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// Anagrafica Clienti
    /// </summary>
    [Table("Clienti")]
    internal class Cliente
    {
        //PK --> AutoIncrement
        public int ClienteId { get; set; }
        [MaxLength(50)]
        public string Nome { get; set;}
        [MaxLength(50)]
        public string? Cognome { get; set;}
        [MaxLength(150)]
        public string? Email { get; set;}
        [MaxLength(16)]
        public string? CodiceFiscale { get; set;}
        [MaxLength(11)]
        public string? PartitaIVA { get; set;}
        [MaxLength(50)]
        public string? Indirizzo { get; set; }
        [MaxLength(50)]
        public string? Localita { get; set; }
        [MaxLength(2)]
        public string? Provincia { get; set; }
        [MaxLength(5)]
        public string? Cap { get; set; }
        public int ZonaId { get; set; } 

    }
}

