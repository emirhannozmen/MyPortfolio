namespace MyPortfolio.DAL.Entities
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
