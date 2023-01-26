namespace Lumia.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; } 
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string RedirecteUrl { get; set; }
        public string ImageUrl { get; set; }   
        public string Title { get; set; }
        public string Desc { get; set; }
        public Catagory catagory { get; set; }

        public List<Position> Positions { get; set; }  
        public List<PotfolioImage> potfolioImages { get; set; }


    }
}
