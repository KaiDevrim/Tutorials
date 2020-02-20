import React, { useState } from 'react';

const MovieList = () => {
	// eslint-disable-next-line
	return <div>{movies.map((movie) => <li>{movie.name}</li>)}</div>;
};

export default MovieList;
