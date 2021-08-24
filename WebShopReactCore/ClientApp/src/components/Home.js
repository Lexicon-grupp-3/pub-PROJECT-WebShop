import React, { Component } from 'react';

import withContext from '../withContext';

const Home = props => {

    //let content = props.context.loading ? <p><strong>Data Loading ...</strong></p> : <BookList bookList={props.context.bookList} page="home" />;
    //let content = <p><strong>Data Loading ...</strong></p>;
    let content = props.context.loading ?
        <p><strong>Laddar ...</strong></p>
        : <p><strong>Klart ...</strong></p>;

    return (
        <div>
            {/*<Title titleType="pagehead" title="Välkommen till Crazy Arts Boklåda" />*/}
            {/*<Search />*/}
            {content}
        </div>
    );
}

export default withContext(Home);