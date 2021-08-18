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
                {(props.page == "home" || props.page  == "cart") ? (
                    <button onClick={() =>
                        props.context.handleBookDetail({
                            book: props.book,
                            id: props.book.bookId
                        })}>
                        <Title title={props.book.title} book={props.book} titleType="booktitle" />
                    </button>
                ) : (
                    <Title title={props.book.title} book={props.book} titleType="booktitle" />
                )
                }
                <Authors authors={props.book.authors} page={props.page} />
            
            {(props.page == "bookDetail") ? (
                <div>
                        <div>{props.book.isbn}</div><div><strong>{props.book.price}Kr</strong></div>
                        <div>{props.book.description}</div>
                </div>
            ) : ( <></> ) 

                }
            </div>
        </div>
    );
}

export default withContext(BookHead);