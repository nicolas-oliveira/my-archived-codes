import React, {useState, useEffect} from 'react';

function DevForm({ onSubmit }){
    /* Definição dos estados dos formulários da aplicação */
    const [github_username, setGithub_username] = useState('');
    const [techs, setTechs] = useState('');
    const [latitude, setLatitude] = useState('');
    const [longitude, setLongitude] = useState('');

    /* Definição da função padrão do navegador getCurrentPositon 
    é executada quando a aplicação é aberta a primeira vez */
    useEffect(() => {
        navigator.geolocation.getCurrentPosition( // Aqui a func está em formato de callback desestruturando lat e long
          (position) => {
            const { latitude, longitude } = position.coords;
    
            setLatitude(latitude);
            setLongitude(longitude);  
          },
          (err) => {
            console.log(err);
          },
          {
            timeout: 30000, 
          }
        );
    }, []);
    /* Função de submit do cadastro de novos dados */
    async function handleSubmit(e) {
        e.preventDefault();

        await onSubmit({
            github_username,
            techs,
            latitude,
            longitude,
            });

                
        setGithub_username('');
        setTechs('');
    } 

    return (
        <form onSubmit={handleSubmit}>
        
            <div className="input-block">
              <label htmlFor="github_username">Usuário do Github</label>
              <input 
                name="github_username"
                id="github_username"
                required
                value={github_username}
                onChange ={e => setGithub_username(e.target.value)} /* Input com os estados do react */
              />
            </div>

            <div className="input-block">
              <label htmlFor="techs">Tecnologias</label>
              <input 
                name="techs"
                id="techs"
                required
                value={techs}
                onChange ={e => setTechs(e.target.value)}
              />
            </div>
            
            <div className="input-group">
              <div className="input-block">
                <label htmlFor="latitude">Latitude</label>
                <input 
                  type="number"
                  name="latitude" 
                  id="latitude" 
                  required value={latitude}
                  onChange={ e => setLatitude(e.target.value)}
                />
              </div>

              <div className="input-block">
                <label htmlFor="longitude">Longitude</label>
                <input 
                  type="number"
                  name="longitude" 
                  id="longitude" 
                  required value={longitude}
                  onChange={ e => setLongitude(e.target.value)}
                />
              </div>
            </div>
            
            <button type="submit">Salvar</button>
            </form>
    );
}

export default DevForm;