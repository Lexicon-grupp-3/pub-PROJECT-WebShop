import React, { Component } from 'react';
import { BlockTitle as Title } from './BlockTitle';
import { BookAuthors as Authors } from './BookAuthors';
import { BookImage as Image } from './BookImage';
import withContext from '../withContext';
import './styles/BookHead.css';

const BookHead = (props) => {

    return (
        <div className="bookHeadWrapper">
            <Image src={props.book.pictureRef} page={props.page} />
            <div className="titleAuthors">
                <button onClick={() =>
                    props.context.handleBookDetail({
                        book: props.book,
                        id: props.book.bookId
                    })} href="#">
                    <Title title={props.book.title} book={props.book} titleType="booktitle" />
                </button>
                <Authors authors={props.book.authors} page={props.page} />
            </div>
        </div>
    );
}

export default withContext(BookHead);