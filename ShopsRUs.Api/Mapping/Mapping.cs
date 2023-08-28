using AutoMapper; 

namespace ShopsRUs.Domain.Mapping
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<DTOs.ProductTypeDto, Concrete.ProductType>().ReverseMap().ForMember(x=>x.ProductTypeId,y=>y.MapFrom(z=>z.Id));
            CreateMap<DTOs.CustomerTypeDto, Concrete.CustomerType>().ReverseMap().ForMember(x => x.CustomerTypeId, y => y.MapFrom(z => z.Id));
            CreateMap<DTOs.DiscountDto, ShopsRUs.Api.Models.GetDiscountModel>().ReverseMap();
        }
    }
}
