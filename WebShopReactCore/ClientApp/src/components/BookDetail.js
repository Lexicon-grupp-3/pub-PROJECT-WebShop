import React, { Component } from 'react';
import { Book } from './Book';
import withContext from '../withContext';

const BookDetail = props => {
    
    const book = props.context.currentBook;
    let tmp;
        console.log("detail: " + book);
    return (
        <>
        <p>{book.title}</p>
           /* {book.title != "undefined" ? (<Book key={book.bookId} book={book} showBookDetail={props.showBookDetail} page="bookDetail" />) : (<p>No Book</p>)}*/
            </>
    );
}

export default withContext(BookDetail);