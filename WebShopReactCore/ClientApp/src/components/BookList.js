import React from 'react';
import withContext from '../withContext';

const BookList = props => {

    let content = props.context.loading ?
        <p><strong>Laddar böcker ...</strong></p>
        : <p><strong>Klart böcker ...</strong></p>;

    const books = props.context.books;
    return (
        <>
            <div>
                <h4>Våra böcker</h4>
                {content}
                {/*    {content}*/}
                {/*<button type="button"*/}
                {/*    onClick={() =>*/}
                {/*        props.context.bookEdit({*/}
                {/*            book: {}*/}
                {/*        })}>*/}
                {/*    {"Ny"}*/}
                {/*</button>*/}

                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Titel</th>
                            <th></th>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                    {/*    {books.listOfBooks.map(book =>*/}
                    {/*        <tr key={book.id}>*/}
                    {/*            <td>{book.id}</td>*/}
                    {/*            <td>{book.title}</td>*/}
                    {/*        */}{/*    <td>{book.firstName}</td>*/}
                    {/*        */}{/*    <td>*/}
                    {/*        */}{/*        <button type="button"*/}
                    {/*        */}{/*            onClick={() =>*/}
                    {/*        */}{/*                props.context.bookDetail({*/}
                    {/*        */}{/*                    book: book*/}
                    {/*        */}{/*                })}>*/}
                    {/*        */}{/*            {"Visa"}*/}
                    {/*        */}{/*        </button>*/}
                    {/*        */}{/*    </td>*/}
                    {/*        */}{/*    <td>*/}
                    {/*        */}{/*        <button type="button"*/}
                    {/*        */}{/*            onClick={() =>*/}
                    {/*        */}{/*                props.context.bookEdit({*/}
                    {/*        */}{/*                book: book*/}
                    {/*        */}{/*            })}>*/}
                    {/*        */}{/*            {"Ändra"}*/}
                    {/*        */}{/*        </button>*/}
                    {/*        */}{/*        <button className="btn btn-primary" onClick={this.detalj}>Solsken2</button>*/}
                    {/*        */}{/*    </td>*/}
                    {/*        */}{/*    <td>*/}
                    {/*        */}{/*        <button type="button"*/}
                    {/*        */}{/*            onClick={() =>*/}
                    {/*        */}{/*                props.context.bookDelete({*/}
                    {/*        */}{/*                    book: book*/}
                    {/*        */}{/*                })}>*/}
                    {/*        */}{/*            {"Ta bort"}*/}
                    {/*        */}{/*        </button>*/}
                    {/*        */}{/*    </td>*/}
                    {/*        </tr>*/}
                    {/*    )}*/}
                    </tbody>
                </table>

            </div>
        </>
    );

};

export default withContext(BookList);