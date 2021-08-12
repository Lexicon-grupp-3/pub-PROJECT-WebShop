import React, { Component } from 'react';
import { BlockTitle as Title } from './BlockTitle';
import { BookAuthors as Authors } from './BookAuthors';
import { BookImage as Image } from './BookImage';
import './styles/BookHead.css';

export class BookHead extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className="bookHeadWrapper">
                <Image src={this.props.book.pictureRef} page={this.props.page} />
                <div className="titleAuthors">
                    <Title title={this.props.book.title} titleType="booktitle" />
                    <Authors authors={this.props.book.authors} page={this.props.page} />
                </div>
            </div>
        );
    }
}