module.exports = {
  presets: [
    "@babel/preset-env", // adapta o ES6 pata o navegador
    "@babel/preset-react"
  ],
  plugins: [
    '@babel/plugin-proposal-class-properties',
  ]
};