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
    public class DetailsModel : PageModel
    {
        private readonly KT_GK.Data.KT_GKContext _context;

        public DetailsModel(KT_GK.Data.KT_GKContext context)
        {
            _context = context;
        }

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
    }
}
