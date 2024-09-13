# Commands and how to for this repo

## Index
- [Commands and how to for this repo](#commands-and-how-to-for-this-repo)
  - [Index](#index)
- [Comands used in this repository](#comands-used-in-this-repository)
  - [Install Dependencies](#install-dependencies)
    - [Babel and webpack modules for transpile react `JSX` and `import` `export` like $ syntax](#babel-and-webpack-modules-for-transpile-react-jsx-and-import-export-like--syntax)
    - [Install react and react dom](#install-react-and-react-dom)
    - [Loader](#loader)
  - [Configuration files:](#configuration-files)
    - [Babel](#babel)
    - [Webpack](#webpack)
    - [Create `html` in `bundle.js` folder](#create-html-in-bundlejs-folder)
    - [Automatic save-build script](#automatic-save-build-script)
  - [add syle loader for css](#add-syle-loader-for-css)
  - [add loader for images](#add-loader-for-images)
  - [add plugin for no use constructor in class](#add-plugin-for-no-use-constructor-in-class)
  - [Lib for debug wrong inputs](#lib-for-debug-wrong-inputs)

# Comands used in this repository

## Install Dependencies

### Babel and webpack modules for transpile react `JSX` and `import` `export` like $ syntax
```
$ yarn add @babel/core @babel/preset-env @babel/preset-react webpack webpack-cli -D
```

### Install react and react dom
```
$ yarn add react react-dom
```

### Loader
```
$ yarn add babel-loader -D
```

## Configuration files:

### Babel

### Webpack
For webpack configuration we need to indicate dir locales for transpilation input
and transpilation output:
```js
const path = require('path');

module.exports = {
  entry: './src/index.js',
  output: {
    path: path.resolve(__dirname, 'dist'),
    filename: 'bundle.js'
  }
};
```
To configure loaders in webpack just add this:
```js
// ...
  module: {
    rules: [
      {
        test: /\.js$/,
        exclude: /node_modules/,
        use: {
          loader: 'babel-loader',
        }
      }
    ]
  }
// ...
```
Each rule need some object scope `rule: [{a},{b}...]`. At exemple above we
transpile all `js` modules in repo.
```json
"scripts": {
  "build": "webpack --mode production", // minified output
  "start": "webpack --mode development",
}
```

### Create `html` in `bundle.js` folder
In this repo I didn't use `npx create-react-app` in this case I will create html
for transpiled script:
```html
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Tech Lists</title>
</head>
<body>
  <script src="./bundle.js"></script>
</body>
</html>
```

### Automatic save-build script
For automate bundle use this:
```
$ yarn add webpack-dev-server -D
```
Add in webpack.config file:
```js
// ...
devServer: {
  contentBase: resolve(__dirname, 'dist')
},
```
```json
"scripts": {
  "build": "webpack --mode production",
  "start": "webpack-dev-server --mode development"
}
```

## add syle loader for css
```
$ yarn add style-loader css-loader -D
```

## add loader for images
```
$ yarn add file-loader -D
```

## add plugin for no use constructor in class
```
$ yarn add @babel/plugin-proposal-class-properties -D
```

## Lib for debug wrong inputs
```
$ yarn add prop-types
```
