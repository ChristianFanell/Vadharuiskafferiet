using Vadharuiskafferiet.Domain.Aggregates.ValueObjects;

namespace Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities
{


    public class Ingredient: EntityBase
    {
        public Ingredient() { }

        public Ingredient(string name, IngredientTypeEnum ingredientType) : base() {
            Name = new NameValueObject(name);
            IngredientType = ingredientType;
        }    

        public string? Image { get; set; }
        public NameValueObject Name { get; init; }
        public IngredientTypeEnum IngredientType { get; init; }
        public bool IsVegetarian => IngredientType != IngredientTypeEnum.Meat && IngredientType != IngredientTypeEnum.Fish;
        public bool IsVegan => IsVegetarian && (IngredientType != IngredientTypeEnum.Dairy && IngredientType != IngredientTypeEnum.Egg);
        public List<Recepie> Recepies { get; set; } = new();
    }

    public enum UnitTypeEnum
    {
        Metrics
    }

    public enum IngredientTypeEnum
    {
        Vegetable,
        Meat,
        Fish,
        Fruit,
        Carbohydrate,
        Dairy,
        Egg,
        Fat,
        Leguminous
    }
}
