using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DescarteSustentavel.Models
{
    public class SolicitacaoDescarteColeta
    {
        //[Range (00101, 10000)]
        [Key ,Display(Name = "Número da Solicitação")]
        public int IDSolicitacao { get; set; }

        [Display(Name = "Descartador")]
        public int IDDescartador { get; set; }

        [Display(Name = "Ecoponto Responsável")]
        public int IDEcoponto { get; set; }

        [Display(Name = "Tipo do Material"), StringLength(15, MinimumLength =3), Required]
        public string TipoDoMaterial { get; set; }

        [Display(Name = "Data da Solicitação"), DataType(DataType.Date)]
        public DateTime DataDaSolicitacao { get; set; }

        [Display(Name = "Quantidade de Itens"), Range(1, 10)]
        public int QtdeDeItens { get; set; }

        [Display(Name = "Data de Encerramento"), DataType(DataType.Date)]
        public DateTime? DataDeEncerramento { get; set; }

        public enum StatusDaSolicitacao { Pendente, EmAndamento, Cancelada, Finalizada }
        public ICollection<ItemDescarte> ItensDescarte { get; set; }

    }
}
