import React, { Component } from 'react';

export class BookDetailsPage extends Component {
    static displayName = BookDetailsPage.name;
     
    render() {
        return (
            <div>
                <div className='image'>
                    <img src="" alt="" />
                </div>
                <div className='bookInfo'>
                    <h1>Bok Titel</h1>
                    <input value="Forfattare namn" />
                    <input value="pris" />
                    <button>Kop bok</button>
                    <button>Lagg till i onskelista</button>
                </div>
                <div className="description">
                    <textarea>{this.props.textarea}</textarea>
                </div>
                <div>{this.props.detailsType}<br />{BookDetailsPage.name}{this.props.displayName}</div>
            </div>
        );
    }
}
