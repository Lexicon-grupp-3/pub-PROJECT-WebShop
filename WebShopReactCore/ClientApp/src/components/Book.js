import { extend } from 'jquery';
import React, { Component } from 'react';
import { BlockTitle as Title } from './BlockTitle';
import { BookAuthors as Authors } from './BookAuthors';
import { BookImage as Image } from './BookImage';
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
        return (
            <div className="bookContainer">
                <Image src={this.props.book.pictureRef} page={this.props.page} />
                <div className="titleAuthors">
                    <Title title={this.props.book.title} titleType="booktitle" />
                    <Authors authors={this.props.book.authors} page={this.props.page} />
                </div><br />
                <span className="bookISBN">{this.props.book.isbn}</span>

            </div>
        )
    }
}