using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Domain.Models;
using CarRental.API.Domain.Repositories;
using CarRental.API.Domain.Services;
using CarRental.API.Domain.Services.Communication;

namespace CarRental.API.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Order>> ListAsync()
        {
            return await _orderRepository.ListAsync();
        }

        public async Task<OrderResponse> SaveAsync(Order order)
        {
            try
            {
                await _orderRepository.AddAsync(order);
                await _unitOfWork.CompleteAsync();
                
                return new OrderResponse(order);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new OrderResponse($"An error occurred when saving the category: {ex.Message}");
            }
        }

    }
}