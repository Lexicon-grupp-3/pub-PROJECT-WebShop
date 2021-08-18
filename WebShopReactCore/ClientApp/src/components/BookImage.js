import React, { Component } from 'react';
import './styles/BookImage.css';

export class BookImage extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        if (this.props.page === "home" || this.props.page === "cart") {
            return (
                <img className="bookCoverSmall" src={this.props.src} />
            );
        }
        return (
            <img className="bookCover" src={this.props.src} />
        );
    }
}