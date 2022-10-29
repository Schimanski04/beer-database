using BeerDatabase.Data;
using BeerDatabase.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BeerDatabase.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ILogger<DeleteModel> _logger;
        private readonly ApplicationDbContext _context;

        public DeleteModel(ILogger<DeleteModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [TempData]
        public string SuccessMessage { get; set; }
        [TempData]
        public string InfoMessage { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Zvolte vazbu")]
        public string Select { get; set; }

        public List<Beer> Beers { get; set; }
        public List<Pub> Pubs { get; set; }
        public List<BeerPub> BeerPubs { get; set; }

        public string Type { get; set; }
        public int Id { get; set; }

        public void OnGet(string type, int id)
        {
            Type = type;
            Id = id;

            Beers = _context.Beers.ToList();
            Pubs = _context.Pubs.ToList();
            BeerPubs = _context.BeerPubs.ToList();
        }

        public async Task<IActionResult> OnGetDelete(string type, int id)
        {
            Beers = _context.Beers.ToList();
            BeerPubs = _context.BeerPubs.ToList();

            try
            {
                if (type == "beer")
                {
                    foreach (var bp in BeerPubs)
                    {
                        if (bp.BeerId == id)
                        {
                            _context.BeerPubs.Remove(bp);
                        }
                    }
                    _context.Beers.Remove(await _context.Beers.FindAsync(id));
                }
                else if (type == "brewery")
                {
                    foreach (var b in Beers)
                    {
                        if (b.BreweryId == id)
                        {
                            foreach (var bp in BeerPubs)
                            {
                                if (bp.BeerId == b.BeerId)
                                {
                                    _context.BeerPubs.Remove(bp);
                                }
                            }
                            _context.Beers.Remove(b);
                        }
                    }
                    _context.Breweries.Remove(await _context.Breweries.FindAsync(id));
                }
                else if (type == "pub")
                {
                    foreach (var bp in BeerPubs)
                    {
                        if (bp.PubId == id)
                        {
                            _context.BeerPubs.Remove(bp);
                        }
                    }
                    _context.Pubs.Remove(await _context.Pubs.FindAsync(id));
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                InfoMessage = "Odstranìní položky se nepodaøilo";
                return RedirectToPage("./Index");
            }

            SuccessMessage = "Úspìšnì jste položku odstranili z databáze";
            return RedirectToPage("./Index");
        }

        public ActionResult OnPost()
        {
            try
            {
                string[] subs = Select.Split(';');
            
                var beerpub = new BeerPub { BeerId = Int32.Parse(subs[0]), PubId = Int32.Parse(subs[1]) };
                _context.BeerPubs.Remove(beerpub);

                _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                InfoMessage = "Odstranìní položky se nepodaøilo";
                return RedirectToPage("./Index");
            }

            SuccessMessage = "Úspìšnì jste položku odstranili z databáze";
            return RedirectToPage("./Index");
        }

        public ActionResult OnGetCancel()
        {
            InfoMessage = "Pokus o odstranìní položky byl zrušen";
            return RedirectToPage("./Index");
        }
    }
}
