using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SessionsDemo.Models;

namespace SessionsDemo.Data
{
    public class RazorPagesContactsContext : DbContext
    {
        public RazorPagesContactsContext(DbContextOptions<RazorPagesContactsContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}
