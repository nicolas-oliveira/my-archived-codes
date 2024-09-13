const axios = require('axios');
const Dev = require('../models/dev');
const parseStringAsArray = require('../utils/parseStringAsArray');

module.exports = {
    async index(request, response){
        // buscar em raio de 10km 
        // filtrar por tecnologias
        const { latitude, longitude, techs } =  request.query;

        const techsArray = parseStringAsArray(techs);
        
        const devs = await Dev.find({ // Criação de filtros
            techs: { 
                $in: techsArray,
            },
            location: {
                $near: {
                    $geometry: {
                        type: 'Point',
                        coordinates: [longitude, latitude],
                    },
                    $maxDistance: 100000,
                },
            }, 
        });
        console.log(techsArray);
        return response.json({ devs });
    }
}