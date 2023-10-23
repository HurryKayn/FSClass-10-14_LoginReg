using Microsoft.EntityFrameworkCore;
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
    /// Anagrafica Prodotti
    /// </summary>
    [Table("Prodotti")]
    internal class Prodotto
    {
        // PK
        public int ProdottoId { get; set; }
        [MaxLength(23)]
        public string Codice {  get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(3)]
        public string UnitaMisura { get; set; }
        public int  CategoriaId { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal PrezzoUnitario { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal Peso { get; set; }
    }
}
