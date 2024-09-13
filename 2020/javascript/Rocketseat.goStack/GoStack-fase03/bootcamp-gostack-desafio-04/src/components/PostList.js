import React from 'react';

import Post from './Post';
import '../styles/PostList.css';

import avatar1 from '../../images/avatar1.jpeg';
import avatar2 from '../../images/avatar2.jpeg';
import avatar3 from '../../images/avatar3.jpeg';
import avatar4 from '../../images/avatar4.jpeg';
import avatar5 from '../../images/avatar5.jpeg';
import avatar6 from '../../images/avatar6.jpeg';


export default class PostList extends React.Component {
  state = {
    posts: [
      {
        id: 1,
        author: {
          name: "Júlio Alvarenga Pinto",
          avatar: avatar2
        },
        likes: [
          "Fernanda Oliveira",
          "Ednaldo Pereira",
          "Jéssica Flores",
        ],
        date: "04 Jun 2020",
        content: "Pessoal, alguém sabe se a Rocketseat está dando dinheiro de graça?",
        comments: [
          {
            id: 1,
            author: {
              name: "Cézar Fernandes",
              avatar: avatar3
            },
            content: "Parece que a RocketSeat comprou a Coreia do Norte, nesse caso deve ser bem possível. Mas você tem que morar na África."
          }
        ]
      },
      {
        id: 2,
        author: {
          name: "Fernanda Oliveira",
          avatar: avatar4
        },
        date: "02 Jun 2020",
        content: "Pessoal, vocês foram no show do Léo lins?",
        likes: [
            "Fernanda Oliveira",
            "Ednaldo Pereira",
            "Jéssica Flores",
            "Felipe Tavares",
            "Ronaldo Silva",
            "Ronaldinho Gaúcho"
        ],
        comments: [
          {
            id: 1,
            author: {
              name: "Ednaldo Pereira",
              avatar: avatar5
            },
            content: "Eu fui! Por causa da pandemia todo mundo foi de carro, as risadas eram buzinas."
          },
          {
            id: 2,
            author: {
              name: "Jéssica Flores",
              avatar: avatar6
            },
            content: "Eu não! Esse cara é mó babaca!",
          },
          {
            id: 3,
            author: {
              name: "Edgar Oliveira",
              avatar: avatar1
            },
            content: "Eu fui!",
          }
        ]
      }
    ]
  };


  render() {
    return (
      <div className="postList">
        { 
          this.state.posts.map( post => <Post 
            key={ post.id } 
            author={ post.author }
            date={ post.date } 
            content={ post.content }
            comments={ post.comments }
            likes={ post.likes }
          />)
        }
      </div>
    );
  }
}