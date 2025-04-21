namespace HouseRent.Core.Domain.Entities
{
    public sealed class Home
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string City { get; set; }
        public string AddressLine { get; set; }
        public string ZipCode { get; set; }
        public List<int> Amenities { get; set; }

    }
}
