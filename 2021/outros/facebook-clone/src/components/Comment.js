import React from 'react';
import '../styles/Comment.css';

export default class Comment extends React.Component {

  render() {
    return (
      <div className="comment">
        <img src={ this.props.avatar } id="avatar"></img>
        <div className="comment-self">
          <h3>{ this.props.name }</h3>
          <div className="content-self">
            <p>{ this.props.content }</p>
          </div>
        </div>
      </div>
    );
  }
}