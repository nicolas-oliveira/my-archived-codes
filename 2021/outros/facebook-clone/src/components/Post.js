import React from 'react';
import '../styles/Post.css';
import Avatar from './Avatar';
import Comment from './Comment';
import Info from './Info';

export default class Post extends React.Component {

  render() {
    const comments = this.props.comments.length;
    return (
      <div className="post">
        <div className="content">
          <Avatar 
            avatar={ this.props.author.avatar } 
            name={ this.props.author.name } 
            date={ this.props.date }
          />
          <div className="content-self">
            <p>{ this.props.content }</p>
          </div>
        </div>
        <Info 
          likes={ this.props.likes }
          comments={ comments }
        />

      <hr id="line"/>
      { 
        this.props.comments.map(comment => <Comment
          key={ comment.id }
          avatar={ comment.author.avatar } 
          name={ comment.author.name } 
          content={ comment.content }
        />)
      }
      </div>
    );
  }
}