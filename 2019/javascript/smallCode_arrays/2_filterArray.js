const notas = [7.1, 8.3, 6.3, 7.7, 9.1, 4.3];

function aprovado(nota) {
    return nota >= 7;
}

const newNotas = notas.filter(aprovado);
console.table(newNotas);