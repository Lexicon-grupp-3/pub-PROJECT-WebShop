import React from 'react';
import withContext from '../withContext';

const AuthorEdit = props => {
    var y = 3;
    const author1 = props.context.authorCurrent;
    var x = 1;
    return (
        <>
            <h4>En författare</h4>
            {/*    {content}*/}

            <form onSubmit={props.context.authorEditSubmit}>
                <label>
                    Förnamn:
                    <input type="text" value={author1.firstName} onChange={props.context.handleChangeFirstName} />
                </label>
                <label>
                    Efternamn:
                    <input type="text" value={author1.lastName} onChange={props.context.handleChangeLastName} />
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