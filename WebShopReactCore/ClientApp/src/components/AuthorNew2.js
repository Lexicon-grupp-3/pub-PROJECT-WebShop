import React, { Component } from 'react';
import { useParams, useHistory } from 'react-router-dom';
import './NavMenu.css';

export class AuthorNew2 extends React.Component {
    static displayName = AuthorNew.name;

    constructor(props) {
        super(props);
        this.state = {
            value: '', id: parseInt(this.props.id, 10),
            firstName: 'förnamn',
            lastName: 'efternamn',
            loading: true
        };

        this.handleChange = this.handleChange.bind(this);
        this.handleChangeFirstName = this.handleChangeFirstName.bind(this);
        this.handleChangeLastName = this.handleChangeLastName.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);

        //var xx = this.authorRead();
        this.authorRead();

    }

    handleChange(event) {
        this.setState({ value: event.target.value });
    }
    handleChangeFirstName(event) {
        this.setState({ firstName: event.target.value });
    }
    handleChangeLastName(event) {
        this.setState({ lastName: event.target.value });
    }

    async handleSubmit(event) {
        await this.authorNewX();
        //alert('Författaren heter: ' + this.state.firstName + ' ' + this.state.lastName);
        event.preventDefault();
        console.log('You clicked submit.');
    }


    static renderXXX(author) {
        return (
            <div>
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : AuthorNew.renderXXX(this.state.author);

        return (
            <div>
                <form onSubmit={this.handleSubmit}>
                    <label>
                        Förnamn:
                    <input type="text" value={this.state.firstName} onChange={this.handleChangeFirstName} />
                    </label>
                    <label>
                        Efternamn:
                    <input type="text" value={this.state.lastName} onChange={this.handleChangeLastName} />
                    </label>
                    <input type="submit" value="Skapa/Spara" />
                </form>
            </div>
        );
    }

    async authorNewX() {
        const response2 = await fetch('AuthorBook/AuthorNew'
            , {
                method: 'POST', // *GET, POST, PUT, DELETE, etc.
                mode: 'cors', // no-cors, *cors, same-origin
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    id: this.state.id,
                    firstName: this.state.firstName,
                    lastName: this.state.lastName
                }) // body data type must match "Content-Type" header
            }
        );
        const data = await response2.json();
        this.setState({ author: data, loading: false });
    }
    async authorRead() {
        const response1 = await fetch('AuthorBook/AuthorDetail'
            , {
                method: 'POST', // *GET, POST, PUT, DELETE, etc.
                mode: 'cors', // no-cors, *cors, same-origin
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ id: this.state.id }) // body data type must match "Content-Type" header
            }
        );
        const data1 = await response1.json();
        this.setState({
            author: data1,
            loading: false,
            firstName: data1.firstName,
            lastName: data1.lastName
        });
    }
}




export class AuthorNew3 extends Component {
    static displayName = AuthorNew.name;

    constructor(props) {
        super(props);
        this.state = { author: [], loading: true };
    }

    componentDidMount() {
        this.populateAuthorNew();
    }

    render() {
        //const { id } = useHistory();
        //const { id } = useParams();

        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : AuthorNew.renderAuthorNew(this.state.author);

        return (
            <div>
                <h1>Ny författare  </h1>
                {contents}
            </div>
        );
    }

    async populateAuthorNew() {
        var fakeID = 4;

        const response = await fetch('AuthorBook/AuthorDetail'
            , {
                method: 'POST', // *GET, POST, PUT, DELETE, etc.
                mode: 'cors', // no-cors, *cors, same-origin
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ id: fakeID }) // body data type must match "Content-Type" header
            }

        );
        const data = await response.json();
        this.setState({ author: data, loading: false });
    }

}
