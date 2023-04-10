using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KT_GK.Document;

namespace KT_GK.Data
{
    public class KT_GKContext : DbContext
    {
        public KT_GKContext (DbContextOptions<KT_GKContext> options)
            : base(options)
        {
        }

        public DbSet<KT_GK.Document.Document> Document { get; set; } = default!;
    }
}
