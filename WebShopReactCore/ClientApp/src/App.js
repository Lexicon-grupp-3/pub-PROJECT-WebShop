import React, { Component } from 'react';
import { Switch, Route, Link, BrowserRouter as Router } from 'react-router-dom';

//import { Route } from 'react-router';
import { Layout } from './components/Layout';
import Home from './components/Home';
import AuthorList from './components/AuthorList';
import AuthorDetail from './components/AuthorDetail';
import AuthorEdit from './components/AuthorEdit';
import AuthorNew from './components/AuthorNew';

import { ListBooks } from './components/ListBooks';

import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';

import Context from './Context';

import './custom.css'


export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
        this.state = {
            loading: true,
            authors: [],
            authorCurrent: {}
        };
        this.routerRef = React.createRef();
        this.authorDetail = this.authorDetail.bind(this);
        this.authorEdit = this.authorEdit.bind(this);
        this.authorEditSubmit = this.authorEditSubmit.bind(this);
        this.authorNew = this.authorNew.bind(this);
        this.authorDelete = this.authorDelete.bind(this);
        this.handleChange = this.handleChange.bind(this);
        this.handleChangeFirstName = this.handleChangeFirstName.bind(this);
        this.handleChangeLastName = this.handleChangeLastName.bind(this);
        this.goBack = this.goBack.bind(this);
    }

    async componentDidMount() {
        const promise = await fetch('AuthorBook/Authors');
        const authors = await promise.json();
        this.setState({ authors, loading: false });
    }

    async authorDetail(authorX) {
        //let author = authorX.author;
        let authorCurrent = JSON.parse(JSON.stringify(authorX.author));
        this.setState({ authorCurrent })
        this.routerRef.current.history.push("/authorDetail")
    }
    async authorEdit(authorX) {
        //let author = authorX.author;
        let authorCurrent = JSON.parse(JSON.stringify(authorX.author));
        this.setState({ authorCurrent })
        this.routerRef.current.history.push("/authorEdit")
    }
    async authorNew(authorX) {
        let author = authorX.author;
        this.setState({ author })
        this.routerRef.current.history.push("/authorNew")
    }
    async authorDelete(authorX) {
        //let author = authorX.author;
        let authorCurrent = JSON.parse(JSON.stringify(authorX.author));
        //this.setState({ authorCurrent })
        this.setState({ loading: true });
        const response2 = await fetch('AuthorBook/AuthorDelete'
            , {
                method: 'POST',
                mode: 'cors',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    id: authorCurrent.id,
                    firstName: authorCurrent.firstName,
                    lastName: authorCurrent.lastName
                })
            }
        );
        const data1 = await response2.blob();
        this.setState({ authorCurrent: {} });

        this.setState({ loading: true });
        const response = await fetch('AuthorBook/Authors');
        const data2 = await response.json();
        this.setState({ authors: data2, loading: false });

//        this.routerRef.current.history.goBack();
    }

    async handleChange(event) {
        this.setState({ value: event.target.value });
    }
    async handleChangeFirstName(event) {
        let author = this.state.authorCurrent;
        author.firstName = event.target.value;
        this.setState({ author })
    }
    async handleChangeLastName(event) {
        let author = this.state.authorCurrent;
        author.lastName = event.target.value;
        this.setState({ author })
    }

    async authorEditSubmit(event) {
        event.preventDefault();
        let authorCurrent = this.state.authorCurrent;
        const response2 = await fetch('AuthorBook/AuthorNew'
            , {
                method: 'POST', // *GET, POST, PUT, DELETE, etc.
                mode: 'cors', // no-cors, *cors, same-origin
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    id: authorCurrent.id,
                    firstName: authorCurrent.firstName,
                    lastName: authorCurrent.lastName
                }) // body data type must match "Content-Type" header
            }
        );
        await response2.json();
        this.setState({ authorCurrent })

        // Nyläsning för omsortering behövs
        this.setState({ loading: true });
        const response = await fetch('AuthorBook/Authors');
        const data2 = await response.json();
        this.setState({ authors: data2, loading: false });

        this.routerRef.current.history.goBack();
    }

    async goBack() {
        this.routerRef.current.history.goBack();
    }

    render() {
        return (
            <Context.Provider
                value={{
                    ...this.state,
                    authorDetail: this.authorDetail,
                    authorEdit: this.authorEdit,
                    authorEditSubmit: this.authorEditSubmit,
                    authorNew: this.authorNew,
                    authorDelete: this.authorDelete,
                    handleChange: this.handleChange,
                    handleChangeFirstName: this.handleChangeFirstName,
                    handleChangeLastName: this.handleChangeLastName,
                    goBack: this.goBack
                }}
            >
                <Router ref={this.routerRef}>
                    <div className="App">
                        <Layout>
                            <Switch>

                                <Route exact path='/' component={Home} />
                                <Route exact path='/home' component={Home} />

                                <AuthorizeRoute path='/list-authors' component={AuthorList} />
                                <AuthorizeRoute path='/authorDetail' component={AuthorDetail} />
                                <AuthorizeRoute path='/authorNew' component={AuthorNew} />
                                <AuthorizeRoute path='/authorEdit' component={AuthorEdit} />

                                <AuthorizeRoute path='/list-books' component={ListBooks} />

                                <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
                            </Switch>
                        </Layout >
                    </div>
                </Router>
            </Context.Provider>
        );
    }
}
