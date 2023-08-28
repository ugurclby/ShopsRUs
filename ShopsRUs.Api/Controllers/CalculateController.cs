using AutoMapper;
using Bogus;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ShopsRUs.Api.Models;
using ShopsRUs.Api.Validation;
using ShopsRUs.Application.Abstract;
using ShopsRUs.Application.Concrete;
using ShopsRUs.Domain.Concrete;
using ShopsRUs.Domain.DTOs;

namespace ShopsRUs.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        private readonly ICalculateService _calculateService;
        private readonly IMapper _mapper;
        public CalculateController(ICalculateService calculateService, IMapper mapper)
        {
            _calculateService = calculateService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult GetCalculateDiscount(GetDiscountModel getDiscountModel)
        {
            var validator = new CalculateValidator();
            var results = validator.Validate(getDiscountModel); 
            
            if (!results.IsValid)
            {
                List<string> errorList = new List<string>();
                foreach (var failure in results.Errors)
                {
                    errorList.Add(failure.ErrorMessage); 
                } 
                return BadRequest(CustomResponseDto<decimal>.Fail(errorList));
            }
            
            return Ok(CustomResponseDto<decimal>.Success(_calculateService.CalculateDiscount(_mapper.Map<DiscountDto>(getDiscountModel))));
        }
    }
}