import React from 'react';

export default class Avatar extends React.Component {
  render() {
    return (
      <div className="avatar">
        <img src={ this.props.avatar } id="avatar"></img>
        <div className="info">
          <h3>{ this.props.name }</h3>
          <p>{ this.props.date }</p>
        </div>
      </div>
    );
  }
};