import Sequelize from 'sequelize';

import databaseConfig from '../config/database';

import Adm from '../models/Adm';
import Recipient from '../models/Recipient';

const connection = new Sequelize(databaseConfig);

Adm.init(connection);
Recipient.init(connection);
Recipient.associate(connection.models);

export default connection;
