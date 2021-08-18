import React, { Component } from 'react';
import { Book } from './Book';
import withContext from '../withContext';

const BookDetail = props => {

    const book = props.context.book;
    let tmp;
    console.log("detail: " + book.title);
    return (
        <>
            <Book key={book.bookId} book={book} showBookDetail={props.showBookDetail} page="bookDetail" />
            <button onClick={() =>
                props.context.addToCart({
                    book: book,
                    id: book.bookId
                })}>Lägg till i Korg
            </button>
        </>
    );
}

export default withContext(BookDetail);