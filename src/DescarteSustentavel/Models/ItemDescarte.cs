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

        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string tipoDoItem { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string descricaoDoItem { get; set; }

    }
}
