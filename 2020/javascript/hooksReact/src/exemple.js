import React, { useState, useEffect } from 'react';

export default function App(){
  const [repositories, setRepositories] = useState([
    {id: 1, nome: 'repo-1'},
    {id: 2, nome: 'repo-2'},
    {id: 3, nome: 'repo-3'},
  ]);
  function handleAddRepository(){
    setRepositories([
      ...repositories,
      {ide: Math.random(), name: 'Novo Repo'}
    ]);
  }
  return (
    <>
      <ul>
        {
          repositories.map(repo =>(
            <li key={repo.id}>{repo.name}</li>
          ))
        }
      </ul>
      <button onClick={handleAddRepository}>
        Adicionar Repositorio
      </button>
    </>
  );
};
