using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using CarRental.API.Domain.Models;
using CarRental.API.Domain.Services;
using CarRental.API.Resources;
using CarRental.API.Extensions;

namespace CarRental.API.Controllers
{
    [Route("/api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService , IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderResource>> GetAllAsync()
        {
            var orders = await _orderService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Order>, IEnumerable<OrderResource>>(orders);
            
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveOrderResource resource)
        {
	        if (!ModelState.IsValid)
		        return BadRequest(ModelState.GetErrorMessages());

	        var order = _mapper.Map<SaveOrderResource, Order>(resource);
            var result = await _orderService.SaveAsync(order);

	        if (!result.Success)
		        return BadRequest(result.Message);

	        var orderResource = _mapper.Map<Order, OrderResource>(result.Order);

	        return Ok(orderResource);
        }
       
    }
}