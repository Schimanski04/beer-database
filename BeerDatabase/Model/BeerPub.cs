using Microsoft.Extensions.Hosting;

namespace BeerDatabase.Model
{
    public class BeerPub
    {
        public int BeerId { get; set; }
        public Beer Beer { get; set; }

        public int PubId { get; set; }
        public Pub Pub { get; set; }
    }
}
