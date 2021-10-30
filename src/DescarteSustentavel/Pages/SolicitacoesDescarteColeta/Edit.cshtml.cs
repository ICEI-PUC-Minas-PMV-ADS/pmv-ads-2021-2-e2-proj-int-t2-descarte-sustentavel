using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DescarteSustentavel.Data;
using DescarteSustentavel.Models;

namespace DescarteSustentavel.Pages.SolicitacoesDescarteColeta
{
    public class EditModel : PageModel
    {
        private readonly DescarteSustentavel.Data.DescarteSustentavelContext _context;

        public EditModel(DescarteSustentavel.Data.DescarteSustentavelContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SolicitacaoDescarteColeta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SolicitacaoDescarteColetaExists(SolicitacaoDescarteColeta.SolicitacaoDescarteColetaID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SolicitacaoDescarteColetaExists(int id)
        {
            return _context.SolicitacaoDescarteColeta.Any(e => e.SolicitacaoDescarteColetaID == id);
        }
    }
}
