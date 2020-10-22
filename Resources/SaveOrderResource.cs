using System.ComponentModel.DataAnnotations;
using System;

namespace CarRental.API.Resources
{
    public class SaveOrderResource
    {
        [Required]
        [MaxLength(30)]
        public string FirstName {get;set;}
        [Required]
        [MaxLength(30)]
        public string LastName {get;set;}
        [PhoneAttribute]
        [MaxLength(8)]
        public string Phone {get;set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [Required]
        public int AutomobileId {get;set;}
    }
}