import React, { Component } from 'react';
import { Book } from './Book';
import './styles/BookList.css';

export class BookList extends Component {
    constructor(props) {
        super(props);
    }

    
    render() {
        const books = this.props.bookList;
        
        if (this.props.page == "home") {
            const bookItems = books.map((book) =>
                <Book key={book.bookId} book={book} page={this.props.page} />);

            return (
                <div className="bookList">
                    {bookItems}
                </div>
            )
        }
        return (
            <div>Not Home Page</div>
            )
    }
}