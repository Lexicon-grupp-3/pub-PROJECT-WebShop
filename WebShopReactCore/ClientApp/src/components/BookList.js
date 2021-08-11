import React, { Component } from 'react';
import { Book } from './Book';

export class BookList extends Component {
    constructor(props) {
        super(props);
    }

    
    render() {
        const books = this.props.bookList;
        const bookItems = books.map((book) =>
            <Book key={book.bookId} book={book} page={this.props.page} />
        )
        if (this.props.page == "home") {
            return (
                <div>BookList Class
                    {bookItems}
                </div>
            )
        }
        return (
            <div>Not Home Page</div>
            )
    }
}