const dadosPessoais = {
    nome: 'Nicolas',
    sobrenome: 'Oliveira',
    idade: 22,
    nomeCompleto() {
       return `${this.nome} ${this.sobrenome}`;
    }
}
console.table(dadosPessoais);
console.log(dadosPessoais.nomeCompleto());

var carro = {
  preco: 1000,
  portas: 4,
  marca: 'Audi',
}
console.table(carro);

carro.preco = 3000;
console.table(carro);

let cachorro = {
    raca: 'labrador',
    cor: 'preto',
    idade: 10,
    latir() {
       if(ver(homem)){
         console.log('Au Au');
       }
    }
}
console.table(cachorro);
