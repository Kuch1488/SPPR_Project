namespace OSM.Models
{
    public class CompleteAddress
    {
		public string Latitude { get; set; } = null!;
		public string Longitude { get; set; } = null!;

		public string Country { get; set; } = null!;
		public string State { get; set; } = null!;
		public string City { get; set; } = null!;

		public string Street { get; set; } = null!;
		public string HouseNumber { get; set; } = null!;
		public string PostCode { get; set; } = null!;
		public string Building { get; set; } = null!;
		public string BuildingLevel { get; set; } = null!;
	}
}
