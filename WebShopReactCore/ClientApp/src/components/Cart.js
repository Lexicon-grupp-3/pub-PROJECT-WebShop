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
                                    <div className="col">
                                        <div className="media-right"
                                            onClick={() => props.context.removeFromCart(key)}
                                        >
                                            <i className="far fa-trash-alt"></i>
                                        </div>
                                    </div>
                                    <div style={{ visibility: "hidden" }}>
                                        {totalAmount += cart[key].book.price}
                                    </div>
                                    <div className="w-100"></div>
                                
                                </>
                            )
                        }
                    </div>

                ) : (
                    <div class="col">
                        Korgen tom!
                    </div>
                )
                    
                }
                
            </div>
            <div className="totalAmount">
                    Totalt: {totalAmount.toFixed(2)}Kr
                    </div>
        </div >
        </>
    )
}

export default withContext(Cart);