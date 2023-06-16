import './App.css';

import { useState } from 'react';

import { Provider } from 'react-redux';

import StartPage from './pages/start/StartPage';
import { store } from './state/store';

function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <Provider store={store}>
        <StartPage />
      </Provider>
    </>
  );
}

export default App;
