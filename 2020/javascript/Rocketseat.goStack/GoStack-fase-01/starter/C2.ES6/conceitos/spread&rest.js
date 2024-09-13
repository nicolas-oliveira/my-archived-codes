// REST operator

const usuario = {
    nome: 'Nicolas',
    idade: 21,
    empresa: 'Nicolas LTDA'
};

const { nome, ...resto} = usuario; /* A variavel recebe todas as outras propriedades */

console.log(nome); 
console.log(resto);

// Array

const arr = [1, 2, 3, 4];

const [a, b, ...c] = arr;

console.log(a);
console.log(b);
console.log(c);

// Parâmetros de funções

function soma(...params) {
    return params.reduce((total, next) => total + next);
}
console.log(soma(1,3,4,5))
// function soma(a,b, ...resto) {
//     return resto; // Obtem o resto assim como anteriormente
// }

// SPREAD

const arr1 = [1, 2, 3];
const arr2 = [4, 5, 6];

const arr3 = [ ...arr1, ...arr2 ];

console.log(arr3);

// OUTRO EXEMPLO DE SPREAD
const usuario1 = {
    nome: 'Nicolas',
    idade: 21,
    empresa: 'Nicolas LTDA',
};

const usuario2 = { ...usuario1, nome: 'Novo Nome'}; 
// Apenas altera o nome

console.log(usuario2);
