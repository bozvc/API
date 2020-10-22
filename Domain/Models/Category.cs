using System.Collections.Generic;

namespace CarRental.API.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Automobile> Automobiles { get; set; } = new List<Automobile>();
    }
}