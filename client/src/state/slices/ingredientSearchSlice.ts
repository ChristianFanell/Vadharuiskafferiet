import type { PayloadAction } from '@reduxjs/toolkit';
import { createSlice } from '@reduxjs/toolkit';

import { Ingredient } from '../types/ingredient';
// import { TrieTree } from '../../datastructures/trie/trieTree';
// import { TrieNode } from '../../datastructures/trie/trieNode';

interface IngredientSearchState {
  value: Ingredient[];
}

// interface TrieState {
//   value: TrieTree;
// }

const initialState = { value: [] } as IngredientSearchState;

export const ingredientSearchSlice = createSlice({
  name: "searchFilterValues",
  initialState,
  reducers: {
    addIngredient(state : IngredientSearchState, action: PayloadAction<Ingredient>) {
      state.value = !state.value.some((ing) => ing.id === action.payload.id)
        ? [action.payload, ...state.value]
        : [...state.value];
    },
    // setupTrie(state: TrieState, action: PayloadAction<Ingredient[]>) {
    //   const trie = new TrieTree()
    //   state.value = action.payload.forEach(ingr => trie.insert(ingr.ingredientName))
    // }
    // använd npm paketet https://www.npmjs.com/package/trie-search
  },
});

export const { addIngredient } = ingredientSearchSlice.actions;
export default ingredientSearchSlice.reducer;
