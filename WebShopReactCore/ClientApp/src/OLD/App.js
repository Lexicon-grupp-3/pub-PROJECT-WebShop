import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { ListAuthors } from './components/ListAuthors';
import { ListBooks } from './components/ListBooks';
import { BookDetailsPage } from './components/BookDetailsPage';
import { PageName } from './components/templateComponentPage';
import { AuthorListPage } from './components/AuthorListPage';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';

import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/counter' component={Counter} />
                <Route path='/bookdetailspage/:authorid' component={BookDetailsPage} />
                <Route path='/page-name' component={PageName} />
                <Route path='/author-list-page' component={AuthorListPage} />
                <AuthorizeRoute path='/fetch-data' component={FetchData} />
                <Route path='/list-authors' component={ListAuthors} />
                <Route path='/list-books' component={ListBooks} />
                <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
            </Layout>
        );
    }
}
