// Valores padrão da função

function soma(a,b) {
    return a + b;
}
console.log(soma(1)); // NaN
console.log(soma());  // NaN

const somaP = (a = 3, b = 6) => a + b; // Caso não especificado pegará os valores

console.log(somaP(1)); // 7
console.log(somaP());  // 9