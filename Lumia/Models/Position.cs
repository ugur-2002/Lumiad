namespace Lumia.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio portfolio { get; set; }
    }
}
