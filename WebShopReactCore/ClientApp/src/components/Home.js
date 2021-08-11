import React, { Component } from 'react';
import { Books } from './Books';
import { BlockTitle as Title } from './BlockTitle';
import { SearchBar as Search } from './SearchBar';
import './styles/Home.css';

export class Home extends Component {
    render() {
        return (
            <div>
                <Title titleType="pagehead" title="Välkommen till Crazy Arts Boklåda" />
                <Search />
                <Books page="home" />
            </div>
            );
    }
}