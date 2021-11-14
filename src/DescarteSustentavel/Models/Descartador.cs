using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DescarteSustentavel.Models
{
    [Table("Descartador")]
    public class Descartador : Usuario
    {
        [Display(Name = "Identificador do Descartador"), Column("idDescartador"),
            DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdDescartador { get; set; }

        [Display(Name = "Data de cadastro"), DataType(DataType.Date), Column("dataCadastro")]
        public DateTime DataDeCadastro { get; set; }

        [Display(Name = "Quantidade de Solicitacoes"),  Column("qntSolicitacoes")]
        public int QntSolicitacoes { get; set; }

        public override string ToString()
        {
            return IdDescartador + ": " + DataDeCadastro + ": " + QntSolicitacoes + ": " + IdUsuario+ ": " + Nome + ": " + Email + ": " + Senha + ": " + Endereco + ": "+ Telefone;
        }
    }
}
