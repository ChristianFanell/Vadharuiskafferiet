import {
  useDispatch,
  useSelector,
} from 'react-redux';

import { useGetAllIngredientsQuery } from '../../state/api/ingredientsApi';
import { addIngredient } from '../../state/slices/ingredientSearchSlice';
import { RootState } from '../../state/store';
import { Ingredient } from '../../state/types/ingredient';
import { SearchForm } from './componts/SearchForm';
import { SelectedIngredients } from './componts/SelectedIngredients';

export default function StartPage() {
  const dispatch = useDispatch();
  const { data, error, isLoading } = useGetAllIngredientsQuery();
  const selectedIngredients = useSelector(
    (state: RootState) => state.ingredients
  );
  // const [filteredData, setFilteredData] = useState<Ingredients[]>([]);
  if (isLoading) return <div>Laddar...</div>;
  if (error) return <div>fel</div>;

  const dispatchIngredients = (ingredient: Ingredient) =>
    dispatch(addIngredient(ingredient));

  const filterFn = (ingredient: Ingredient) =>
    selectedIngredients.value.length > 0
      ? selectedIngredients.value.some((ingr) => ingr.id === ingredient.id)
      : ingredient;

  return (
    <>
      <SearchForm/>
      <SelectedIngredients/>
      {data && !isLoading
        ? data/*.filter(filterFn)*/.map((ingr) => (
            <p
              onClick={() => dispatchIngredients(ingr)}
              key={ingr.id.toString()}
            >
              {ingr.ingredientName}
            </p>
          ))
        : null}
    </>
  );
}
