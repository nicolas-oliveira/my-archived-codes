const express = require('express'); //importar
const cors = require('cors');
const { errors } = require('celebrate');
const routes = require('./routes');

const app = express();

app.use(cors());
app.use(express.json());
// é necessário que as rotas estejam abaixo da execução do express
app.use(routes);
app.use(errors());

module.exports = app;

