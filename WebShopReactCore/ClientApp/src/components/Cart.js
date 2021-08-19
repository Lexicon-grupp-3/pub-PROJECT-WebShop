import React from 'react';
import withContext from '../withContext';
import CartItem from './CartItem';
import './styles/Cart.css';

const Cart = props => {

    const { cart } = props.context;
    const cartKeys = Object.keys(cart || {});
    let totalAmount = 0;

    return (
        <>
            <div className="cartWrapper" >
                <div className="container">
                    {cartKeys.length ? (
                        <div className="row">
                            {
                                cartKeys.map(key =>
                                    <>
                                        <CartItem
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
                            Korgen är tom!
                        </div>
                    )

                    }

                </div>
                <div className="totalAmount">
                    <button type="button" className="btn btn-primary btn-checkout"
                        onClick={() => props.context.checkout()}
                    >Checkout
                    </button>
                    <button type="button" className="btn btn-danger"
                        onClick={() => props.context.emptyCart()}
                    >Töm Korgen
                    </button>
                    Totalt: {totalAmount.toFixed(2)}Kr
                </div>
            </div >
        </>
    )
}

export default withContext(Cart);