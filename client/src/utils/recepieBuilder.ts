import { Ingredient } from "../state/types/ingredient";
import { Recepie } from "../state/types/recepie";
import { stringValidator } from "./validators";

export class RecepieBuilder {
  private _photoUrl: string | undefined;
  private _steps: string[] = [];
  private _recepieName: string;
  private _description: string | undefined;
  private _ingredients: Ingredient[] = [];

  constructor(name: string) {
    if (stringValidator(name)) throw new Error();
    this._recepieName = name;
  }

  addPhoto(url: string) {
    this._photoUrl = url;
    return this;
  }

  addDescription(description: string) {
    if (stringValidator(description, (str: string) => str.length > 15))
      throw new Error();

    this._description = description;
    return this;
  }

  addStep(step: string) {
    if (stringValidator(step)) this._steps.push(step);
    return this;
  }

  addIngredient(ingredient: Ingredient) {
    if (ingredient !== null || ingredient !== undefined)
      this._ingredients.push(ingredient);
    return this;
  }

  getSteps = () => this._steps.map((step) => step);

  createRecepie() {
    return new Recepie(
      this._recepieName,
      this._steps,
      this._ingredients,
      this._description,
      this._photoUrl
    );
  }
}
