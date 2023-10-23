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
    /// Categorai di appartenenza di un prodotto
    /// </summary>
    [Table("Categorie")]
    internal class Categoria
    {
        //PK
        public int CategoriaId { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
    }
}
