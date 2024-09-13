let lista = ['Papel', 'Folha', 'Caneta', 'Lapis'];
let i = 1;
function count(){
    lista = ['Papel', 'Folha', 'Caneta', 'Lapis'];
    console.log(`${i})\n=> [${lista}]`);
    i++;
}

count();

lista.forEach((e,index,array) => {
    console.log(`${e}:${index}\n`);
});

count();

// Remove o ultimo do array
{
    let what = lista.pop();
    console.log(`\n${lista} -> ${what}`);
}

count();

// Remove o primeiro do array
{
    let what = lista.shift();
    console.log(`\n${lista} -> ${what}`);
}

count();

// Adiciona na frente do array e retorna o numero após acrescentar
{
    let what = lista.unshift('Pêssego', 'Macarrão');
    console.log(`\n${lista} -> ${what}`);
}

// Encontrar um índice do array
{
    var pos = lista.indexOf('Caneta');
}

count();

// Remove um item com uma posição específica
{
    let what =  lista.splice(0, 1);
    console.log(`\n${lista} | splice(0, 1)-> ${what}`);
}

count();

{
    let what =  lista.splice(0, 2);
    console.log(`\n${lista} | splice(0, 2)-> ${what}`);
}
// Encontra a string no array e a retira:
count();

lista = ['Papel', 'Folha', 'Caneta', 'Lapis'];
{
    let posic = lista.indexOf('Caneta');
    let what = lista.splice(posic, 1);
    console.log(`\n${lista} | indexOf('Caneta')->${what}`);
}
