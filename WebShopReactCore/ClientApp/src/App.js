import React, { Component } from 'react';
import { Route } from 'react-router';
import { Routes, Switch, BrowserRouter as Router } from 'react-router-dom';
import { Layout } from './components/Layout';
import Home  from './components/Home';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import { ResourceNotFound } from './components/ResourceNotFound';

import Context from './Context';

export default class App extends Component {
    static displayName = App.name;
    constructor(props) {
        super(props);
        this.state = {
            cart: {},
            bookList: [],
            book: {},
            loading: true
        };
        this.routerRef = React.createRef();
    }

    async componentDidMount() {
        let cart = localStorage.getItem("cart");
        const promise = await fetch('AuthorBook/BookList');
        const bookList = await promise.json();
        cart = cart ? JSON.parse(cart) : {};
        this.setState({ bookList, loading: false, cart });
    }

    render() {
        const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
        return (
            <Context.Provider
                value={{
                    ...this.state,
                    removeFromCart: this.removeFromCart,
                    addToCart: this.addToCart,
                    login: this.login,
                    addProduct: this.addProduct,
                    clearcart: this.clearCart,
                    checkout: this.checkout
                }}
            >
                <Router basename={baseUrl} ref={this.routerRef}>
                    <Layout>
                        <Switch>
                            <Route exact path='/' component={Home} />
                            <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
                            <Route path='*' component={ResourceNotFound} />
                        </Switch>
                    </Layout>
                </Router>
            </Context.Provider>
        );
    }
}
