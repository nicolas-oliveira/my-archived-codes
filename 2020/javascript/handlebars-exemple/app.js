const express = require('express');
const handlebars = require('express-handlebars');
const deliverers = require('./DATA_FOR_DELIVERERS.json');

const app = express();

app.engine('hbs', handlebars({ extname: 'hbs' }));
app.set('view engine', 'hbs')

app.get('/form', function(request, response){
  response.render('home', { deliverers: deliverers });
});
app.listen(8080);