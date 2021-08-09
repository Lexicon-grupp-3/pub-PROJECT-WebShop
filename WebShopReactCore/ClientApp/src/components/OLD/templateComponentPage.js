import React, { Component } from 'react';
import { BookDetailsPage } from './BookDetailsPage';
import { Button } from './Button';
import { Link} from 'react-router-dom';

export class PageName extends Component {
    static displayName = PageName.name;

    handleClick = (value) => {
        console.log(value);
    };
    render() {
        return (
            <div>
                Content of page!
                <BookDetailsPage detailsType="test" textarea="Beskrivning av boken!" />
                <Link className="btn btn-primary" to={{ pathname: `/author-list-page/${"1234qwer"}` }}>Klicka Mig!</Link>
            </div>
        );
    }



}