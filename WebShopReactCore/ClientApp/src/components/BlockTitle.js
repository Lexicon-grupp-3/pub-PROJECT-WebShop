import React, { Component } from 'react';
import './styles/BlockTitle.css';

export class BlockTitle extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        if (this.props.titleType == "pagehead") {
            return (
                <p className="pageTitle">{this.props.title}</p>
            );
        }
        else if (this.props.titleType == "booktitle") {
            return (
                <p className="bookTitle">{this.props.title}</p>
            );
        }
        return (
            <p className="default">{this.props.title}</p>
        );
    }
}