import React, { Component } from 'react';
import { useParams } from 'react-router-dom';

export class AuthorDetail extends Component {
  static displayName = AuthorDetail.name;

    constructor(props) {
    super(props);
  //  this.state = { currentCount: 0 };
  //  this.incrementCounter = this.incrementCounter.bind(this);
  }

    render() {
        const { id } = useParams();

    return (
      <div>
            <h1>Författare  {id} </h1>

        <p>This is a simple example of a React component.</p>

      </div>
    );
  }
}
