using BeerDatabase.Data;
using BeerDatabase.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BeerDatabase.Pages
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
        [TempData]
        public string InfoMessage { get; set; }

        [BindProperty]
        public Beer Beer { get; set; }
        [BindProperty]
        public Brewery Brewery { get; set; }
        [BindProperty]
        public Pub Pub { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Zvolte pivo!")]
        [Range(0, int.MaxValue, ErrorMessage = "Zvolte pivo!")]
        public int SelectBeer { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Zvolte hospodu!")]
        [Range(0, int.MaxValue, ErrorMessage = "Zvolte hospodu!")]
        public int SelectPub { get; set; }

        public List<Beer> Beers { get; set; }
        public List<Brewery> Breweries { get; set; }
        public List<Pub> Pubs { get; set; }
        public List<Kind> Kinds { get; set; }

        public string Type { get; set; }

        public int FlexRadioDefault { get; set; }

        public void OnGet(string type)
        {
            Type = type;

            Beers = _context.Beers.ToList();
            Breweries = _context.Breweries.ToList();
            Pubs = _context.Pubs.ToList();
            Kinds = _context.Kinds.ToList();
        }

        public async Task<IActionResult> OnPostAsync(string type)
        {

            if (!ModelState.IsValid)
            {
                InfoMessage = "Položku se nepodaøilo pøidat do databáze";
                return RedirectToPage("./Index");
            }

            if (type == "beer")
            {
                //Random r = new Random();
                //Beer.KindId = r.Next(1, 6);
                //Beer.AlcoholContent = Math.Round(r.NextDouble() * 100, 1);
                //Beer.PricePerHalfLitre = Math.Round(r.NextDouble() * 100, 1);

                _context.Beers.Add(Beer);
            }
            else if (type == "brewery")
            {
                _context.Breweries.Add(Brewery);
            }
            else if (type == "pub")
            {
                //Random r = new Random();
                //Pub.Rating = Math.Round(r.NextDouble() * 5, 1);

                _context.Pubs.Add(Pub);
            }
            else if (type == "beerpub")
            {
                _context.BeerPubs.Add(new BeerPub { BeerId = SelectBeer, PubId = SelectPub });
            }

            await _context.SaveChangesAsync();

            SuccessMessage = "Položka byla úspìšnì pøidaná do databáze";
            return RedirectToPage("./Index");
        }
    }
}
