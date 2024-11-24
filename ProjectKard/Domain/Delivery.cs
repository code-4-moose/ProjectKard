namespace ProjectKard.Domain
{
    public class Delivery : BaseDomainModel
    {
        public string? AddressFrom { get; set; }
        public string? AddressTo { get; set; }
        public double DeliveryFee { get; set; }
        public string? BuyerId { get; set; }

    }
}
