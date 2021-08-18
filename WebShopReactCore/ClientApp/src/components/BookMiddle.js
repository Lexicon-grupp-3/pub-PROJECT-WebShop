import React, { Component } from 'react';
import './styles/BookMiddle.css';

export class BookMiddle extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        let price = this.props.book.price;
        return (
            <div className="middleWrapper">
                <div className="bookISBN">ISBN: {this.props.book.isbn}</div>
                <div className="bookPrice">{price.toFixed(2)}Kr</div>
            </div>
        );
    }
}