import React from 'react';
import { useLocation } from 'react-router-dom';
import './styles/ResourceNotFound.css';

export function ResourceNotFound() {
    let location = useLocation();
    console.log(location);
    return (
        <div className="resourceNotFound">
            <h2>Resource NOT found {location.pathname}
            </h2></div>
    );
}