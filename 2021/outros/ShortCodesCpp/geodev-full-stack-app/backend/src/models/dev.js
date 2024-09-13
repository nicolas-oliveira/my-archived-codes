const mongoose = require('mongoose');
const PointSchema = require('./utils/PointSchema');

const DevSchema = new mongoose.Schema({
    name: String,
    github_username: String,
    bio: String,
    avatar_url: String,
    techs: [String], //Array que indica que o campo armazena várias strings
    location: {
        type: PointSchema,
        createIndexes: '2dsphere'
    }
});
module.exports = mongoose.model('Dev', DevSchema); // Exportar a ação 