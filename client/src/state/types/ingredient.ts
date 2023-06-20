import { IngredientTypeEnum } from './IngredientTypeEnum';

export interface Ingredient {
  id: Number;
  ingredientType: IngredientTypeEnum;
  ingredientName: string;
  image?: string;
  isVegan: boolean;
  isVegetarian: boolean;
}
