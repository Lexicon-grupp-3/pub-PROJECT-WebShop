import React from 'react';
import withContext from '../withContext';

const AuthorDetail = props => {

    const author = props.context.authorCurrent;
    return (
        <>
            <div>
                <h4>En författare</h4>
                <p>{author.id}</p>
                <p>{author.lastName}</p>
                <p>{author.firstName}</p>
                <button type="button"
                    onClick={() =>
                        props.context.goBack()}>
                    {"Tillbaka"}
                </button>
            </div>
        </>
    );

};

export default withContext(AuthorDetail);