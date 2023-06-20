import { Ingredient } from "./ingredient";

export class Recepie {
  constructor(
    name: string,
    steps: string[],
    ingredients: Ingredient[],
    description?: string,
    image?: string
  ) {
    this.name = name;
    this.description = description;
    this.steps = steps;
    this.image = image;
    this.ingredients = ingredients;
  }

  id?: number;
  ingredients: Ingredient[] = [];
  steps: string[] = [];
  name: string;
  description: string | undefined;
  image?: string;
  isVegan: boolean = this.ingredients.every((ingr) => ingr.isVegan);
  isVegetarian: boolean =
    this.ingredients.every((ingr) => ingr.isVegetarian) || this.isVegan;
}
