// Desestruturação de objetos

const usuario = { /* ***** Objeto ***** */
    nome: 'Nicolas',
    idade: 21,
    endereco: {
        cidade: 'Passos',
        estado: 'MG',
    },
};
// Formato antigo:
// const nome = usuario.nome;
// const idade = usuario.idade;
// const cidade = usuario.endereco.cidade;

const {nome , idade, endereco: { cidade } } = usuario;

console.log(nome);
console.log(idade);
console.log(cidade);

// Outro exemplo:

function mostraNome({nome , idade}) {
    console.log(nome, idade);
}
mostraNome(usuario);