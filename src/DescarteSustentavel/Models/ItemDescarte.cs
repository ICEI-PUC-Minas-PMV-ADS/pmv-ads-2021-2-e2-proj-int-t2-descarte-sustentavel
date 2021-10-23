using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DescarteSustentavel.Models
{
    public class ItemDescarte
    {
        [Key]
        public int IDItem { get; set; }

        [StringLength(15, MinimumLength = 3), Display(Name = "Tipo do Item"), Required]
        public string tipoDoItem { get; set; }

        [StringLength(15, MinimumLength = 3), Display(Name = "Descrição do Item"), Required]
        public string descricaoDoItem { get; set; }

        public ItemDescarte(int iDItem, string tipoDoItem, string descricaoDoItem)
        {
            IDItem = iDItem;
            this.tipoDoItem = tipoDoItem;
            this.descricaoDoItem = descricaoDoItem;
        }
    }
}
