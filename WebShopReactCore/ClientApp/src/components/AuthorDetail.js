import React, { Component } from 'react';
import { useParams, useHistory } from 'react-router-dom';

export class AuthorDetail extends Component {
    static displayName = AuthorDetail.name;

    constructor(props) {
        super(props);
        this.state = { author: [], loading: true };
    }

    componentDidMount() {
        this.populateAuthorDetail();
    }

    static renderAuthorDetail(author) {
        { var id3 = 483 };

        return (
            <div>
                <p>id        {author.id}</p>
                <p>Förnamn   {author.firstName}</p>
                <p>Efternamn {author.lastName}</p>
            </div>
        );
    }

    render() {
        //const { id } = useHistory();
        //const { id } = useParams();

        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : AuthorDetail.renderAuthorDetail(this.state.author);

        return (
            <div>
                <h1>Författare detaljer  </h1>
                {contents}
            </div>
        );
    }

    async populateAuthorDetail() {
        var fakeID = 3;

        const response = await fetch('AuthorBook/AuthorDetail'
            , {
                method: 'POST', // *GET, POST, PUT, DELETE, etc.
                mode: 'cors', // no-cors, *cors, same-origin
                headers: {'Content-Type': 'application/json'},
                body: JSON.stringify({ id: fakeID}) // body data type must match "Content-Type" header
            }

        );
        const data = await response.json();
        this.setState({ author: data, loading: false });
    }

    //async populateAuthorDetail() {
    //    //int idx = this.state.idin;
    //    const response = await fetch('AuthorBook/AuthorDetail');
    //    const data = await response.json();
    //    this.setState({ author: data, loading: false });
    //}


}
