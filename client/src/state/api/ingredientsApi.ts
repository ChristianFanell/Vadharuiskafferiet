import {
  createApi,
  fetchBaseQuery,
} from '@reduxjs/toolkit/query/react';

import { BASE_URL } from '../../config/config';
import type { Ingredient } from '../types/ingredient';

export const ingredientApi = createApi({
  reducerPath: "ingredientsApi",
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL }),
  endpoints: (builder) => ({
    getAllIngredients: builder.query<Ingredient[], void>({
      query: () => `/ingredients/getingredients`,
    }),
    // använd npm paketet https://www.npmjs.com/package/trie-search
  }),
});


export const { useGetAllIngredientsQuery } = ingredientApi;
