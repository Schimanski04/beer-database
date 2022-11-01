//using BeerDatabase.Data;
//using BeerDatabase.Model;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;

//namespace BeerDatabase.Pages
//{
//    public class BreweryModel : PageModel
//    {
//        private readonly ILogger<BreweryModel> _logger;
//        private readonly ApplicationDbContext _context;

//        public BreweryModel(ILogger<BreweryModel> logger, ApplicationDbContext context)
//        {
//            _logger = logger;
//            _context = context;
//        }

//        public List<Brewery> Breweries { get; set; }

//        public void OnGet()
//        {
//            Breweries = _context.Breweries.ToList();
//        }
//    }
//}
