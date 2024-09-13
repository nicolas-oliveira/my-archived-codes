# Como criar um ambiente de desenvolvimento com ES6 + Webpack
## 1) Instale Node.js e yarn ou npm
Procure nos sites oficiais e instale no seu computador. Para verificar se já estão instalados em seu sistema abra o terminal e rode:<br><br>
``node -v ``<br>
``npm -v ``<br>
``yarn -v ``<br><br>
### Lembre-se de criar uma estrutura para sua aplicação:
<b>exemplo:</b><br>
<pre>
project
└── src
    └── example.js
</pre><br>

## 2) Inicialize a aplicação:
``yarn init -y``<br>
``npm init -y``<br><br>
O comando irá criar um package.json com as informações necessárias para executar novas dependências:<br>
<pre>
project
├── src
│   └── example.js
└── package.json
</pre>
O package.json será o responsável por listar e verificar o versionamento, assim como, os pacotes dependentes da aplicação.<br>
## 3) Instale as dependências do babel:
Uma das mudanças da versão 6 para a versão 7 é o uso de pacotes com escopo. Pacotes com escopo são instalados através de ``@escopoDomodulo/módulo``, podendo escolher dependências mais enxutas para a aplicação.<br><br>
Para testes iremos instalar as seguintes dependências:<br><br>
``yarn add @babel/cli @babel/core -D``<br>
``npm install @babel/cli @babel/core -D``<br>
``yarn add @babel/preset-env -D``<br>
Vale ressaltar que o parâmetro '-D' é necessário para esta aplicação, pois será ele que irá fazer com que os pacotes instalados sejam dependências de desenvolvimento e não de produção.<br><br>
Desta forma:<br>
```json
"devDependencies": {
    "@babel/cli": "^7.8.4",
    "@babel/core": "^7.9.0"
}
```
Basicamente a diferença entre as dependências de desenvolvimento e de produção são que a de produção serão criadas junto à aplicação e as de desenvolvimento (com o parâmetro '-D') serão compiladas apenas no momento de desenvolvimento junto ao webpack, usando online apenas o ./bundle.js.<br> 


## 4) Crie o arquivo index.html:
<pre>
project
├── src
│   └── example.js
├── package.json
└── index.html
</pre>
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
    <script src="./bundle.js"></script> <!-- Especifique aqui o local de saida do bundle-->
</body>
</html>
```

## 5) Configure o babel:
Crie um arquivo na raiz do projeto chamado .babelrc:<br>
<pre>
project
├── src
│   └── example.js
├──  package.json
├──  index.html
└── .babelrc
</pre>
Edite seu conteúdo acrescentando a seguinte configuração:<br>
```json
{
    "presets": ["@babel/preset-env"] // Configura o ambiente do babel automatizando 
                                    // para o melhor ambiente de transpilação
}
```

## 6) Configurar package.json:
O código do arquivo package.json até então estará assim:<br>
```json
{
  "name": "webpack_test",
  "version": "1.0.0",
  "description": "",
  "main": "index.js",
  "scripts": {
    "test": "echo \"Error: no test specified\" && exit 1" 
  },
  "keywords": [],
  "author": "",
  "license": "ISC",
  "devDependencies": {
    "@babel/cli": "^7.8.4",
    "@babel/core": "^7.9.0",
    "@babel/preset-env": "^7.9.0"
  }
}
```
Acrescente no objeto "scripts" o script necessário para rodar o babel:<br>
```diff
  "scripts": {
-    "test": "echo \"Error: no test specified\" && exit 1"
+   "dev": "babel ./src/exemple.js -o ./bundle.js"
  },
```
Iremos executar o resultado da compilção na raiz mesmo, com a finalidade de apenas testar o recurso.<br>
Outra funcionalidade interessante é acrescentar o parâmetro "-w" ao final do script. Esta funcionalidade irá tornar automática as alterações a cada save do código.<br><br>
Ficando o script desta forma:<br>
```json
   "dev": "babel ./src/exemple.js -o ./bundle.js -w"
```
## 7) Execute um código ES6:
```javascript
class Teste {
    metodo() {

    }
}
```
Para executar todo o código criado devemos chamar no terminal correspondente a pasta do projeto o script criado 'dev':<br><br>
``$ npm run dev``<br><br>
``$ yarn dev``<br><br>
A saída será desta forma no arquivo ./bundle.js:<br>
```javascript
"use strict";

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

alert('opa');

var Teste = /*#__PURE__*/function () {
  function Teste() {
    _classCallCheck(this, Teste);
  }

  _createClass(Teste, [{
    key: "metodo",
    value: function metodo() {}
  }]);

  return Teste;
}();
```

## 8) Instalação do Webpack:
O webpack será o responsável por trabalhar com vários arquivos .js no seu projeto, transpilando em um arquivo, ou alguns arquivos de saída como o './bundle.js'.<br>
Para adicionar como dependência basta rodar o seguinte comando no terminal do projeto:<br><br>
``yarn add webpack webpack-cli -D``<br><br>
``npm install webpack webpack-cli -D``<br><br>

## 9) Criação do arquivo  de configuração do webpack:
Nesse momento crie um arquivo com o nome 'webpack.config.js':<br>
<pre>
project
├── src
│   └── example.js
├──  package.json
├──  index.html
├── .babelrc
└── webpack.config.js
</pre>
Basicamente a sintaxe de configuração do webpack consiste em um arquivo de entrada e saída com parâmetros (regras) que irão filtrar ou executar tarefas específicas do projeto:<br>
#### a) Inicialização
```javascript
const path = require('path'); // Define a constante
```
#### b) Criação do objeto principal 'module.exports'
```javascript
const path = require('path'); 
module.exports = {}; // Exporta a configuração
```
#### c) Definir a entrada
```javascript
const path = require('path'); 
module.exports = {
    entry: './src/exemple.js', // Cria o arquivo de entrada (JSX ou ES6)
};
```
#### d) Definir a chave de saida
```javascript
const path = require('path'); 
module.exports = {
    entry: './src/exemple.js',
    output: {}, // Configura a saída
};
```
#### d.1) Nome da chave de saída
```javascript
const path = require('path'); 
module.exports = {
    entry: './src/exemple.js',
    output: {
        filename: 'bundle.js', // Especifica o nome do arquivo
    },
};
```
#### d.2) Localização da chave de saída
```javascript
const path = require('path'); 
module.exports = {
    entry: './src/exemple.js',
     output: {
        filename: 'bundle.js',
        path: __dirname, // Especifica a localização da saída
    },
};
```
Caso necessite a saída em alguma pasta em específica basta chamar o objeto 'resolve':<br> 
```javascript
const path = require('path'); 
module.exports = {
    entry: './src/exemple.js',
     output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, 'dist'), // Aqui será sua saída 
    },
};
```
#### Configuração do module:
```javascript
const path = require('path'); 
module.exports = {
    entry: './src/exemple.js',
     output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, 'dist'), 
    },
    module: {}, // Criação do module
};
```
#### e) Configuração das rules:
As rules serão as regras que irão dizer como o webpack deve se comportar quando o usuário importar novos arquivos .js.<br>

```javascript
(...) // Código acima
    module: {
        rules: [ 

        ],
    }, 
(...) // Código abaixo
```
#### e.2) Configuração das rules: test
O 'test' será responsável por pegar todos os arquivos .js, dessa forma criamos uma expressão regular de identificação no qual irá 'capturar' todos os arquivos com final .js:<br>
```javascript 
(...)
    module: {
        rules: [ 
            {
                test: /\.m?js$/,
            }
        ],
    }, 
(...)
```
#### e.2) Configuração das rules: exclude:
O 'exclude' será o filtro responsável por não executar pastas que não desejamos como 'node_modules':<br>
```javascript
(...)
    module: {
        rules: [ 
            {
                test: /\.m?js$/,
                exclude: /(node_modules|bower_components)/,
            }
        ],
    }, 
(...)
```
Por fim será necessário especificar o preset para o @babel/preset-env, esta função será a mesma usada no '.babelrc':<br>
```javascript
const path = require('path'); 
module.exports = {
    entry: './src/exemple.js',
     output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, 'dist'), 
    },
    module: {
        rules: [ 
            {
                test: /\.m?js$/,
                exclude: /(node_modules|bower_components)/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env']
                    }
                }
            }
        ],
    }, 
};
```
Desta forma temos como resultado:<br>
```javascript
const path = require('path');

module.exports = {
    entry: './src/exemple.js',
    output: {
        path: __dirname,
        filename: 'bundle.js',
    },
    module: {
        rules: [
            {
                test: /\.m?js$/,
                exclude: /(node_modules|bower_components)/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env']
                    }
                }
            }
        ],
    },
};

```
## 10) Instale a dependência usada no loader do webpack:
`` npm install babel-loader -D``<br>
`` yarn add babel-loader -D``<br>

## 11) Altere o script:
```diff
  "scripts": {
-   "dev": "babel ./src/exemple.js -o ./bundle.js"
+   "dev": "npx webpack --mode=development -w"
  },
```
O parâmetro '--mode=development' será responsável por recompilar a cada save durante o desenvolviemento, já o '-w' irá verificar as alterações através do webpack.<br>

## Executar o programa:
Execute o seguinte comando no terminal:<br><br>
``$ npm run dev ``<br>
``$ yarn dev `` <br><br>
Após as configurações acima basta que abra o index.html no live server, as modificações feitas pelo arquivo de entrada serão modificadas em conjunto com o './bundle.js'.