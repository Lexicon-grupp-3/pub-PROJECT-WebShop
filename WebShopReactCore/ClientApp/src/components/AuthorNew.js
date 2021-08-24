import React from 'react';
import withContext from '../withContext';

const AuthorNew = props => {

    const author = props.context.authorCurrent;
    return (
        <>
            <div>
                <h4>Den här författaren</h4>
                {/*    {content}*/}
                <p>{author.id}</p>
                <p>{author.lastName}</p>
                <p>{author.firstName}</p>

            </div>
            <form onSubmit={props.context.authorSubmitEdit()}>
                <label>
                    Förnamn:
                    <input type="text" value={author.firstName}  />
                </label>
                <label>
                    Efternamn:
                    <input type="text" value={author.lastName}  />
                </label>
                <input type="submit" value="Skapa" />
            </form>
            <button type="button"
                onClick={() =>
                    props.context.goBack()}>
                {"Avbryt"}
            </button>
        </>
    );

};

export default withContext(AuthorNew);