using System.ComponentModel.DataAnnotations;

namespace BeerDatabase.Model
{
    public class Pub
    {
        [Key]
        public int PubId { get; set; }

        [Required(ErrorMessage = "Zadejte název hospody!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Zadejte město, ve kterém se hospoda nachází!")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Zadejte telefonní číslo do hospody!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Zadejte hodnocení podniku!")]
        public double Rating { get; set; } // pomocí této vlastnosti by si mohl admin seřadit podniky dle hodnocení


        // Vztahy mezi tabulkami
        // N:M
        public List<Beer> Beers { get; set; }
    }
}
