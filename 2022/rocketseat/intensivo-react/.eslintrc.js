module.exports = {
	env: {
		browser: true,
		es2021: true,
	},
	extends: ['plugin:react/recommended', 'airbnb', 'prettier', 'prettier/react'],
	parser: 'babel-eslint',
	parserOptions: {
		ecmaFeatures: {
			jsx: true,
		},
		ecmaVersion: 12,
		sourceType: 'module',
	},
	plugins: ['react', 'prettier'],
	rules: {
		'prettier/prettier': 'error',
		'react/jsx-filename-extension': ['warn', { extensions: ['.js', '.jsx'] }],
		'import/prefer-default-export': 'off',
		'no-unused-vars': 'off',
		'react/prefer-stateless-function': 'off',
		'react/state-in-constructor': 'off',
		'no-console': 'off',
		'jsx-a11y/anchor-is-valid': 'off',
		'react/prop-types': 'off',
		'react/static-property-placement': 'off',
	},
};
