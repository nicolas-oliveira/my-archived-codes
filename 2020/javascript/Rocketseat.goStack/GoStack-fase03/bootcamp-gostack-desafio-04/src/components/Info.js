import React from 'react';

import LikeBlueIcon from '../icons/LikeBlueIcon';
import LikeIcon from '../icons/LikeIcon';
import CommentIcon from '../icons/CommentIcon';

import '../styles/Info.css';
function likeCounter(likes, first, second) {
  if(likes == 1){
    return `${first}`;
  } if(likes == 2) {
    return `${first} e ${second}`;
  } else if(likes <= 5) {
    return `${first} e outras ${likes - 1} pessoas`;
  } else {
    return likes;
  }
}
export default class Info extends React.Component {
  render() {
    const likes = this.props.likes.length;
    return (
      <div className="info">
        <div className="likeBox">
          <div className="like">
            <LikeBlueIcon width="16px" />
            <p>
              { 
                likeCounter(likes, this.props.likes[0], this.props.likes[1])
              }
            </p>
            <div className="infoBox">

            </div>
          </div>
          <p>
            { 
              this.props.comments == 1 
                ? `${this.props.comments} comentário` 
                : `${this.props.comments} comentários` 
            }
          </p>
        </div>

        <hr id="lineTop" />

        <div className="buttons">
          <div className="button" id="curtir">
            <LikeIcon />
            <span>Curtir</span>
          </div>
          <div className="button" id="comentar">
            <CommentIcon />
            <span>Comentar</span>
          </div>
        </div>
      </div>
    );
  }
}