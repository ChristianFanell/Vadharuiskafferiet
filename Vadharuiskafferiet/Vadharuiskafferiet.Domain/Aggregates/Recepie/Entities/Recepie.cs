using Vadharuiskafferiet.Domain.Aggregates.ValueObjects;

namespace Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities
{
    public class Recepie: EntityBase, IAggregateRoot
    {
        private ICollection<Ingredient> _ingredients;

        public Recepie() {}

        public Recepie(ICollection<Ingredient> ingredients, List<string> steps, string description, string name) : base()
        {
            if (ingredients.Count == 0 || ingredients is null)
                throw new ArgumentException(nameof(ingredients));
            _ingredients = ingredients;
            Steps = new RecepieStepValueObject(steps);
            Description = new DescriptionValueObject(description);
            RecepieName = new NameValueObject(name);
        }

        public DescriptionValueObject Description { get; set; }

        public NameValueObject RecepieName { get; set; }
                
        public ICollection<Ingredient> Ingredients => _ingredients.Select(ingredient => ingredient).ToList();

        public string? ImageUrl { get; set; }

        public bool IsVegan => _ingredients.All(ing => ing.IsVegan);

        public bool IsVegetarian => _ingredients.All(ing => ing.IsVegetarian);

        public RecepieStepValueObject Steps { get; set; }   

        public bool ContainsIngredients(List<int> ingredientIDs)
        {
            if (ingredientIDs is null) throw new ArgumentNullException();
            if (ingredientIDs.Count == 0) throw new ArgumentException();
            
            return ingredientIDs.All(ingredientID => _ingredients.Any(ing => ing.Id == ingredientID));
        }         
    }
}
