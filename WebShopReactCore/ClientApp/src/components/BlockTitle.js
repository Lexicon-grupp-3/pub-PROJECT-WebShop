import React, { Component } from 'react';
import './styles/BlockTitle.css';

export class BlockTitle extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        let classText = "";
        if (this.props.titleType == "pagehead") {
            classText = "pageTitle";
        }
        else if (this.props.titleType == "booktitle") {
            classText = "bookTitle";
        }
        else {
            classText = "default";
        }
        return (
            <p className={classText}>{this.props.title}</p>
        );
        
    }
}