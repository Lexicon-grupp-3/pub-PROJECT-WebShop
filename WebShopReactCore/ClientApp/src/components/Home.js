import React, { Component } from 'react';
import { Books } from './Books';
import './Home.css';

export class Home extends Component {
    render() {
        return (
            <div>
                <h1 className="pageHeadline">Välkommen till Crazy Arts Boklåda</h1>
                <Books page="home" />
            </div>
            );
    }
}