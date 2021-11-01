using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DescarteSustentavel.Data;
using DescarteSustentavel.Models;

namespace DescarteSustentavel.Pages.ItensDescarte
{
    public class IndexModel : PageModel
    {
        private readonly DescarteSustentavel.Data.DescarteSustentavelContext _context;

        public IndexModel(DescarteSustentavel.Data.DescarteSustentavelContext context)
        {
            _context = context;
        }

        public IList<ItemDescarte> ItensDescarte { get;set; }

        public async Task OnGetAsync()
        {
            ItensDescarte = await _context.ItemDescarte
                .Include(i => i.SolicitacaoDescarteColeta)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
