using BeerDatabase.Data;
using BeerDatabase.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeerDatabase.Areas.Beers.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        private readonly ApplicationDbContext _context;

        public CreateModel(ILogger<CreateModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [TempData]
        public string SuccessMessage { get; set; }

        [BindProperty]
        public Beer Beer { get; set; }

        public List<Brewery> Breweries { get; set; }
        public List<Kind> Kinds { get; set; }

        public void OnGet()
        {
            Breweries = _context.Breweries.ToList();
            Kinds = _context.Kinds.ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Breweries = _context.Breweries.ToList();
                Kinds = _context.Kinds.ToList();
                return Page();
            }
            else
            {
                _context.Beers.Add(Beer);

                await _context.SaveChangesAsync();

                SuccessMessage = "Polo�ka byla �sp�n� p�idan� do datab�ze";
                return RedirectToPage("./Index");
            }
        }
    }
}
