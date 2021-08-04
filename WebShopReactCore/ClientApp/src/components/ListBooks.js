import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'

export class ListBooks extends Component {
  static displayName = ListBooks.name;

  constructor(props) {
    super(props);
    this.state = { books: [], loading: true };
  }

  componentDidMount() {
    this.populateBooksData();
  }

  static renderBooksTable(books) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Titel</th>
            <th>Författare</th>
            <th>ISBN</th>
          </tr>
        </thead>
        <tbody>
          {books.listOfBooks.map(book =>
            <tr key={book.id}>
                <td>{book.title}</td>
                <td>{book.authorFullName}</td>
                <td>{book.isbn}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : ListBooks.renderBooksTable(this.state.books);

    return (
      <div>
        <h1 id="tabelLabel" >Böcker</h1>
        {contents}
      </div>
    );
  }

  async populateBooksData() {
    const response = await fetch('AuthorBook/Books');
    const data = await response.json();
    this.setState({ books: data, loading: false });
  }
}
