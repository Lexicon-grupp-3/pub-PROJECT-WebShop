import React, { Component } from 'react';
import { Book } from './Book';
import withContext from '../withContext';

const BookDetail = props => {

    const book = props.context.book;
    let tmp;
    console.log("detail: " + book);
    return (
        <>
            {book.title != "undefined" ? (<Book key={book.bookId} book={book} showBookDetail={props.showBookDetail} page="bookDetail" />) : (<p>No Book</p>)}
        </>
    );
}

export default withContext(BookDetail);