// ES6 - Modulo 1 - Exercicio 2
// A partir do seguinte vetor e utilizando os métodos de 
// array (map, reduce, filter e find):  
const usuarios = [
    { nome: 'Diego', idade: 23, empresa: 'Rocketseat' },
    { nome: 'Gabriel', idade: 15, empresa: 'Rocketseat' },
    { nome: 'Lucas', idade: 30, empresa: 'Facebook' },
]; 
// 1) Utilizando o map
// Crie uma variável que contenha todas idades dos 
// usuários: [23, 15, 30]

const arrIdade = usuarios.map(function(item) {
    return item.idade;
});
console.log(arrIdade);

// 2) Utilizando o filter
// Crie uma variáveis que tenha apenas os usuários que 
// trabalham na Rocketseat e com mais de 18 anos: 
// [{ nome: 'Diego', idade: 23, empresa: 'Rocketseat' }]

const arrFiltro = usuarios.filter(function(item){
    return item.idade > 18 && item.empresa === 'Rocketseat' ? item : !item; 
});
console.log(arrFiltro);
// Outra forma:
// const rocketseat18 = usuarios.filter(
//     usuario => usuario.empresa === "Rocketseat" && usuario.idade >= 18
// );

// 3) Utilizando o find
// Crie uma variável que procura por um usuário que 
// trabalhe na empresa Google: undefined
const arrFind = usuarios.find(function(item){
return item.empresa === 'Google';
});
console.log(arrFind);
// 4) Unindo operações
// Multiplique a idade de todos usuários por dois e depois 
// realize um filtro nos usuários que possuem no máximo 50 anos:
const reduceIdade = usuarios.map(function(item){ 
item.idade *= 2
return item;
});
console.log(reduceIdade);
const arrIdadeFilter = reduceIdade.filter(function(item){
return item.idade > 50 ? !item : item;
});
console.log(arrIdadeFilter);
// Resultado:
/* 
[
    { nome: 'Diego', idade: 46, empresa: 'Rocketseat' },
    { nome: 'Gabriel', idade: 30, empresa: 'Rocketseat' },
] 
*/
