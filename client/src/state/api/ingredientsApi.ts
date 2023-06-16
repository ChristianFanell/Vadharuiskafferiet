import {
  createApi,
  fetchBaseQuery,
} from '@reduxjs/toolkit/query/react';

import { BASE_URL } from '../../config/config';
import type { Ingredients } from '../types/ingredient';

export const ingredientApi = createApi({
  reducerPath: "ingredientsApi",
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL }),
  endpoints: (builder) => ({
    getAllIngredients: builder.query<Ingredients[], void>({
      query: () => `/ingredients/getingredients`,
    }),
  }),
});


export const { useGetAllIngredientsQuery } = ingredientApi;
