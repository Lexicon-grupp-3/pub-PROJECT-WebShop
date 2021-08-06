import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'
import { useHistory } from 'react-router-dom';
import { Link } from 'react-router-dom';

export class ListAuthors extends Component {
    static displayName = ListAuthors.name;
    static history = useHistory;

  constructor(props) {
    super(props);
    this.state = { authors: [], loading: true };
  }

  componentDidMount() {
    this.populateAuthorData();
  }

    static renderAuthorsTable(authors) {


        //let history = useHistory();

        //const redirect = () => {
        //    history.push('/author-detail')
        //}

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
              <td>
                {/*<button type="button" onClick={this.handleClick.bind(this)}>*/}
                {/*    {this.props.button_text}*/}
                {/*</button>*/}
                {/*<button type="button" onClick={redirect}>*/}
                {/*<Link to="/author-detail/:id">*/}
                <Link to={'/author-detail/${author.id}'}>
                    <button type="button">Visa</button>
                </Link>
                {/*<button type="button" onClick={"/author-detail"}>*/}
                {/*    {"Visa"}*/}
                {/*</button>*/}
                <button type="button" onClick={"() => {history.push('/author-detail')"}>
                    {"Ändra"}
                </button>
                <button type="button" onClick={"xxx"}>
                    {"Ta bort"}
                </button>
                      {/*<button onClick={(e) => this.deleteRow(id, e)}>Delete Row</button>*/}
                      {/*<button onClick={this.deleteRow.bind(this, id)}>Delete Row</button>*/}


              </td>
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
        {contents}
      </div>
    );
  }

  async populateAuthorData() {
    //const token = await authService.getAccessToken();
      const response = await fetch('AuthorBook');
      /*, {
      headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
    }); 
    */
    const data = await response.json();
    this.setState({ authors: data, loading: false });
  }
}
