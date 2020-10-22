using System;

namespace CarRental.API.Resources
{
    public class OrderResource
    {
        public int Id { get; set; }
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Phone {get;set;}
        public DateTime OrderDate { get; set; }
        public AutomobileResource Automobile {get;set;}


    }
}