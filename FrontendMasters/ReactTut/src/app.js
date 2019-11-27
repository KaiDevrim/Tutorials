/* eslint-disable no-unused-vars */
import React from "react";

import {render} from "react-dom";

import SearchParams from "./SearchParams.js";

import { Router, Link } from '@reach/router';
import Details from "./Details.js";

const App = () => {
  return (
    <div>
      <header>
        <Link to="/">Adopt Me!</Link>
      </header>
      <Router>
      <SearchParams path="/"/>
      <Details path="/details/:id" />
      </Router>
    </div>
  );
};

render(<App />, document.getElementById("root"));