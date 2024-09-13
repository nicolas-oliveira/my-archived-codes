
const React = require('react');
const { FC, useState, useEffect} = require('react');
const { Box } = require('ink');

const Fullscreen = ({children}) => {  
  const enterAltScreenCommand = "\x1b[?1049h";
  const leaveAltScreenCommand = "\x1b[?1049l";
	const [size, setSize] = useState({
		columns: process.stdout.columns,
		rows: process.stdout.rows
	});

	useEffect(() => {    
		return () => {
      process.stdout.write(enterAltScreenCommand);
      process.on("exit", () => {
        process.stdout.write(leaveAltScreenCommand);
      });
		};
	}, []);

	return (
		<Box width={size.columns} height={size.rows}>
			{ children }
		</Box>
	);
};

module.exports = Fullscreen;