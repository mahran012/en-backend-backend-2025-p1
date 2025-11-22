using AutoMapper;
using MohamedTwo.Dtos.BasketDto;
using MohamedTwo.Dtos.DishDTo;
using MohamedTwo.Dtos.OrderDto;
using MohamedTwo.Dtos.Rating_Dto;
using MohamedTwo.Models;

namespace MohamedTwo.Maping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Dish entity to DTO
            CreateMap<Dish, DishDto>();

            // Basket and BasketItem to their DTOs
            CreateMap<Basket, BasketDTO>()
                .ForMember(dest => dest.BasketItems, opt => opt.MapFrom(src => src.BasketItems));
            CreateMap<BasketItem, BasketItemDTO>();

            // Order and OrderItem to their DTOs
            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<OrderItem, OrderItemDTO>();
            CreateMap<Order, OrderInfoDTO>();

            // Rating entity to DTO
            CreateMap<Rating, RatingDTO>();
        }
    }
}
