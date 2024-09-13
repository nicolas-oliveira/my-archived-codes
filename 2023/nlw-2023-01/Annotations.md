# NLW 2023 Janeiro

Para criar o projeto é necessário inicializar e os seguintes comandos foram utilizados:

Adicionar o typescript como dependência:

```
yarn add typescript -D
```

Inicializar uma configuração Typescript:

```
npx tsc --init
```

### Importância do Typescript

O TypeScript é uma linguagem de programação baseada em JavaScript que
adiciona tipagem estática ao código.

O Typescript antes do código ser executado verifica se os tipos de dados estão corretos e avisa se houver algum erro.

Para isso o Diego dá um exemplo na aula:

```ts
type Usuario = {
  idade: number;
};

function mostraIdadeDoUsuario(usuario: Usuario) {
  return usuario.idade;
}

// Propriedade a mais
const usuario = {
  nome: "Nicolas",
  idade: 24,
};

mostraIdadeDoUsuario(usuario);

// Errado
const usuario2 = {
  name: "Quem?",
};
```

No exemplo acima, a função "mostraIdadeDoUsuario" espera receber um parâmetro do tipo "Usuario", que tem uma propriedade "idade" do tipo "number". Se alguém tentar passar outro tipo de objeto para essa função, o TypeScript vai apontar esse erro e evitar que o código seja executado com dados incorretos.

Isso ajuda a prevenir bugs e aumenta a manutenibilidade do código.

Aprofundando mais sobre o Typescript ao comparar com Javascript:

**Diferença 1: Declaração de variáveis**

```ts
// TypeScript
let idade: number = 30;

// JavaScript
var idade = 30;
```

`No TypeScript, é possível especificar o tipo de dado da variável (no exemplo acima, "number") enquanto no JavaScript não é necessário.

**Diferença 2: Funções com tipos de retorno:**

```ts
// TypeScript
function soma(a: number, b: number): number {
    return a + b;
}

// JavaScript
function soma(a, b) {
    return a + b;
}
```

No TypeScript, é possível especificar o tipo de retorno da função (no exemplo acima, "number") enquanto no JavaScript não é necessário.

**Diferença 3: Classes e interfaces**

```ts
// TypeScript
class Pessoa {
    nome: string;
    idade: number;
}

interface Animal {
    nome: string;
    idade: number;
}

// JavaScript
function Pessoa() {
    this.nome = "";
    this.idade = 0;
}
```

No TypeScript, é possível utilizar classes e interfaces para definir estruturas de dados e tipos de objetos, enquanto no JavaScript não existe suporte nativo para isso.

Esses são alguns exemplos de como o TypeScript fornece recursos adicionais de tipagem para o JavaScript, o que ajuda a garantir a qualidade e manutenibilidade do código.



### Configurando o Prisma

O cliente nativo do prisma deve ser adicionado e a inicialização do banco SQLite

```
yarn add @prisma/client
```

```
npx prisma init --datasource-provider SQLite
```
