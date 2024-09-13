module.exports = function parseStringAsAraay(arrayAsString) {

    return arrayAsString.split(',').map(tech => tech.trim());

}