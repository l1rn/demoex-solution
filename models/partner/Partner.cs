namespace application.models.partner
{
    public class Partner
    {
        public int id { get; set; }
        
        public string address { get; set; } = null!;

        public long INN { get; set; }

        public string directorName { get; set; } = null!;

        public string phone { get; set; } = null!;
        public string email { get; set; } = null!;

        public string logo { get; set; } = null!;

        public double rating { get; set; }
        public PartnerType partnerType { get; set; } = null!;

        public PlaceForSale placeForSale { get; set; } = null!;

    }
}
