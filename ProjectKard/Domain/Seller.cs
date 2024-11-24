namespace ProjectKard.Domain
{
    public class Seller : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Contact { get; set; }
        public double Stars { get; set; }

        public string? RatingId { get; set; }

    }
}
