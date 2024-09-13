
const express = require('express');
const {v4} = require('uuid');
const app = express();
app.use(express.json())
const users = [
    {
        "id": "ba5fecb7-112b-47ce-9171-753e81437c5b",
        "name": "nick",
        "screen_name": "NickCageNick1",
        "description": "Preguiçoso profissional, programador nas horas vagas, mineiro nos fins de semana e libertário",
        "created_at": "Fri May 15 2020 19:32:09 GMT-0300 (Horário Padrão de Brasília)"
    },
    {
        "id": "120fab01-1f33-42b3-8158-9624fc918e1f",
        "name": "Felipe",
        "screen_name": "Felipe21",
        "description": "Usuário profissional da neetlancer e programador",
        "created_at": "Fri May 15 2020 19:03:11 GMT-0300 (Horário Padrão de Brasília)"
    },
    {
        "id": "05a2d415-c432-4c16-89cc-e585824367bc",
        "name": "douga",
        "screen_name": "douglassola1",
        "description": "Eu não sei o que fazer da vida :/",
        "created_at": "Fri May 15 2020 19:33:21 GMT-0300 (Horário Padrão de Brasília)"
    }

];
app.get('/',(request,response)=>{
    return response.send('Fala Bruxão');
});
app.post('/user', (request,response)=>{
    const { name, screen_name, description } = request.body;
    const created_at = Date();
    const id = v4();
    users.push({id,name,screen_name,description,created_at});
    return response.json(users);
});
app.get('/users',(request,response)=>{
    return response.json(users);
});
app.listen(3333);

