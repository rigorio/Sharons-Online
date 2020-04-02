using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesSystem.Models;

namespace SalesSystem.Data
{
    public class SalesSystemContext : DbContext
    {
        public SalesSystemContext (DbContextOptions<SalesSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Sale> Sale { get; set; }
        public DbSet<Gown> Gowns { get; set; }
    }
}
