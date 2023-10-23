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
    /// Zone di presenza del cliente
    /// </summary>
    [Table("Zone")]
    internal class Zona
    {
        // PK
        public int ZonaId {  get; set; }
        [MaxLength(50)]
        public string? Nome { get; set;}
    }
}
