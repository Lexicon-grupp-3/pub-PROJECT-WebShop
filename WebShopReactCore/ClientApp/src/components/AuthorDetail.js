import React from 'react';
import withContext from '../withContext';

const AuthorDetail = props => {

    const author = props.context.author;
    //const authors = props.context.authors;
    //const { authors } = props.context;
    //let content = props.context.loading ?
    //    <p><strong>Data Loading ...</strong></p>
    //    : <AuthorList authorList={props.context.authors} page="authorList" />;
    return (
        <>
            <div>
                <h4>Den här författaren</h4>
                {/*    {content}*/}
                <p>{author.id}</p>
                <p>{author.lastName}</p>
                <p>{author.firstName}</p>

            </div>
        </>
    );

};

export default withContext(AuthorDetail);