using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SessionsDemo.Data;

namespace SessionsDemo.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesContactsContext _context;

        public IndexModel(RazorPagesContactsContext context)
        {
            _context = context;
        }

        public IList<SessionsDemo.Models.Customer> Customer { get; set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
