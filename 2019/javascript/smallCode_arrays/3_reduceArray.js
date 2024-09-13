const arr = [2, 4, 6, 8];
// (e,a) => (e+a)
function soma(acumulador, elemento) {
    return acumulador + elemento;
}
const number = arr.reduce(soma);
console.log(number);