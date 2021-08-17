import React, { Component } from 'react';
import { BookList } from './BookList';
import { BlockTitle as Title } from './BlockTitle';
import { SearchBar as Search } from './SearchBar';
import withContext from '../withContext';
import './styles/Home.css';

const Home = props => {

    let content = props.context.loading ? <p><strong>Data Loading ...</strong></p> : <BookList bookList={props.context.bookList} page="home" />;

    return (
        <div>
            <Title titleType="pagehead" title="Välkommen till Crazy Arts Boklåda" />
            <Search />
            {content}
        </div>
    );
}

export default withContext(Home);