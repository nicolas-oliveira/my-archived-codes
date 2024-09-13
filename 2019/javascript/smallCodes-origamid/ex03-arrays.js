const names = [
    'Nicolas Oliveira', 
    'Joyce Sarah', 
    'Jairo Mariano', 
    'Solange Oliveira'
];
for(let i = 0; i < names.length; i++)
    console.log(names[i]);

console.log('_____________');

names.forEach((names) => {
    console.log(names);
});

// Array:
console.table(names);
console.log(names.length);

// 'Remover no array:'
console.log(names.pop()); // retorna o valor removido
console.log(names.length); 
console.table(names);

// Adicionar no array:
console.log(names.push('Felipe Fernandes'));
console.table(names);
