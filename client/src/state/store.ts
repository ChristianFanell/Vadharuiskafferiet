import { configureStore } from '@reduxjs/toolkit';

import { ingredientApi } from './api/ingredientsApi';
import ingredientSearchSlice from './slices/ingredientSearchSlice';

export const store = configureStore({
  reducer: {
    [ingredientApi.reducerPath]: ingredientApi.reducer,
    ingredients: ingredientSearchSlice
  },

  middleware: (getDefaultMiddleware) =>
    getDefaultMiddleware().concat(ingredientApi.middleware),
});

export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
