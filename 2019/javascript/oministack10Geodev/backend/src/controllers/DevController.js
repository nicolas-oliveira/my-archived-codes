// O controller tem 5 funções
// index, show, store, update, delete
// index => mostrar uma lista
// show => mostrar um apenas
// store => criar
// update => alterar
// delete => deletar

const axios = require('axios');
const Dev = require('../models/dev');
const parseStringAsArray = require('../utils/parseStringAsArray');

const { findConnections, sendMessage } = require('../websocket');

module.exports = {

    async index(request, response){
        const devs = await Dev.find();

        return response.json(devs);
    },
    
    async store(request, response) { // Primeira rota da aplicação
        // return response.send('Hello World'); irá printar a mensagem no localhost e no postman/insomnia
        const { github_username, techs, latitude, longitude } = request.body; // Corpo da requisição no qual espera os dados do usuário
        
        /* ###### Evitar que repita o usuário no banco ####### */
        let dev = await Dev.findOne({ github_username }); //Let para permitir que repita
        if(!dev){ 
            const ApiResponse = await axios.get(`https://api.github.com/users/${github_username}`);
    
            const { name = login, avatar_url, bio } = ApiResponse.data;
        
            console.log( name, avatar_url, bio, github_username);
            
            // Divide a string a cada vírgula => split
            // Percorre o array => map 
            // Remove espaçamentos antes e depois de uma string => trim
            
            const techsArray = parseStringAsArray(techs); // Função criada em src/utils
        
            const location = {
                type: 'Point',
                coordinates: [longitude, latitude],
            }
        
            dev = await Dev.create({
                github_username,
                name,
                avatar_url,
                bio,
                techs: techsArray,
                location,
            });

            // Filtrar as conexões que estão em 10 km de distâncias
            // Corresponder com as tecnologias buscadas
            const sendScoketMessageTo = findConnections(
                { latitude, longitude },
                techsArray,
            )
            sendMessage(sendScoketMessageTo, 'new-dev', dev);
        }
        return response.json(dev);
        // return response.json({ message: 'Beleza mano! Deu certo vilão! AHHHHHHH to com depressao'}); // resposta da request
    }
}

