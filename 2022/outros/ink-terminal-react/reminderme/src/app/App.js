const React = require('react');
const importJsx = require('import-jsx');
const inktable = require("ink-table");
const Table = inktable.default;

const {commands} = require('../../data.json')
const App = () => {
  
  return (<Table data={commands}></Table>)
}

module.exports = App;