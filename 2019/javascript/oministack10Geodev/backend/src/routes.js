const { Router } = require('express');

const DevController = require('./controllers/DevController');

const SearchController = require('./controllers/SearchController');

const routes = Router();

routes.get('/devs', DevController.index);   // Listar

routes.post('/devs', DevController.store); // Executa a ação store do arquivo devcontroller

routes.get('/search', SearchController.index);

module.exports = routes;