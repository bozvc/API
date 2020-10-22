using System.ComponentModel;

namespace CarRental.API.Domain.Models
{
    public enum EFuelType : byte
    {
        [Description("GASOLINE")]
        Gasoline = 1,

        [Description("DIESEL")]
        Diesel = 2,
        
    }
}