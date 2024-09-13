var listElement = document.querySelector('#app ul');
var inputElement = document.querySelector('#app input');
var buttonElement = document.querySelector('#app button');
// Array de elementos que define a lista de ToDos
// var todos = [
//     'Lista 1',
//     'Lista 2',
//     'Lista 3',
// ];

// Pega a string gravada no storage local e transforma em um objeto
var todos = JSON.parse(localStorage.getItem('list_todos')) || []; 

function addTodo() { /* Função que resgata a informação do input */
    var todoText = inputElement.value;
    todos.push(todoText); /* Adiciona ao final do array */

    inputElement.value = ''; /* Limpa o input após a ação */
    renderTodos();
    saveToStorage();
    console.log('Criado!');
}

function renderTodos() {
    listElement.innerHTML = ''; /* Limpa a pagina criando elementos novamente */

    for (todo of todos) { /* Percorre a lista criando os elementos */
        var todoElement = document.createElement('li'); /* Cria a tag li */
        var todoText = document.createTextNode(todo); /* Cria o texto da variável */
        
        var linkElement = document.createElement('a'); /* Cria o link de exclusão */
        linkElement.setAttribute('href','#');
        var linkText = document.createTextNode('Excluir');

        var position = todos.indexOf(todo); /* Declaração da posição do array com a função de busca indexof */
        linkElement.setAttribute('onclick', 'deleteTodo('+ position + ')');
        
        linkElement.appendChild(linkText);
        
        todoElement.appendChild(todoText); /* Posiciona o texto para a tag li */
        todoElement.appendChild(linkElement); /* Posiciona o excluir ao final do texto */
        listElement.appendChild(todoElement);/* Posiciona o elemento li para o final da tag ul */
    }
}

renderTodos();


buttonElement.onclick = addTodo; /* Ação do botão Adicionar */


function deleteTodo(position) {
    todos.splice(position,1); /* Deleta um elemento do array conforme a posição indicada */
    renderTodos();
    saveToStorage();
    saveToStorage();
}

function saveToStorage() {
    localStorage.setItem('list_todos', JSON.stringify(todos)); /* Função que transforma em JSON */
    console.log('Excluido!');
}