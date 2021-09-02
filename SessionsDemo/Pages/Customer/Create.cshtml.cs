using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SessionsDemo.Data;
using System.Threading.Tasks;

namespace SessionsDemo.Pages.Customer
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesContactsContext _context;

        public CreateModel(RazorPagesContactsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public SessionsDemo.Models.Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();
            Message = $"Customer {Customer.Name} added";

            return RedirectToPage("./IndexPeek");
        }
    }
}
