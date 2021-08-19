import React from 'react';
import withContext from '../withContext';
import CheckoutItem from './CheckoutItem';
import './styles/Checkout.css';

const Checkout = props => {

    const { cart, userName, isAuthenticated } = props.context;
    const cartKeys = Object.keys(cart || {});
    let totalAmount = 0;

    const preCheckout = e => {
        e.preventDefault();
        let user = document.getElementById("user").value;

        if (user != "")
            props.context.payment(user);
    }

    return (
        <>
            <div className="cartWrapper" >
                <div className="container">
                    <div className="col">
                        {(isAuthenticated) ?
                            (
                                <input type="text" disabled value={userName} />
                            ) : (
                                    cartKeys.length ? (
                                        <form id="form" >
                                            <input name="user" id="user" placeholder="name@example.com" />
                                        </form>
                                    ) : (<></>)
                                )
}
                        {cartKeys.length ? (
                            <div className="row">
                                {
                                    cartKeys.map(key =>
                                        <>
                                            <CheckoutItem
                                                cartKey={key}
                                                key={key}
                                                cartItem={cart[key]}
                                                removeFromCart={props.context.removeFromCart}
                                            />
                                            <div className="col">
                                                <div className="bookPrice">{cart[key].book.price.toFixed(2)}Kr</div>
                                            </div>
                                            <div className="col float-right">
                                                <div className="removeItem"
                                                    onClick={() => props.context.removeFromCart(key)}
                                                >
                                                    <i className="far fa-trash-alt"></i>
                                                </div>
                                            </div>
                                            <div style={{ display: "none" }}>
                                                {totalAmount += cart[key].book.price}
                                            </div>
                                            <div className="w-100"></div>

                                        </>
                                    )
                                }
                            </div>

                        ) : (
                            <div class="col">
                                Ordern är betald! <br />Tack för din beställning.
                            </div>
                        )

                        }
                    </div>
                </div>
                {(cartKeys.length > 0) ? (
                    <div className="totalAmount">
                        <button type="submit" form="form" className="btn btn-primary btn-checkout"
                            onClick={preCheckout}
                        >Betala
                        </button>
                        Att betala: {totalAmount.toFixed(2)}Kr
                    </div>
                ) : (<></>)
                }
            </div >
        </>
    )
}

export default withContext(Checkout);