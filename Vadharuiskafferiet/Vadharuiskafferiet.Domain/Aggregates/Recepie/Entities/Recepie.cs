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

        public bool IsBudget => _ingredients.All(ing => ing.IsBudget);

        public RecepieStepValueObject Steps { get; set; }   

        public bool ContainsIngredients(List<string> ingredients)
        {
            if (ingredients is null) throw new ArgumentNullException();
            if (ingredients.Count == 0) throw new ArgumentException();
            return ingredients.Count > 0 ? ingredients.All(ingr => _ingredients.Select(ingr => ingr.Name.Value).Contains(ingr)) : false;
        }         
    }
}
