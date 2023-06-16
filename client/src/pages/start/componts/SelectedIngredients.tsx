import { useSelector } from 'react-redux';

import ingredientSearchSlice from '../../../state/slices/ingredientSearchSlice';
import { RootState } from '../../../state/store';

export const SelectedIngredients = () => {
  const arsle = ingredientSearchSlice;

  const selectedIngredients = useSelector(
    (state: RootState) => state.ingredients
  );
  return (
    <>
      {selectedIngredients.value.length > 0
        ? selectedIngredients.value.map((ingr) => (
            <p key={ingr.id.toString()}>{ingr.ingredientName}</p>
          ))
        : null}
      {selectedIngredients.value.length > 0 ? <hr /> : null}
    </>
  );
};
