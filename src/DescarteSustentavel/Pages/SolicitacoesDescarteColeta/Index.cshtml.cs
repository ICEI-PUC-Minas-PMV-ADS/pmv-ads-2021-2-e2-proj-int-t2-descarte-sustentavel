using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DescarteSustentavel.Data;
using DescarteSustentavel.Models;

namespace DescarteSustentavel.Pages.SolicitacoesDescarteColeta
{
    public class IndexModel : PageModel
    {
        private readonly DescarteSustentavel.Data.DescarteSustentavelContext _context;

        public IndexModel(DescarteSustentavel.Data.DescarteSustentavelContext context)
        {
            _context = context;
        }

        public IList<SolicitacaoDescarteColeta> SolicitacaoDescarteColeta { get;set; }

        public async Task OnGetAsync()
        {
            SolicitacaoDescarteColeta = await _context.SolicitacaoDescarteColeta.ToListAsync();
        }
    }
}
