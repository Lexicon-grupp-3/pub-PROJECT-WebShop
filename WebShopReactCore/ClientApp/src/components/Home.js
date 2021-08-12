import React, { Component } from 'react';
import { BookList } from './BookList';
import { BlockTitle as Title } from './BlockTitle';
import { SearchBar as Search } from './SearchBar';
import './styles/Home.css';

export class Home extends Component {
    constructor(props) {
        super(props);
        this.state = { bookList: [], loading: true };
    }

    componentDidMount() {
        this.getBookList();
    }

    async getBookList() {

        const promise = await fetch('AuthorBook/BookList');
        const data = await promise.json();
        this.setState({ bookList: data, loading: false });
    }

    render() {
        let content = this.state.loading ? <p><strong>Data Loading ...</strong></p> : <BookList bookList={this.state.bookList} page="home" />;
        return (
            <div>
                <Title titleType="pagehead" title="Välkommen till Crazy Arts Boklåda" />
                <Search />
                
                    {content}
                
            </div>
            );
    }
}