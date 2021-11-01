using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DescarteSustentavel.Models
{
    public class ItemDescarte
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("id_item")]
        public int ItemDescarteID { get; set; }

        [StringLength(15, MinimumLength = 3), Display(Name = "Tipo do Item"), Required, Column("tipo_item")]
        public string TipoDoItem { get; set; }

        [StringLength(15, MinimumLength = 3), Display(Name = "Descrição do Item"), Required, Column("descricao_item")]
        public string DescricaoDoItem { get; set; }

        [Column("id_solicitacao_descarte_coleta")]
        public int SolicitacaoDescarteColetaID { get; set; }

        public SolicitacaoDescarteColeta SolicitacaoDescarteColeta { get; set; }

    }
}
