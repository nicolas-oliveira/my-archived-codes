const express = require('express');

const server = express();
server.use(express.json());
// Query params:
    // http://localhost:3000/teste?nome=Nicolas
    //'/teste'
    // const nome = request.query.nome;
    // return response.send({message: `Hello ${nome}`});
const users = ['Nicolas','Felipe','Maicon'];

server.use((request, response, next)=>{
    console.time('Request');
    console.log(`MET: ${request.method};\nURL: ${request.url}`);
    next();
    console.timeEnd('Request');
});

function checkUserExists(request, response, next){
    if(!request.body.user){
        return response.status(400).json({
            error: 'Username not found in body request'
        });
    }
    return next();
}

function checkUserInArray(request, response, next){
    const user = users[request.params.id];
    if(!user){
        return response.status(400).json({
            error: 'Username does not exists'
        });
    }
    request.user = user;
    return next();
}

server.get('/users',(request,response) => {
    return response.json(users);
});

server.get('/users/:id', checkUserInArray, (request,response) => {
    // const id = request.params.id;
    // const { id } = request.params;
    return response.json(request.user);
});

server.post('/users', checkUserExists, (request,response) => {
    const { name } = request.body;
    users.push(name);
    
    return response.json(users);
});

server.put('/users/:id', checkUserInArray, checkUserExists, 
(request, response) => {
    const { id } = request.params;
    const { name } = request.body;
    users[id] = name;
    return response.json(users);
});

server.delete('/users/:id', checkUserInArray, (request,response) => {
    const { id } = request.params;
    users.splice(id, 1);
    return response.json(users);
});
server.listen(3000);