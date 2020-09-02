using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URL_Shortener.Models;

namespace URL_Shortener.DatabaseContexts
{
    public class URLContext : DbContext
    {
        public URLContext(DbContextOptions<URLContext> options) : base(options) { }

        public DbSet<URL> UrlSet { get; set; }

        public DbSet<User> UserSet { get; set; }
    }
}
