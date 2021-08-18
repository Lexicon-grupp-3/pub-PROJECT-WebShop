import React, { Component } from 'react';
import './styles/BookAuthors.css';

export class BookAuthors extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        const authors = this.props.authors;
        let text = "";
        const content = authors.map(author => {
            if (text === "") {
                text = author.fullName;
            }
            else {
                text = text + ", " + author.fullName;
            }
        })

        if (this.props.page == 'home') {
            return (
                <p className="authorsSub">
                    {text}
                </p>
            );
        }

        return (
            <p className="authorsString">
                {text}
            </p>
        );

    }
}