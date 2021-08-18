import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'

export class ListAuthors extends Component {
  static displayName = ListAuthors.name;

  constructor(props) {
    super(props);
    this.state = { authors: [], loading: true };
  }

  componentDidMount() {
    this.populateAuthorData();
  }

  static renderAuthorsTable(authors) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Förnamn</th>
            <th>Efternamn</th>
          </tr>
        </thead>
        <tbody>
          {authors.listOfAuthors.map(author =>
            <tr key={author.id}>
              <td>{author.firstName}</td>
                  <td>{author.lastName}</td>
                  <td><button authorid="{author.id}" onClick="./BookDetailsPage">Open</button></td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : ListAuthors.renderAuthorsTable(this.state.authors);

    return (
      <div>
        <h1 id="tabelLabel" >Författare</h1>
        <p>Den här bilden ska lista författare.</p>
        {contents}
      </div>
    );
  }

  async populateAuthorData() {
    //const token = await authService.getAccessToken();
      const response = await fetch('AuthorBook');
<<<<<<< HEAD:WebShopReactCore/ClientApp/src/components/ListAuthors.js
      /*, {
      headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
<<<<<<< HEAD
    });
=======
    }); 
>>>>>>> 534a2493657276e3a1faedf72482799de8acf45a
    */
=======
>>>>>>> feature/context:WebShopReactCore/ClientApp/src/components/OLD/ListAuthors.js
    const data = await response.json();
    this.setState({ authors: data, loading: false });
  }
}
