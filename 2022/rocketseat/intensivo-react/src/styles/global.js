import { createGlobalStyle } from 'styled-components';

export default createGlobalStyle`
	* {
		margin: 0;
		bottom: 0;
		outline: 0;
		box-sizing: border-box;
	}

	html, body, #root {
		min-height: 100% auto;
	}

	body {
		background: #0659ac;
		-webkit-font-smoothing: antialiased !important;
	}

	body, input, button {
		color: #222;
		font-size: 14px;
		font-family: Arial, Helvetica, sans-serif;
	}

	button {
		cursor: pointer;
	}
`;
