using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KT_GK.Data;
using KT_GK.Document;

namespace KT_GK.Pages.Documents
{
    public class EditModel : PageModel
    {
        private readonly KT_GK.Data.KT_GKContext _context;

        public EditModel(KT_GK.Data.KT_GKContext context)
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

            var document =  await _context.Document.FirstOrDefaultAsync(m => m.ID == id);
            if (document == null)
            {
                return NotFound();
            }
            Document = document;
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

            _context.Attach(Document).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentExists(Document.ID))
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

        private bool DocumentExists(int id)
        {
          return (_context.Document?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
