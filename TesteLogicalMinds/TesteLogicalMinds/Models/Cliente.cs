using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TesteLogicalMinds.Enums;

namespace TesteLogicalMinds.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id"),Key]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("RG")]
        public string RG { get; set; }
        [Column("CPF")]
        public string CPF { get; set; }
        [Column("DataNascimento")]
        public DateTime DataNascimento  { get; set; }
        [Column("NomeProgenitor1")]
        public  string NomeProgenitor1 { get; set; }
        [Column("NomeProgenitor2")]
        public string NomeProgenitor2 { get; set; }
        [Column("E_mail")]
        public string E_mail { get; set; }
        [Column("Profissao")]
        public string Profissao { get; set; }
        [Column("DataEmissao")]
        public DateTime DataEmissao  { get; set; }
        [Column("Conta")]
        public long Conta { get; set; }
        [Column("Agencia")]
        public int Agencia { get; set; }
        [Column("Pix")]
        public Pix Pix { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }

    }
}
