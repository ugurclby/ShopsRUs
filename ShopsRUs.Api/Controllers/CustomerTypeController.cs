using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopsRUs.Application.Abstract;
using ShopsRUs.Application.Concrete;
using ShopsRUs.Domain.Concrete;
using ShopsRUs.Domain.DTOs;

namespace ShopsRUs.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerTypeController : ControllerBase
    {
        private readonly ICustomerTypeService _customerTypeService;
        private readonly IMapper _mapper;

        public CustomerTypeController(ICustomerTypeService customerTypeService, IMapper mapper)
        {
            _customerTypeService = customerTypeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        { 
            var customerTypes = _customerTypeService.GetAll();
            return Ok(CustomResponseDto<IEnumerable<CustomerTypeDto>>.Success( _mapper.Map<IEnumerable<CustomerTypeDto>>(customerTypes)));
        }
    }
}