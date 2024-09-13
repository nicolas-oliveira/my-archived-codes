require("dotenv").config();

module.exports = {
	development: {
		username: process.env.DB_USER,
		password: process.env.DB_PASS,
		database: "dev_masterclass_jest",
		host: process.env.DB_HOST,
		dialect: "postgres",
		operatorsAliases: 0,
		logging: false,
		define: {
			timestamps: true,
			undescored: true,
			underscoredAll: true,
		},
	},
	test: {
		username: process.env.DB_USER,
		password: process.env.DB_PASS,
		database: "test_masterclass_jest",
		host: process.env.DB_HOST,
		dialect: "sqlite",
		storage: "./__tests__/database.sqlite",
		operatorsAliases: 0,
		logging: false,
		define: {
			timestamps: true,
			undescored: true,
			underscoredAll: true,
		},
	},
	production: {
		username: process.env.DB_USER,
		password: process.env.DB_PASS,
		database: "prod_masterclass_jest",
		host: process.env.DB_HOST,
		dialect: "postgres",
		operatorsAliases: 0,
		logging: false,
		define: {
			timestamps: true,
			undescored: true,
			underscoredAll: true,
		},
	},
};
