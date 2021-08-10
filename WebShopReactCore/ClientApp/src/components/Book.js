import { extend } from 'jquery';
import React, { Component } from 'react';

export class Book extends Component {
    constructor(props) {
        super(props);
    }
    /*
     * book:
     * title
     * 
     * 
     * 
     */

    render() {
        return (
            <div><h2>{this.props.book.title}</h2></div>
        )
    }
}