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
    public class IndexModel : PageModel
    {
        private readonly KT_GK.Data.KT_GKContext _context;

        public IndexModel(KT_GK.Data.KT_GKContext context)
        {
            _context = context;
        }

        public IList<Document> Document { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Document != null)
            {
                Document = await _context.Document.ToListAsync();
            }
        }
    }
}
