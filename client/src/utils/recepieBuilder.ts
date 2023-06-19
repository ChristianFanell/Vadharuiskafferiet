import { Ingredients } from "../state/types/ingredient";

export class RecepieBuilder {
  private _photoUrl: string | undefined;
  private _steps: string[] = [];
  private _recepieName: string;
  private _description: string | undefined;
  private _ingredients: Ingredients[] = [];

  constructor(name: string) {
    if (
      name === null ||
      name === undefined ||
      name?.trim().length === 0
    )
      throw new Error();
    this._recepieName = name;
  }

  addPhoto(url: string) {
    this._photoUrl = url;
    return this;
  }

  addDescription(description: string) {
    if (
      description === null ||
      description === undefined ||
      description?.trim().length === 0
    )
      throw new Error();
    this._description = description;
    return this;
  }

  addStep(step: string) {
    if (
      step === null ||
      step === undefined ||
      step?.trim().length === 0
    )
    this._steps.push(step);
    return this;
  }

  addIngredient(ingredient: Ingredients) {
    if (ingredient !== null || ingredient !== undefined)
      this._ingredients.push(ingredient);
    return this;
  }
}
