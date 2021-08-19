import React from 'react';
import withContext from '../withContext';
import BookHead from './BookHead';

const CheckoutItem = props => {

    const { cartItem, cartKey } = props;
    const { book, amount } = cartItem;

    return (
        <>
            <div class="clearfix">
                <BookHead book={book} page="checkout" />
            </div>
        </>
    );
}

export default withContext(CheckoutItem);