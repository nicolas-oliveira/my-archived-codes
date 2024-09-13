// Extender um nova função do array no qual faça o mesmo do map, filter e reduce
const carrinho = [
    {nome: 'Caneta', qtde: 10, preco: 7.99},
    {nome: 'Impressora', qtde: 0, preco: 649.50},
    {nome: 'Caderno', qtde: 4, preco: 27.10},
    {nome: 'Lapis', qtde: 3, preco: 5.82},
    {nome: 'Tesoura', qtde: 1, preco: 19.20},
];

Array.prototype.meuFilter = function(fn) {
    const newArr = [];
        for(element of this)
            if(fn(element))
                newArr.push(element);
    return newArr;
}

Array.prototype.meuMap = function(fn) {
    const newArr = [];
    for(element of this)
        newArr.push(fn(element));
    
    return newArr;
}

Array.prototype.meuReduce = function(fn, inicial) {
    let ultimo = inicial;
    for(element of this) {
        if(ultimo === undefined) {
            ultimo = element;
            continue;
        }
        console.log(ultimo, element);
        ultimo = fn(ultimo, element);
    }
    return ultimo;
}

const resultado = carrinho.meuFilter(carrinho => carrinho.qtde > 0)
                          .meuMap(carrinho => carrinho.qtde * carrinho.preco)
                          .meuReduce((a, b) => a + b);

const total = carrinho.filter(carrinho => carrinho.qtde > 0)
                      .map(e => e.qtde * e.preco)
                      .reduce(((a, b) => a + b));
                      
console.table(resultado);
console.table(total);