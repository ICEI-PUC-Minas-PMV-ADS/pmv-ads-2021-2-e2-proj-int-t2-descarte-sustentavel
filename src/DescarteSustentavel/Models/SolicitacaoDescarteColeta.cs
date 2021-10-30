using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DescarteSustentavel.Models
{
    public class SolicitacaoDescarteColeta
    {
        //[Range (00101, 10000)]
        [Display(Name = "Número da Solicitação"), Column("id_solicitacao")]
        public int SolicitacaoDescarteColetaID { get; set; }

        [Display(Name = "Descartador"), Column("descartador")]
        public int IDDescartador { get; set; }

        [Display(Name = "Ecoponto Responsável"), Column("ecoponto")]
        public int IDEcoponto { get; set; }

        [Display(Name = "Tipo do Material"), StringLength(15, MinimumLength =3), Required, Column("tipo_material")]
        public string TipoDoMaterial { get; set; }

        [Display(Name = "Quantidade de Itens"), Range(1, 10), Column("qtd_itens")]
        public int QtdeDeItens { get; set; }

        [Display(Name = "Tipo de Solicitacao"), Required, Column("tipo_solicitacao")]
        public char TipoDeSolicitacao { get; set; }

        [Display(Name = "Data da Solicitação"), DataType(DataType.Date), Column("data_solicitacao")]
        public DateTime DataDaSolicitacao { get; set; }

        [Display(Name = "Data de Encerramento"), DataType(DataType.Date), Column("data_encerramento")]
        public DateTime? DataDeEncerramento { get; set; }

        //public IEnumerable<int> StatusDaSolicitacao = { Pendente, EmAndamento, Cancelada, Finalizada }
        public IList<ItemDescarte> ItensDescarte { get; set; }

        [Display(Name = "Data Prevista de Entrega"), DataType(DataType.Date), Column("data_entrega")]
        public DateTime? DataDeEntrega { get; set; }

    }
}
