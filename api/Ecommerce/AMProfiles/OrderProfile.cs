using AutoMapper;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;

namespace Ecommerce.AMProfiles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<OrderDetail, CreateOrderDetailDto>().ReverseMap();
        CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ReverseMap();
    }
}