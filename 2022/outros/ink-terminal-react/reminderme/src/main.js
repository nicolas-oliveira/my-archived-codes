const React = require('react');
const importJsx = require('import-jsx');
const { render } = require('ink');

const App = importJsx('./app/App');

const MainProgram = () => {
  return (
      <App />
  );
}

render(<MainProgram />);