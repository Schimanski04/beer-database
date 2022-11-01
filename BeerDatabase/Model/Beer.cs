using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace BeerDatabase.Model
{
    public class Beer
    {
        [Key]
        public int BeerId { get; set; }

        [Required(ErrorMessage = "Zadejte název piva!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Přidejte popis vlastností a chutí piva!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Zadejte množství alkoholu v pivu!")]
        [Range(0, 100, ErrorMessage = "Zadejte reálné množství alkoholu v pivu! (min. 0%, max. 100%)")]
        public double AlcoholContent { get; set; }

        [Required(ErrorMessage = "Zadejte cenu piva!")]
        public double PricePerHalfLitre { get; set; }

        [Required(ErrorMessage = "Zadejte adresu náhledového obrázku!")]
        public string ImgSrc { get; set; }

        [Required(ErrorMessage = "Zadejte popis náhledového obrázku!")]
        public string ImgTitle { get; set; }


        // Vztahy mezi tabulkami
        // 1:N
        [Required(ErrorMessage = "Vyberte pivovar!")]
        public int BreweryId { get; set; }
        public Brewery Brewery { get; set; }

        // 1:N
        //[Required(ErrorMessage = "Vyberte druh piva!")]
        public int KindId { get; set; }
        public Kind Kind { get; set; }

        // N:M
        public List<Pub> Pubs { get; set; }
    }
}
