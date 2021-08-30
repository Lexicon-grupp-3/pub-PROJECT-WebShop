import React from 'react';

import withContext from '../withContext';

const BookEdit = props => {
    let xx = 2;
    let zx = 45;
    const book = props.context.bookCurrent.bookV;
    //try {
    //    props.context.bookCurrent.bookV.GetType();
    //    const book1 = props.context.bookCurrent.bookV;
    //} catch (e) {
    //    const book1 = new Book;
    //}
    //if (book.) {

    //}
    let xy = 4;
    return (
        <>
            <h4>En bok</h4>
            <form onSubmit={props.context.bookEditSubmit}>
                <p>
                    <label>
                        Titel:
                        <input
                            type="text"
                            value={book.title}
                            name="title"
                            onChange={props.context.handleChange} />
                    </label>
                </p>
                <p>
                    <label>
                        Beskrivning:
                        <textarea
                            rows={8} cols={40}
                            value={book.description}
                            name="description"
                            onChange={props.context.handleChange} 
                       />
                    </label>
                </p>
                <p>
                    <label>
                        ISBN:
                        <input
                            type="text"
                            value={book.isbn}
                            name="isbn"
                            onChange={props.context.handleChange} />
                    </label>
                </p>
                <p>
                    <label>
                        Författare:
                        <input
                            type="text"
                            value={book.authorId}
                            name="authorId"
                            onChange={props.context.handleChange} />
                    </label>
                </p>
                <p>
                    <label>
                        Pris:
                        <input
                            type="text"
                            value={book.price}
                            name="price"
                            onChange={props.context.handleChange} />
                    </label>
                </p>
                <p>
                    <input type="submit" value="Spara" />
                </p>
            </form>
            <button type="button"
                onClick={() =>
                    props.context.goBack()}>
                {"Avbryt"}
            </button>
        </>
    );

};

export default withContext(BookEdit);