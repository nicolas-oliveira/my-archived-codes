const React = require('react');
const { useEffect } = require('react');
const importJsx = require('import-jsx');
const { render, useApp, useInput } = require('ink');

const Fullscreen = importJsx('./app/utils/Fullscreen');
const App = importJsx('./app/App');

const MainProgram = () => {
  const { exit } = useApp();

  useInput((input, key) => {
    if (input === "q" || input === "Q" || key.escape) {
      exit();
    }
  });

  return (
    <Fullscreen>
      <App />
    </Fullscreen>
  );
}

render(<MainProgram />);