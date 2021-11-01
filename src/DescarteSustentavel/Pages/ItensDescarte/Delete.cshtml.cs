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
    public class DeleteModel : PageModel
    {
        private readonly DescarteSustentavel.Data.DescarteSustentavelContext _context;

        public DeleteModel(DescarteSustentavel.Data.DescarteSustentavelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ItemDescarte ItemDescarte { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemDescarte = await _context.ItemDescarte.FirstOrDefaultAsync(m => m.ItemDescarteID == id);

            if (ItemDescarte == null)
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

            ItemDescarte = await _context.ItemDescarte.FindAsync(id);

            if (ItemDescarte != null)
            {
                _context.ItemDescarte.Remove(ItemDescarte);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
