namespace Lumia.Models
{
    public class PotfolioImage
    {
        public int Id { get; set; }
        public int PortfolioId { get; set; }
        public string ImageUrl { get; set; }
        public Portfolio portfolio { get; set; }


    }
}
