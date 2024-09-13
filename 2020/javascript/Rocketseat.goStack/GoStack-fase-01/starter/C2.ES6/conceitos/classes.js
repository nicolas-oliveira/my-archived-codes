// Manipulação de classes feita em ES6
class TodoList {
    /* Constructor é o metodo que deve ser instanciado a cada nova classe */
    /* Pode iniciar variáveis e ações que disparam assim que um objeto é criado */
    constructor() {
        this.todos = []; 
    }

    addTodo() {
        this.todos.push('Novo Todo');
        console.log(this.todos);
    }
}

const MinhaLista = new TodoList();

document.getElementById('novoTodo').onclick = function(){
    MinhaLista.addTodo();
}

/* Segunda forma: */
class List {
    constructor() {
        this.data = [];
    }
    add(data) {
        this.data.push(data);
        console.log(this.data);
    }
}
class TodoList extends List { /* A classe extende a classe List*/
    constructor() {
        super(); /* Uma classe que herda outra classe exige uma propriedade que chama o método pai */
        this.usuario = 'Nicolas';
    }
    mostraUsuario(){
        console.log(this.usuario);
    }
}

var MinhaLista = new TodoList();

document.getElementById('novoTodo').onclick = function(){
    MinhaLista.add('Novo ToDo');
}

// Métodos estáticos: (não precisa chamar o new)
class Matematica {
    static soma(a, b) {
        return a + b;
    }
}
document.getElementById('novoTodo').onclick = function(){
    Matematica.soma(1,2);
}