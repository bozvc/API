using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using CarRental.API.Domain.Models;
using CarRental.API.Domain.Services;
using CarRental.API.Resources;

namespace CarRental.API.Controllers
{
    [Route("/api/[controller]")]
    public class AutomobilesController : Controller
    {
        private readonly IAutomobileService _automobileService;
        private readonly IMapper _mapper;

        public AutomobilesController(IAutomobileService automobileService , IMapper mapper)
        {
            _automobileService = automobileService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AutomobileResource>> ListAsync()
        {
            var automobiles = await _automobileService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Automobile>, IEnumerable<AutomobileResource>>(automobiles);
            return resources;
        }
       
    }
}