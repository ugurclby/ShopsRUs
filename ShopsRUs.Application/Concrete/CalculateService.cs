using ShopsRUs.Application.Abstract;
using ShopsRUs.Domain.Concrete;
using ShopsRUs.Domain.Enums;
using Bogus;
using Bogus.Bson;
using System;
using ShopsRUs.Domain.DTOs;
using ShopsRUs.Domain.Constants;

namespace ShopsRUs.Application.Concrete
{
    public class CalculateService : ICalculateService
    {
        public decimal CalculateDiscount(DiscountDto discountDto)
        {
            // Yüzde bazlı indirimler
            
            decimal percentegeDiscountAmount = discountDto.Amount;
            decimal discountAmount = 0;

            if (discountDto.ProductTypeId== ProductTypeEnum.Other)
            {
                var discountPercentage = discountDto.CustomerTypeId switch
                {
                    CustomerTypeEnum.Employee => CalculateConstans.EmployeeDiscountPercentage,
                    CustomerTypeEnum.Affiliate => CalculateConstans.AffiliateDiscountPercentage,
                    _ => discountDto.DtCustomerRegister <= DateTime.Now.AddYears(-2) ? CalculateConstans.OldCustomerPercentage:0
                };
                percentegeDiscountAmount = discountDto.Amount - (discountDto.Amount * discountPercentage);
            }

            // Tutar indirimi
            
            discountAmount =  Math.Truncate(discountDto.Amount  / CalculateConstans.PerDiscountAmount)*5;

            var sonuc = percentegeDiscountAmount - discountAmount;

            return sonuc;
        }
    }
}
