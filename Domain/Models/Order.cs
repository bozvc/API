using System;

namespace CarRental.API.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Phone {get;set;}
        public DateTime OrderDate { get; set; }
        public int AutomobileId { get; set; }
        public Automobile Automobile {  get; set; }
    }
}