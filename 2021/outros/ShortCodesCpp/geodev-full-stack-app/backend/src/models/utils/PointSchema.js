const mongoose = require('mongoose');
 

const PointSchema = new mongoose.Schema({
    type: { // Funciona como uma coluna
        type: String,
        enum: ['Point'],
        required: true,
    },
    coordinates: {
        type: [Number],
        required: true,
    },
});

module.exports = PointSchema;