using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteLogicalMinds.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Column("Id"),Key]
        public int Id { get; set; }
        [Column("Pais")]
        public string Pais { get; set; }
        [Column("Estado")]
        public string Estado { get; set; }
        [Column("Cidade")]
        public string Cidade { get; set; }
        [Column("CEP")]
        public int CEP { get; set; }
        [Column("Rua")]
        public string Rua { get; set; }
        [Column("Numero")]
        public string Numero { get; set; }
        [Column("Complemento")]
        public string Complemento { get; set; }
        [Column("IdCliente"), ForeignKey("Cliente")]
        public int IdCliente { get; set; }
    }
}
