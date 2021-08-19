import React, { Component } from 'react';
import { Route } from 'react-router';
import { Routes, Switch, BrowserRouter as Router } from 'react-router-dom';
import { Layout } from './components/Layout';
import BookDetail from './components/BookDetail';
import Home from './components/Home';
import Cart from './components/Cart';
import Orders from './components/Orders';
import Checkout from './components/Checkout';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import authService, { AuthenticationResultStatus } from './components/api-authorization/AuthorizeService';
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
            loading: true,
            userName: "",
            user: null,
            isAuthenticated: false
        };
        this.routerRef = React.createRef();
        this.handleBookDetail = this.handleBookDetail.bind(this);
        authService.subscribe(this.handleAuthorization);
    }

    async componentDidMount() {
        let cart = localStorage.getItem("cart");
        //let orderTotal = localStorage.getItem("orderTotal");
        let userId = localStorage.getItem("userId");
        const promise = await fetch('AuthorBook/BookList');
        const bookList = await promise.json();
        cart = cart ? JSON.parse(cart) : {};
        const book = {};
        const [isAuthenticated, user] = await Promise.all([authService.isAuthenticated(), authService.getUser()]);
        const userName = user != null ? user.name : "";
        this.setState({ isAuthenticated, userName, user, book, bookList, loading: false, cart });
        this._subscription = authService.subscribe(() => this.handleAuthorization());
    }

    componentWillUnmount() {
        authService.unsubscribe(this._subscription);
    }

    async handleAuthorization() {
        const [isAuthenticated, user] = await Promise.all([authService.isAuthenticated(), authService.getUser()]);
        const userName = user != null ? user.name : "";
        this.setState({
            isAuthenticated,
            userName
        });
        localStorage.setItem("userId", userName);
    }

    addToCart = cartItem => {
        let cart = this.state.cart;
        //let orderTotal = this.state.orderTotal;


        // Amount and stock are not implemented.
        if (cart[cartItem.id]) {
            cart[cartItem.id].amount += cartItem.amount;
            cart[cartItem.id].userName = this.state.userName;
        }
        else {
            cart[cartItem.id] = cartItem;
            cart[cartItem.id].userName = this.state.userName;
        }
        if (cart[cartItem.id].amount > cart[cartItem.id].book.stock) {
            cart[cartItem.id].amount = cart[cartItem.id].book.stock;
        }
        //orderTotal += cartItem.amount * cartItem.book.price;

        localStorage.setItem("cart", JSON.stringify(cart));

        this.setState({ cart });
    }

    checkout = () => {
        //let cart = this.state.cart;

        this.routerRef.current.history.push("/checkout");
    }

    emptyCart = () => {
        let cart = {};
        localStorage.removeItem("cart");
        this.setState({ cart });
    }

    async handleBookDetail(bookItem) {
        let book = bookItem.book;
        this.setState({ book });
        this.routerRef.current.history.push("/bookdetail");
    }

    async payment(user, orderTotal) {
        const cartKeys = Object.keys(this.cart || {});
        // register order, as payed and store on server.
        // empty cart.
        let json = `{
                    "userEmail":\"${user}\",
                    "OrderTotal":${orderTotal},
                    "OrderItems":[`;

        for (let i = 0; i < cartKeys.length; i++) {
            let tmp = this.cart[cartKeys[i]];
            if (i === 0) {
                json += '{';
            }
            else {
                json += ',{';
            }
            json += `"BookId":${tmp.book.bookId}`;
            json += `,"Quantity":${tmp.amount}`;
            json += `,"Price":${tmp.book.price}`;
            json += '}';
        }
        json += ']}';
        //await this.putData(json, "/Order/SaveOrder");

        // test
        let url = "/Order/SaveOrder";

        // Test code for server.
        let tmp = "Test text to parse on the server";
        const response = await fetch(
            url,
            {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: `${JSON.stringify(json)}`
            }
        );

        // Original code!
        //const response = await fetch(
        //    url,
        //    {
        //        method: 'PUT',
        //        headers: {
        //            'Content-Type': 'application/json'
        //        },
        //        body: JSON.stringify(json)
        //    }
        //);
        // end test
        this.emptyCart();
    }

    removeFromCart = cartItemId => {
        let cart = this.state.cart;
        delete cart[cartItemId];
        localStorage.setItem("cart", JSON.stringify(cart));
        this.setState({ cart });
    }

    removeUserId = props => {
        let userId = null;
        localStorage.removeItem("userId");
        this.setState({ userId });
    }

    async putData(data, url) {
        const response = await fetch(
            url,
            {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(data)
            }
        );
    }

    setUserId = id => {
        let userId = id;
        localStorage.setItem("userId", JSON.stringify(userId));
        this.setState({ userId });
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
                    addToCart: this.addToCart,
                    emptyCart: this.emptyCart,
                    setUserId: this.setUserId,
                    removeUserId: this.removeUserId,
                    payment: this.payment
                }}
            >
                <Router basename={baseUrl} ref={this.routerRef}>
                    <Layout>
                        <Switch>
                            <Route exact path='/' component={Home} />
                            <Route exact path='/bookdetail' component={BookDetail} />
                            <Route exact path="/cart" component={Cart} />
                            <Route exact path="/checkout" component={Checkout} />
                            <AuthorizeRoute exact path='/orders' component={Orders} />
                            <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
                            <Route path='*' component={ResourceNotFound} />
                        </Switch>
                    </Layout>
                </Router>
            </Context.Provider>
        );
    }
}
