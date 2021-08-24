import React from 'react';
import withContext from '../withContext';

const AuthorList = props => {

    const authors = props.context.authors;
    //let content = props.context.loading ?
    //    <p><strong>Data Loading ...</strong></p>
    //    : <AuthorList authorList={props.context.authors} page="authorList" />;
    var xx = 3;
    return (
        <>
            <div>
                <h4>Våra författare</h4>
                {/*    {content}*/}
                <button type="button"
                    onClick={() =>
                        props.context.authorEdit({
                            author: {}
                        })}>
                    {"Ny"}
                </button>

                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Efternamn</th>
                            <th>Förnamn</th>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        {authors.listOfAuthors.map(author =>
                            <tr key={author.id}>
                                <td>{author.id}</td>
                                <td>{author.lastName}</td>
                                <td>{author.firstName}</td>
                                <td>
                                    <button type="button"
                                        onClick={() =>
                                            props.context.authorDetail({
                                                author: author
                                            })}>
                                        {"Visa"}
                                    </button>
                                </td>
                                <td>
                                    <button type="button"
                                        onClick={() =>
                                            props.context.authorEdit({
                                            author: author
                                        })}>
                                        {"Ändra"}
                                    </button>
                                {/*    <button className="btn btn-primary" onClick={this.detalj}>Solsken2</button>*/}
                                </td>
                                <td>
                                    <button type="button"
                                        onClick={() =>
                                            props.context.authorDelete({
                                                author: author
                                            })}>
                                        {"Ta bort"}
                                    </button>
                                </td>
                            </tr>
                        )}
                    </tbody>
                </table>
                {/*<button className="btn btn-primary" onClick={this.detalj2}>Solsken3</button>*/}

            </div>
        </>
    );

};

export default withContext(AuthorList);