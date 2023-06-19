using Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities;

namespace Vadharuiskafferiet.Application.DTOs
{
    public record IngredientDTO
    {
        public int Id { get; set; }
        public IngredientTypeEnum IngredientType { get; set; }
        public string IngredientName { get; set; } = null!;
        public string? Image { get; set; }
        public bool IsVegan { get; set; }
        public bool IsVegetarian { get; set; }
    }
}
