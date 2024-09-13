import React, { useState, useEffect } from 'react';
import api from './services/api'; /* Importação da api axios método get */

/* Importação de todos os estilos da aplicação */
import './global.css';
import './app.css';
import './Sidebar.css';
import './Main.css';

/* Importação de todos os componentes */
import DevForm from './components/DevForm';
import DevItem from './components/DevItem';


function App(){

  const [devs , setDevs] = useState([]);

  useEffect(() => {
    async function loadDevs() {
      const response = await api.get('/devs');

      setDevs(response.data);
    }
    loadDevs();
  }, []);

  async function handleAddDev(data) {
    const response = await api.post('./devs', data);

    setDevs([...devs, response.data]);
  }
    
  return (
    <div id="app">
      <aside>
        <strong>Cadastrar</strong>
          <DevForm onSubmit={handleAddDev} />
        </aside>
      
      <main>
        <ul>
        {devs.map(dev => (
          <DevItem key={dev._id} dev={dev}/>
        ))}
        </ul>
      </main>
    </div>
  );
}

export default App;