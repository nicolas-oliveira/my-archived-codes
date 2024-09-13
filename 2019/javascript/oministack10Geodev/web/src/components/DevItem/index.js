import React  from 'react';
import './styles.css';

function DevItem({dev}){
    //const {dev} = props;
    /* Definição do elemento DevItem que contém a informação dos Devs cadastrados */
    return(
        <li key={dev._id} className="dev-item">
            <header>
                <img src={dev.avatar_url} alt={dev.name}></img>
                <div className="user-info">
                    <strong>{dev.name}</strong>
                    <span>{dev.techs.join(',')}</span>
                </div> 
            </header>
            <p>{dev.bio}</p>
            <a href={`https://github.com/${dev.github_username}`} target="_blank">Acessar perfil no Github</a>
        </li> 
    );
}
export default DevItem;
