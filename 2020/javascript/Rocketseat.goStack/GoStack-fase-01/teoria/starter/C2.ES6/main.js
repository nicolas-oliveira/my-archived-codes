// 4.1 Desestruturação simples
// A partir do seguinte objeto:
const empresa = {
    nome: 'Rocketseat',
    endereco: {
        cidade: 'Rio do Sul',
        estado: 'SC',
    }
};
// Utilize a desestruturação para 
// transformar as propriedades nome, 
// cidade e estado em variáveis, no
// fim deve ser possível fazer o seguinte:

// console.log(nome); -> Rocketseat
// console.log(cidade); -> Rio do Sul
// console.log(estado); -> SC

// A mesma forma em com acesso direto
// console.log(empresa.nome); -> Rocketseat
// console.log(empresa.endereco.cidade); -> Rio do Sul
// console.log(empresa.endereco.estado); -> SC

{}