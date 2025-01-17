using CarRental.API.Domain.Models;

namespace CarRental.API.Domain.Services.Communication
{
    public class OrderResponse : BaseResponse
    {
        public Order Order { get; private set; }

        private OrderResponse(bool success, string message, Order order) : base(success, message)
        {
            Order = order;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="category">Saved category.</param>
        /// <returns>Response.</returns>
        public OrderResponse(Order order) : this(true, string.Empty, order)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public OrderResponse(string message) : this(false, message, null)
        { }
    }
}