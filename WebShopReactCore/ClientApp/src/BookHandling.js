import React, { Component } from 'react';
import { Switch, Route, Link, BrowserRouter as Router } from 'react-router-dom';

//import { Route } from 'react-router';
import BookDetail from './components/BookDetail';
import BookEdit from './components/BookEdit';

import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';

import Context from './Context';

import './custom.css'


export default class BookHandling extends Component {
    static displayName = BookHandling.name;

    constructor(props) {
        super(props);
        this.state = {
            loading: true,
            books: [],
            bookCurrent: {}
        };
        this.routerRef = React.createRef();
        this.bookDetail = this.bookDetail.bind(this);
        this.bookEditSubmit = this.bookEditSubmit.bind(this);
        //this.bookDelete = this.bookDelete.bind(this);
        this.handleChange = this.handleChange.bind(this);
        this.goBack = this.goBack.bind(this);
    }

    async componentDidMount() {
        const promise = await fetch('AuthorBook/Books');
        const books = await promise.json();
        this.setState({ books, loading: false });
    }

    async bookDetail(bookX) {
        let bookCurrent = JSON.parse(JSON.stringify(bookX.book));
        this.setState({ bookCurrent })
        this.routerRef.current.history.push("/bookDetail")
    }
    async bookEdit(bookX) {
        let bookCurrent = JSON.parse(JSON.stringify(bookX.book));
        this.setState({ bookCurrent })
        this.routerRef.current.history.push("/bookEdit")
    }

    async handleChange(event) {
        let book = this.state.bookCurrent.bookV;
        let nam = event.target.name;
        book[nam] = event.target.value;
        this.setState({ book })
    }

    async bookEditSubmit(event) {
        event.preventDefault();
        let bookCurrent = this.state.bookCurrent;
        const response2 = await fetch('AuthorBook/BookEdit'
            , {
                method: 'POST',
                mode: 'cors',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    id: bookCurrent.bookV.id,
                    title: bookCurrent.bookV.title,
                    description: bookCurrent.bookV.description,
                    isbn: bookCurrent.bookV.isbn,
                    price: bookCurrent.bookV.price
                })
            }
        );
        await response2.json();
        //this.setState({ bookCurrent })

        // Nyläsning för omsortering behövs
        this.setState({ loading: true });
        const response = await fetch('AuthorBook/Books');
        const data2 = await response.json();
        this.setState({ books: data2, loading: false });

        this.routerRef.current.history.goBack();
    }

    async goBack() {
        this.routerRef.current.history.goBack();
    }

    render() {
        let content = <></>
        if (this.state.loading) {
            content =
                <p>
                    <strong>Laddar böcker ...</strong>
                </p>
        }
        else {
            const books = this.state.books;
            content =
                <div>

                    <h4>Våra böcker</h4>
                    <button type="button"
                        onClick={() =>
                            this.bookEdit({
                                book: {}
                            })}>
                        {"Ny"}
                    </button>

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
                            {books.listOfBooks.map(book =>
                                <tr key={book.id}>
                                    <td>{book.bookV.id}</td>
                                    <td>{book.bookV.title}</td>
                                    <td>{book.authorFullName}</td>
                                    <td>
                                        <button type="button"
                                            onClick={() =>
                                                this.bookDetail({
                                                    book: book
                                                })}>
                                            {"Visa"}
                                        </button>
                                    </td>
                                    <td>
                                        <button type="button"
                                            onClick={() =>
                                                this.bookEdit({
                                                    book: book
                                                })}>
                                            {"Ändra"}
                                        </button>
                                    </td>
                                    {/*    <td>*/}
                                    {/*        <button type="button"*/}
                                    {/*            onClick={() =>*/}
                                    {/*                this.bookDelete({*/}
                                    {/*                    book: book*/}
                                    {/*                })}>*/}
                                    {/*            {"Ta bort"}*/}
                                    {/*        </button>*/}
                                    {/*    </td>*/}
                                </tr>
                            )}
                        </tbody>
                    </table>

                </div>
        }

        return (
            <Context.Provider
                value={{
                    ...this.state,
                    bookDetail: this.bookDetail,
                    bookEditSubmit: this.bookEditSubmit,
                    //bookDelete: this.bookDelete,
                    handleChange: this.handleChange,
                    goBack: this.goBack
                }}
            >
                <Router ref={this.routerRef}>
                    <div className="BookHandling">
                        <Switch>
                            <AuthorizeRoute path='/bookDetail' component={BookDetail} />
                            <AuthorizeRoute path='/bookEdit' component={BookEdit} />
                            <div>{content}</div>
                        </Switch>
                    </div>
                </Router>
            </Context.Provider>
        );
    }
}
