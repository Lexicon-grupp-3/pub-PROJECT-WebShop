import React from 'react';
import withContext from '../withContext';

const BookDetail = props => {

    const book = props.context.bookCurrent;
    return (
        <>
            <div>
                <h4>En bok</h4>
                <p>{book.bookV.id}</p>
                <p>{book.bookV.title}</p>
                <p>{book.bookV.description}</p>
                <p>{book.bookV.isbn}</p>
                <p>{book.authorFullName}</p>
                <p>{book.bookV.price}</p>
                <button type="button"
                    onClick={() =>
                        props.context.goBack()}>
                    {"Tillbaka"}
                </button>
            </div>
        </>
    );

};

export default withContext(BookDetail);