// Criar atraves de reduce e apenas pelo reduce a media dos numeros
const numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

function media (acumulador, numero) {
    const newTotal = acumulador.total + numero;
    const newQtde = acumulador.qtde + 1;
    return {
        total: newTotal,
        qtde: newQtde,
        media: newTotal / newQtde 
    };
}

console.log(numeros.reduce(media, {total: 0, qtde: 0, media: 0}))