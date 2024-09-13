// Calcular o desconto
const produto = [
    { nome: 'Calçados', preco: 78.99, desconto: 0.10 },
    { nome: 'Moletom', preco: 199.99, desconto: 0.20 },
    { nome: 'Sandalias', preco: 29.99, desconto: 0.05 },
    { nome: 'Chinelo Havaianas', preco: 49.99, desconto: 0.5 },
    { nome: 'Protetor Solar', preco: 99.99, desconto: 0.6 },
];
// (produto) => produto.preco * (1 - produto.desconto);
function aplicarDesconto(produto){
    return produto.preco * (1 - produto.desconto);
}
const resultado = produto.map(aplicarDesconto);
console.table(resultado);
