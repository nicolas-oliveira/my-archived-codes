// Arrow functions

const arr = [ 1, 2, 4, 5, 6 ];

// const newArr = arr.map(function(item) {
//     return item * 2; 
// }); 
// É reduzido para:
const newArr = arr.map(item => item * 2);

console.log(newArr);

// Formato:
const str = () => {
    return 'teste';
}
console.log(str());

// Forma mais curta:
const str2 = () => 'teste2';
console.log(str2());

// Direciona arrays: 
const arrArrow = () => [1, 2, 3];
console.log(arrArrow());

// Retornar objetos:

//Forma errada:
const objErrado = () => {nome: 'Nicolas'}; // Undefined
console.log(objErrado());

// Forma certa:
const objCerto = () => ({ nome: 'Nicolas' });
console.log(objCerto());