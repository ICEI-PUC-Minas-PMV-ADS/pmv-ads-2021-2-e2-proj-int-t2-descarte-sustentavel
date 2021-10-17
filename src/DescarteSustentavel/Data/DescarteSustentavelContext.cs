using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DescarteSustentavel.Models;

namespace DescarteSustentavel.Data
{
    public class DescarteSustentavelContext : DbContext
    {
        public DescarteSustentavelContext (DbContextOptions<DescarteSustentavelContext> options)
            : base(options)
        {
        }

        public DbSet<DescarteSustentavel.Models.ItemDescarte> ItemDescarte { get; set; }

        public DbSet<DescarteSustentavel.Models.SolicitacaoDescarteColeta> SolicitacaoDescarteColeta { get; set; }
    }
}
