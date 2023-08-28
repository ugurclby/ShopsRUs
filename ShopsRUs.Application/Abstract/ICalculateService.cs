using ShopsRUs.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Application.Abstract
{
    public interface ICalculateService
    {
        decimal CalculateDiscount(DiscountDto discountDto);
    }
}
