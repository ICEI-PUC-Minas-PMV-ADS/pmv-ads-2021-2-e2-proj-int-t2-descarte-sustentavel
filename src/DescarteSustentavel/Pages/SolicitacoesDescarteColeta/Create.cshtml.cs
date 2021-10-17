using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DescarteSustentavel.Data;
using DescarteSustentavel.Models;

namespace DescarteSustentavel.Pages.SolicitacoesDescarteColeta
{
    public class CreateModel : PageModel
    {
        private readonly DescarteSustentavel.Data.DescarteSustentavelContext _context;

        public CreateModel(DescarteSustentavel.Data.DescarteSustentavelContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SolicitacaoDescarteColeta SolicitacaoDescarteColeta { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SolicitacaoDescarteColeta.Add(SolicitacaoDescarteColeta);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
