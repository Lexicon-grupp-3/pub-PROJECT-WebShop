import React, { Component } from 'react';
import { Route } from 'react-router';
import { Routes, Switch, BrowserRouter as Router } from 'react-router-dom';
import { Layout } from './components/Layout';
import BookDetail from './components/BookDetail';
import Home from './components/Home';
import Cart from './components/Cart';
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
        this.handleBookDetail = this.handleBookDetail.bind(this);
    }

    async componentDidMount() {
        let cart = localStorage.getItem("cart");
        const promise = await fetch('AuthorBook/BookList');
        const bookList = await promise.json();
        cart = cart ? JSON.parse(cart) : {};
        const book = {};
        this.setState({ book, bookList, loading: false, cart });
    }

    addToCart = cartItem => {
        let cart = this.state.cart;
        if (cart[cartItem.id]) {
            cart[cartItem.id].amount += cartItem.amount;
        }
        else {
            cart[cartItem.id] = cartItem;
        }
        if (cart[cartItem.id].amount > cart[cartItem.id].book.stock) {
            cart[cartItem.id].amount = cart[cartItem.id].book.stock;
        }
        localStorage.setItem("cart", JSON.stringify(cart));
        this.setState({ cart });
    }

    async handleBookDetail(bookItem) {
        let book =bookItem.book; 
        this.setState({ book });
        this.routerRef.current.history.push("/bookdetail");
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
                    checkout: this.checkout,
                    handleBookDetail: this.handleBookDetail,
                    addToCart: this.addToCart
                }}
            >
                <Router basename={baseUrl} ref={this.routerRef}>
                    <Layout>
                        <Switch>
                            <Route exact path='/' component={Home} />
                            <Route exact path='/bookdetail' component={BookDetail} />
                            <Route exact path="/cart" component={Cart} />
                            <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
                            <Route path='*' component={ResourceNotFound} />
                        </Switch>
                    </Layout>
                </Router>
            </Context.Provider>
        );
    }
}
