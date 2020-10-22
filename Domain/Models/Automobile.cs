namespace CarRental.API.Domain.Models
{
    public class Automobile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfOccupants { get; set; }
        public bool AutomaticTransmission { get; set; }
        public bool Rented { get; set; }
        public EFuelType FuelType { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}