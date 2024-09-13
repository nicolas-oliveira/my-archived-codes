import React, { useState, useEffect } from 'react';

export default function App(){
  const [repositories, setRepositories] = useState([]);
  // const [favorite, setFavorites] = useState([]);
  
  useEffect(async () => {
    const response = await fetch('https://api.github.com/users/nicolas-oliveira/repos'); 
    /* Faz uma requisição para a API do Github */
    const data = await response.json(); /* Torna a resposta como JSON */

    setRepositories(data); /* Retorna as informações  */
  }, []);
  
  useEffect(() => {
      const filtered = repositories.filter(repo => repo.favorite);
      
      document.title = `Você tem ${filtered.length} favoritos`; 
      /* Coloca no titulo da janela o numero de repositorios favoritados */
  },[repositories]); /* Cria uma estado que é avaliado sempre que as propriedades do repo são mudadas */

  function handleFavorite(id) {
    const  newRepositories = repositories.map(repo => {
      return repo.id === id ? {...repo, favorite: !repo.favorite} : repo; 
      /* Muda a a propriedade conforme o selecionado true/false */
    });

    setRepositories(newRepositories); /* Retorna as informações */
  }
  
  return (
      <ul>
        {
          repositories.map(repo =>(
            <li key={repo.id}>
            {repo.name} 
            {repo.favorite && <span>(Favorito)</span>}
            <button onClick={()=>handleFavorite(repo.id)}>Favoritar</button>
            </li>
          ))
        }
      </ul>
  );
};
