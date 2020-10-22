

namespace CarRental.API.Resources
{
    public class AutomobileResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfOccupants { get; set; }
        public bool AutomaticTransmission { get; set; }
        public bool Rented { get; set; }
        public string FuelType { get; set; }
        public CategoryResource Category {get;set;}
    }
}