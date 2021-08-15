import React, { Component } from 'react';
import { useParams, useHistory } from 'react-router-dom';

export class AuthorDetail2 extends Component {
    static displayName = AuthorDetail2.name;

    constructor(props) {
        super(props);
        this.state = { author: [], loading: true };
    }

    componentDidMount() {
        this.populateAuthorDetail2();
    }

    static renderAuthorDetail2(author) {
        return (
            <div>
                <h3>Detalj2</h3>
                <p>id        {author.id}</p>
                <p>Förnamn   {author.firstName}</p>
                <p>Efternamn {author.lastName}</p>
                <hr />
                <div class="row">
                    <div class="col-md-4">
                        <form asp-action="AuthorEdit">
                            <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                            <div class="form-group">
                                <label asp-for="FirstName" class="control-label"></label>
                                <input asp-for="FirstName" class="form-control" />
                                <span asp-validation-for="FirstName" class="text-danger"></span>
                            </div>
                            <div class="form-group">
                                <label asp-for="LastName" class="control-label"></label>
                                <input asp-for="LastName" class="form-control" />
                                <span asp-validation-for="LastName" class="text-danger"></span>
                            </div>
                            <div class="form-group">
                                <input type="submit" value="Uppdatera" class="btn btn-primary" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        );
    }

    render() {
        //const { id } = useHistory();
        //const { id } = useParams();

        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : AuthorDetail2.renderAuthorDetail2(this.state.author);

        return (
            <div>
                <h1>Författare detaljer  </h1>
                {contents}
            </div>
        );
    }

    async populateAuthorDetail2() {
        var fakeID = 4;

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
