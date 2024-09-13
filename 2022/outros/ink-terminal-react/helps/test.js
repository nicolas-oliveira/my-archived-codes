const React = require("react");
const { render, Color, useApp, useInput, Box, Text } = require("ink");
const { exec } = require("child_process");

const Counter = () => {
  const { exit } = useApp();

  useInput((input, key) => {
    if (input === "q" || key.escape) {
      exit();
    }
  });

  return (
    <Box height="100%" width="100%" alignItems="center" justifyContent='center' borderStyle='single'>
      <Text>
      {
        exec("man cd", (error, stdout, stderr) => {
          if (error) {
            console.log(`error: ${error.message}`);
            return;
          }
          if (stderr) {
            console.log(`stderr: ${stderr}`);
            return;
          }
          return `${stdout.toString()}`;
        })
      }
      </Text>
    </Box>
  );
};

render(<Counter />);