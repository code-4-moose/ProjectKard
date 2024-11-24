namespace ProjectKard.Domain
{
    public class Rating : BaseDomainModel
    {
        public string? Description { get; set; }
        
        public double Stars { get; set; }
    }
}
