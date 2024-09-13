/* Manipulação de arrays em ES6 */
/* Correr, manipular, encontrar valores */
const arr = [1, 3, 4, 5, 8, 9];
/* A função map percorre todos os items do vetor e executa a ação */
/* Index é a posição do vetor */
const newArr = arr.map(function(item, index){ 
    return item + index;                        
});
console.log(newArr);

/* Reduz o vetor consumindo em uma variável após fazer uma operação */
const sum = arr.reduce(function(total, next){
    return total + next;
});
console.log(sum);

/* Filtra o array a partir de uma condição feita na operação */
const filter = arr.filter(function(item){
    return item % 2 === 0; /* Apenas retorna true ou false */
});
console.log(filter);

/* Veificar se existe ou se é possivel encontrar alguma informação dentro do array */
const find = arr.find(function(item){
    return item === 2; /* Responde undefined caso não encontre */
});

console.log(find);

