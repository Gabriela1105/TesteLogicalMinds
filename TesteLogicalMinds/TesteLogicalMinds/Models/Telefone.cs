using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TesteLogicalMinds.Enums;

namespace TesteLogicalMinds.Models
{
    [Table("Telefone")]
    public class Telefone
    {
        [Column("Id"),Key]
        public int Id { get; set; }
        [Column("NomeContato")]
        public string NomeContato { get; set; }
        [Column("NumeroTelefone")]
        public int NumeroTelefone { get; set; }
        [Column("TipoTelefone")]
        public TipoTelefone TipoTelefone { get; set; }
        [Column("IdCliente"),ForeignKey("Cliente")]
        public int IdCliente { get; set; }
    }
}
