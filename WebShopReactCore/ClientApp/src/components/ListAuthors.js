import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'
import { useParams, useHistory } from 'react-router-dom';
import { Link } from 'react-router-dom';
import { AuthorDetail } from './AuthorDetail';
import { AuthorNew } from './AuthorNew';


export class ListAuthors extends Component {
    static displayName = ListAuthors.name;
    static history1 = useHistory;
    static param1 = useParams;

    constructor(props) {
        super(props);
        this.state = { actType: 0, authors: [], loading: true };
        //this.state = { authors: [], loading: true };
        this.detalj = this.detalj.bind(this);
        this.tillbaka = this.tillbaka.bind(this);
        this.authorEdit = this.authorEdit.bind(this);
        this.authorNew = this.authorNew.bind(this);
    }

    componentDidMount() {
        this.populateAuthorData();
    }

    componentDidUpdate(prevProps, prevState, snapshot) {
    }



    detalj() {
        this.setState({
            actType: 1
        })
    }
    authorEdit() {
        this.setState({
            actType: 2
        })
    }
    authorNew() {
        this.setState({
            actType: 3
        })
    }
    authorDelete() {
        this.setState({
            actType: 9
        })
    }
    detalj2() {
        this.setState({
            actType: 7
        })
    }
    tillbaka() {
        this.setState({
            actType: 0
        })
    }


    //handleButtonClicked = evt => {
    //    this.setState({
    //        name: 
    //        evt.currentTarget.value }, () => {
    //        //this.props.callback(this.state.name)
    //            this.authorNew(this.state.name)
    //    })
    //}

    static renderAuthorsTable(authors) {

        return (
            <div>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Efternamn</th>
                            <th>Förnamn</th>
                        </tr>
                    </thead>
                    <tbody>
                        {authors.listOfAuthors.map(author =>
                            <tr key={author.id}>
                                <td>{author.id}</td>
                                <td>{author.lastName}</td>
                                <td>{author.firstName}</td>
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
                                    <button type="button" onClick={this.edit}>
                                        {"Ändra"}
                                    </button>
                                    <button type="button" onClick={this.delete}>
                                        {"Ta bort"}
                                    </button>
                                    {/*<button onClick={(e) => this.deleteRow(id, e)}>Delete Row</button>*/}
                                    {/*<button onClick={this.deleteRow.bind(this, id)}>Delete Row</button>*/}
                                    {/*<button className="btn btn-primary" onClick={this.detalj.bind(this, author.id)}>Solsken2</button>*/}
                                    <button className="btn btn-primary" onClick={this.detalj}>Solsken2</button>
                                </td>
                            </tr>
                        )}
                    </tbody>
                </table>
                <button className="btn btn-primary" onClick={this.detalj2}>Solsken3</button>
            </div>
        );
    }

    render() {
        var aa = this.state.actType;
        var id = 4;

        if (this.state.actType === 0) {
            let contents = this.state.loading
                ? <p><em>Loading...</em></p>
                : ListAuthors.renderAuthorsTable(this.state.authors);

            return (
                <div>
                    <div>
                        <h1 id="tabelLabel" >Författare</h1>
                        <p>Här ska det bli en lista</p>
                        {contents}
                        <button className="btn btn-primary" onClick={this.detalj}>Detalj</button>
                        <button className="btn btn-primary" onClick={this.authorEdit.bind(this, id)}>Ändra</button>
                        <button className="btn btn-primary" onClick={this.authorNew}>Ny</button>
                    {/*    <button className="btn btn-primary" onClick={this.handleButtonClicked}>Gran</button>*/}
                    </div>
                </div>
            );
        }
        //else if (this.state.actType === 7) {
        //    return (
        //        <div>
        //            <button className="btn btn-primary" onClick={this.tillbaka}>Tillbaka</button>
        //        </div>
        //    )
        //}
        else if (this.state.actType === 3) {
            return (
                <div>
                    <p>Här ska det bli nyskapande</p>
                    {<AuthorNew
                        id="0"
                    />}
                    <button className="btn btn-primary" onClick={this.tillbaka}>Tillbaka</button>
                </div>
            )
        }
        else if (this.state.actType === 2) {
            return (
                <div>
                    <p>Här ska det bli uppdatering</p>
                    {<AuthorNew
                        id="5"
                    />}
                </div>
            )
        }
        else {
            this.state = { actType: 3 };

            return (
                <div>
                    <p>Här händer ingenting än</p>
                </div>
            )
        }
    }


    async populateAuthorData() {
        //const token = await authService.getAccessToken();
        const response = await fetch('AuthorBook/Authors');
        /*, {
        headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
      }); 
      */
        const data = await response.json();
        this.setState({ authors: data, loading: false });
    }
}
