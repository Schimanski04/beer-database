using BeerDatabase.Data;
using BeerDatabase.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeerDatabase.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ILogger<DetailsModel> _logger;
        private readonly ApplicationDbContext _context;

        public DetailsModel(ILogger<DetailsModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public Beer? Beer { get; set; }
        public Brewery? Brewery { get; set; }
        public Pub? Pub { get; set; }
        public Kind? Kind { get; set; }

        public string Type { get; set; }
        public int Id { get; set; }

        public ActionResult OnGet(string type, int id)
        {
            Type = type;
            Id = id;

            if (Type == "beer")
            {
                Beer = _context.Beers.Find(id);
                if (Beer == null)
                {
                    return NotFound();
                }

                Brewery = _context.Breweries.Find(Beer.BreweryId);
                Kind = _context.Kinds.Find(Beer.KindId);

                _context.Entry(Beer).Collection(p => p.Pubs).Load();
            }
            else if (Type == "brewery")
            {
                Brewery = _context.Breweries.Find(id);
                if (Brewery == null)
                {
                    return NotFound();
                }
                _context.Entry(Brewery).Collection(b => b.Beers).Load();
            }
            else if (Type == "pub")
            {
                Pub = _context.Pubs.Find(id);
                if (Pub == null)
                {
                    return NotFound();
                }

                _context.Entry(Pub).Collection(b => b.Beers).Load();
            }

            return Page();
        }
    }
}
