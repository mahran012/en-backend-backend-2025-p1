using MohamedTwo.Models.Enum;
using MohamedTwo.Models;
using MohamedTwo.Dtos.Rating_Dto;

namespace MohamedTwo.Interface
{
    public interface IDishRepositry
    {
        Task<ICollection<Dish>> GetDishes(DishQueryParams queryParams);
        Dish GetDish(Guid Id);
        bool DishExists(Guid Id);
      
    }
    public class DishQueryParams
    {
        public Category[]? Categories { get; set; }
        public bool? Vegetarian { get; set; }
        public DishSorting? SortBy { get; set; }
        public int Page { get; set; } = 1;
    }
}
