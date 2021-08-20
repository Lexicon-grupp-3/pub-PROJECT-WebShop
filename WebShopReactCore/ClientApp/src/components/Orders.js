import React, { Component } from 'react';
import OrderItem from './OrderItem';
import withContext from '../withContext';

class Orders extends Component {
    constructor(props) {
        super(props);
        this.props = props;
    }

    async componentDidMount() {
        this.props.context.loadOrders(this.props.context.userName);
    }

    render() {
        const items = this.props.context.orders.map((item) => <h2>{item.bookId}</h2>);
        return (
            <>Orders

            </>
        );
    }
}

export default withContext(Orders);


//if (this.props.page == "home") {
//    const bookItems = books.map((book) =>
//        <Book key={book.bookId} book={book} page={this.props.page} />);

//    return (
//        <div className="bookList">
//            {bookItems}
//        </div>
//    )
//}