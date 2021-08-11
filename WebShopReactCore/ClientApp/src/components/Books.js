import React, { Component } from 'react';
import { BookList } from './BookList';
import './styles/Books.css';

export class Books extends Component {
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
        let content = this.state.loading ? <p><strong>Data Loading ...</strong></p> : <BookList bookList={this.state.bookList} page={this.props.page} />;

        return (
            <div className="booklist-home">
                {content}
            </div>
        )
    }
}


