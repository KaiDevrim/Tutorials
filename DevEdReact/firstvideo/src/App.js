import React from "react";
import "./App.css";
import MovieList from './MovieList'
import Nav from './nav'
import { MovieProvider } from './MovieContext';
function App() {

  return (
    <MovieProvider value={'Hello'}>
      <div className="App">
        <MovieList />
        <Nav />
      </div>
    </MovieProvider>
  );
}

export default App;
