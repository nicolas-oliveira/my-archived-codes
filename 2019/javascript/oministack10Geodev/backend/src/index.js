// Principais métodos get, post, put, delete
// get - buscar informações
// post - criar informações
// put - editar um recurso da aplicação
// delete - delete

// Tipos de parãmetros:
// Query: params: request.query (FIlstros, ordenação, paginação, ...) console.log(request.query);
// route: params: request.params (Identificar um recurso na alteração ou remoção)
// body:  request.body (dados para a criação ou a alteração de um registro)

const express = require('express'); //Cria rotas
const mongoose =  require('mongoose'); // Importa a lib de conexão do banco de dados / MongoDB - (Banco Não-relacional)
const cors =  require('cors'); // Importa a lib de conexão do banco de dados / MongoDB - (Banco Não-relacional)
const http = require('http'); // Cria um servidor Http

const routes = require('./routes');
const {setupWebsocket} = require('./websocket');

const app = express();
const server = http.Server(app); // Coloca o servidor do express para fora 

setupWebsocket(server);


mongoose.connect('mongodb+srv://nicolas:nicolas@cluster0-i0c0u.mongodb.net/week10?retryWrites=true&w=majority', { /* Link enviado pelo mongoDB Altlas */
    useNewUrlParser: true, // Silenciar erros
    useUnifiedTopology: true
});
app.use(cors());
app.use(express.json()); // Validar para todas as rotas da aplicação
app.use(routes); // Executar as rotas requiridas em ./routes.js

app.listen(3333);