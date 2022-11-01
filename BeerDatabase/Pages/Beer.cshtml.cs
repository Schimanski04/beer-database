//using BeerDatabase.Data;
//using BeerDatabase.Model;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;

//namespace BeerDatabase.Pages
//{
//    public class BeerModel : PageModel
//    {
//        private readonly ILogger<BeerModel> _logger;
//        private readonly ApplicationDbContext _context;

//        public BeerModel(ILogger<BeerModel> logger, ApplicationDbContext context)
//        {
//            _logger = logger;
//            _context = context;
//        }

//        public List<Beer> Beers { get; set; }

//        public void OnGet()
//        {
//            Beers = _context.Beers.ToList();
//        }
//    }
//}
