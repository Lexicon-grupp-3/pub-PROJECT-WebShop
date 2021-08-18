import React from 'react';
import './styles/SearchBar.css';

export function SearchBar(props) {
    return (
        <div className="searchWrapper">
            <label>Sök bok: </label><input type="search" name="search" placeholder="Sök text" />
            <button type="submit">Sök</button>
        </div>
    );
}