import React, { Component } from 'react';
import { useRouteMatch } from 'react-router-dom';


function AuthorListPage() {

    const { params: { authorid }, } = useRouteMatch('/author-list-page/:authorid');
   
        return(
            <div>
                Author id: {authorid}
            </div>
        );
}

export default AuthorListPage;
