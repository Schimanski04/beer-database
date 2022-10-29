using BeerDatabase.Data;
using BeerDatabase.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeerDatabase.Pages
{
    public class EditModel : PageModel
    {
        private readonly ILogger<EditModel> _logger;
        private readonly ApplicationDbContext _context;

        public EditModel(ILogger<EditModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [TempData]
        public string SuccessMessage { get; set; }
        [TempData]
        public string InfoMessage { get; set; }

        [BindProperty]
        public Beer? Beer { get; set; }
        [BindProperty]
        public Brewery? Brewery { get; set; }
        [BindProperty]
        public Pub? Pub { get; set; }

        public List<Brewery> Breweries { get; set; }
        public List<Kind> Kinds { get; set; }


        public string Type { get; set; }
        public int Id { get; set; }

        public ActionResult OnGet(string type, int id)
        {
            Type = type;
            Id = id;

            Breweries = _context.Breweries.ToList();
            Kinds = _context.Kinds.ToList();

            if (Type == "beer")
            {
                Beer = _context.Beers.Find(id);
                if (Beer == null)
                {
                    return NotFound();
                }
            }
            else if (Type == "brewery")
            {
                Brewery = _context.Breweries.Find(id);
                if (Brewery == null)
                {
                    return NotFound();
                }
            }
            else if (Type == "pub")
            {
                Pub = _context.Pubs.Find(id);
                if (Pub == null)
                {
                    return NotFound();
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnPost(string type, int id)
        {
            try
            {
                if (type == "beer")
                {
                    var change = await _context.Beers.FindAsync(id);
                    change.Name = Beer.Name;
                    change.BreweryId = Beer.BreweryId;
                    change.KindId = Beer.KindId;
                    change.Description = Beer.Description;
                    change.AlcoholContent = Beer.AlcoholContent;
                    change.PricePerHalfLitre = Beer.PricePerHalfLitre;
                    change.ImgSrc = Beer.ImgSrc;
                    change.ImgTitle = Beer.ImgTitle;
                }
                else if (type == "brewery")
                {
                    var change = await _context.Breweries.FindAsync(id);
                    change.Name = Brewery.Name;
                    change.Location = Brewery.Location;
                    change.PhoneNumber = Brewery.PhoneNumber;
                    change.Email = Brewery.Email;
                    change.ImgSrc = Brewery.ImgSrc;
                    change.ImgTitle = Brewery.ImgTitle;
                }
                else if (type == "pub")
                {
                    var change = await _context.Pubs.FindAsync(id);
                    change.Name = Pub.Name;
                    change.Location = Pub.Location;
                    change.PhoneNumber = Pub.PhoneNumber;
                    change.Rating = Pub.Rating;
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                InfoMessage = "U položky se v databázi nepodaøilo zmìnit údaje";
                return RedirectToPage("./Index");
            }

            SuccessMessage = "Úspìšnì jste u položky zmìnili údaje v databázi";
            return RedirectToPage("./Index");
        }
    }
}
