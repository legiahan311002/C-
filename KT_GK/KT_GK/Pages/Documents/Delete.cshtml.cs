using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KT_GK.Data;
using KT_GK.Document;

namespace KT_GK.Pages.Documents
{
    public class DeleteModel : PageModel
    {
        private readonly KT_GK.Data.KT_GKContext _context;

        public DeleteModel(KT_GK.Data.KT_GKContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Document Document { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Document == null)
            {
                return NotFound();
            }

            var document = await _context.Document.FirstOrDefaultAsync(m => m.ID == id);

            if (document == null)
            {
                return NotFound();
            }
            else 
            {
                Document = document;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Document == null)
            {
                return NotFound();
            }
            var document = await _context.Document.FindAsync(id);

            if (document != null)
            {
                Document = document;
                _context.Document.Remove(Document);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
