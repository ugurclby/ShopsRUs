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
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;
        private readonly IMapper _mapper;

        public ProductTypeController(IProductTypeService productTypeService, IMapper mapper)
        {
            _productTypeService = productTypeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        { 
            var productTypes = _productTypeService.GetAll(); 
            return Ok(CustomResponseDto<IEnumerable<ProductTypeDto>>.Success(_mapper.Map<IEnumerable<ProductTypeDto>>(productTypes)));
        } 
    }
}