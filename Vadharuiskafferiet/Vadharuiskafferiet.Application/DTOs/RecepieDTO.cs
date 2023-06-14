namespace Vadharuiskafferiet.Application.DTOs
{
    public class RecepieDTO
    {
        public int Id { get; set; }
        public List<IngredientDTO> Ingredients { get; set; } = null!;
        public List<string> Steps { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool  IsVegan { get; set; }
        public bool  IsVegetarian { get; set; }
        public string? Image { get; set; }
    }
}
