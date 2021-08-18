import React from 'react';
import OrderItem from './OrderItem';
import withContext from '../withContext';

const Orders = props => {
    return (
        <>Orders<br />1: {props.context.userName}<br />2: </>
    );
}

export default withContext(Orders);