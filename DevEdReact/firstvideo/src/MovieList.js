/* eslint-disable no-unused-vars */
import React, {
    useState
} from 'react';

const MovieList = () => {
    const [movies, setMovies] = useState([{
        name: 'Harry Potter',
        price: '$10',
        id: 23124
    },
    {
        name: 'Game of Thrones',
        price: '$10',
        id: 23125
    },
    {
        name: 'Inception',
        price: '$10',
        id: 23126
    }
    ]);
    return (
        <div>
            {
                movies.map(movie => (
                    <li> {movie.name}</li>
                ))}
        </div>
    );
}

export default MovieList;