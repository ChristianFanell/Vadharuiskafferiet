import { IngredientTypeEnum } from './IngredientTypeEnum';

export interface Ingredients {
  id: Number;
  ingredientType: IngredientTypeEnum;
  ingredientName: string;
  image?: string;
  isVegan: boolean;
  isVegetarian: boolean;
}
