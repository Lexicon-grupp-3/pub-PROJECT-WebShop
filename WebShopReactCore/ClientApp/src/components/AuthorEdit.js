import React from 'react';
import withContext from '../withContext';

const AuthorEdit = props => {

    const author = props.context.authorCurrent;
    var x = 1;
    return (
        <>
            <h4>En författare</h4>
            {/*    {content}*/}

            <form onSubmit={props.context.authorEditSubmit}>
                <label>
                    Förnamn:
                    <input type="text" value={author.firstName} onChange={props.context.handleChangeFirstName} />
                </label>
                <label>
                    Efternamn:
                    <input type="text" value={author.lastName} onChange={props.context.handleChangeLastName} />
                </label>
                <input type="submit" value="Spara" />
            </form>
            <button type="button"
                onClick={() =>
                    props.context.goBack()}>
                {"Avbryt"}
            </button>
        </>
    );

};

export default withContext(AuthorEdit);