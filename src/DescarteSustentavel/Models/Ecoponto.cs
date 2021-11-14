using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DescarteSustentavel.Models
{
    [Table("Ecoponto")]
    public class Ecoponto : Usuario
    {
        [Display(Name = "Identificador do Ecoponto"), Column("IdEcoponto"),
            DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdEcoponto { get; set; }

        [StringLength(50, MinimumLength = 3), Display(Name = "CPF CNPJ"), Required, Column("cpfCnpj")]
        public string CpfCnpj { get; set; }

        [StringLength(50, MinimumLength = 3), Display(Name = "Tipo"), Required, Column("tipo")]
        public string Tipo { get; set; }

        public override string ToString()
        {
            return Nome + ": " + Email + ": " + Senha + ": " + Endereco + ": " + Tipo + ": " + CpfCnpj;
        }
    }
}
