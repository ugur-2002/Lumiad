namespace Lumia.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Portfolio> portfolios { get; set; }
    }
}
