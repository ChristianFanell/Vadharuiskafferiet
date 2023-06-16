import type { PayloadAction } from '@reduxjs/toolkit';
import { createSlice } from '@reduxjs/toolkit';

import { Ingredients } from '../types/ingredient';

interface IngredientSearchState {
  value: Ingredients[];
}

const initialState = { value: [] } as IngredientSearchState;

export const ingredientSearchSlice = createSlice({
  name: "searchFilterValues",
  initialState,
  reducers: {
    addIngredient(state, action: PayloadAction<Ingredients>) {
      state.value = !state.value.some((ing) => ing.id === action.payload.id)
        ? [action.payload, ...state.value]
        : [...state.value];
    },
  },
});

export const { addIngredient } = ingredientSearchSlice.actions;
export default ingredientSearchSlice.reducer;
