using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Primeflix.Models;

namespace Primeflix.Data
{
    public class PrimeflixContext : IdentityDbContext
    {
        public PrimeflixContext (DbContextOptions<PrimeflixContext> options)
            : base(options)
        {
        }

        public DbSet<Primeflix.Models.Movie> Movie { get; set; }
    }
}
