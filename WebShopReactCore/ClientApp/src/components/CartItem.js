import React from 'react';
import withContext from '../withContext';
import  BookHead  from './BookHead';

const CartItem = props => {

    const { cartItem, cartKey } = props;
    const { book, amount } = cartItem;

    return (
        <>
            <div class="clearfix">
                <BookHead book={book} page="cart" />
            </div>
        </>
    );
}

export default withContext(CartItem);