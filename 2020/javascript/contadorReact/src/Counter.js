import React, {useState} from 'react'

function Counter() {
    const [counter, setCounter] = useState(0) // Parâmetros counter => variavel que representa o estado da aplicação
    // setCounter => função responsável por criar o novo estado da aplicação
    // Desestruturação é a ação que torna um objeto ou vetor em variáveis

    /* Toda função deve estar aqui */
    function increment() {
    setCounter(counter+1);
    }
    return (
        <div>
        <h1>Contador: {counter}</h1>
        <button onClick={increment}>Incrementar</button>
        </div>
    );
}

export default Counter; 