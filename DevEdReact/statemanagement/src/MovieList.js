import React, {
    useState
}
from 'react';

const MovieList = () => {
    const [movie, setMovies] = useState([{
            name: 'Harry Potter',
            price: '$10',
            id: 19382
        },
        {
            name: 'Game of Thrones',
            price: '$10',
            id: 19383
        },
        {
            name: 'Matrix',
            price: '$10',
            id: 19384
        }
    ])

    return (
        <div>
        {movies.map(movie => (
            <li>{movie.name}</li>
        ))}
        </div>
    );
}

export default MovieList;