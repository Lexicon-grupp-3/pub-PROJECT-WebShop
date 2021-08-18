import React, { Component } from 'react';
import BookHead  from './BookHead';
import { BookMiddle } from './BookMiddle';
import './styles/Book.css';

export class Book extends Component {
    constructor(props) {
        super(props);
    }
    /*
     * book:
     *  title
     *  price
     *  pictureRef
     *  isbn
     *  description
     *  bookId - int
     *  authors - Array
     */

    render() {
        if (this.props.page == "home") {
            return (
                <div className="bookContainer">
                    <BookHead book={this.props.book} page={this.props.page} />
                    <BookMiddle book={this.props.book} page={this.props.page} />
                </div>
            )
        }
        else if (this.props.page == "bookDetail") {
            return (
                <div className="bookContainer">
                    <BookHead book={this.props.book} page={this.props.page} />

                </div>
                )
        }
    }
}