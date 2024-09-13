// const e let
const a = 1;
/* Constantes não podem ter seu vaor reatribuído 
    Reatribuir a variavel constante */

const usuario = { nome: 'Diego' };

usuario.nome = 'Cleiton';

/* Variveis fora do escopo */
function teste(x) {
    let y = 2;
    if ( x > 5) {
        let y = 4; /* Valor reatribuido com let */
        console.log(x,y);
    }
}
console.log(y);/* Não funciona */
teste(10);