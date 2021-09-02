using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SessionsDemo.Data;
using System.Threading.Tasks;

namespace SessionsDemo.Pages.Customer
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesContactsContext _context;

        public DetailsModel(RazorPagesContactsContext context)
        {
            _context = context;
        }

        public SessionsDemo.Models.Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Customer = await _context.Customer.FindAsync(id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
