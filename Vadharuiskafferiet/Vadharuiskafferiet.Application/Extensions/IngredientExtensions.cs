using Vadharuiskafferiet.Application.DTOs;
using Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities;

namespace Vadharuiskafferiet.Application.Extensions
{
    public static class IngredientExtensions
    {
        public static IngredientDTO ToIngredientDTO(this Ingredient ingredient)
        {
            return new IngredientDTO
            {
                Id = ingredient.Id,
                IngredientName = ingredient.Name.Value,
                Image=ingredient.Image,
                IngredientType  = ingredient.IngredientType,
                IsVegan = ingredient.IsVegan,
                IsVegetarian = ingredient.IsVegetarian
            };
        } 
    }
}
