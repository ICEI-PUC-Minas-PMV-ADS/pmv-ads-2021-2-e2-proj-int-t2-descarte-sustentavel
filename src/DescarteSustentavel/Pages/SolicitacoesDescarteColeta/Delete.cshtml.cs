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
    public class DeleteModel : PageModel
    {
        private readonly DescarteSustentavel.Data.DescarteSustentavelContext _context;

        public DeleteModel(DescarteSustentavel.Data.DescarteSustentavelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SolicitacaoDescarteColeta SolicitacaoDescarteColeta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SolicitacaoDescarteColeta = await _context.SolicitacaoDescarteColeta.FirstOrDefaultAsync(m => m.SolicitacaoDescarteColetaID == id);

            if (SolicitacaoDescarteColeta == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SolicitacaoDescarteColeta = await _context.SolicitacaoDescarteColeta.FindAsync(id);

            if (SolicitacaoDescarteColeta != null)
            {
                _context.SolicitacaoDescarteColeta.Remove(SolicitacaoDescarteColeta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
