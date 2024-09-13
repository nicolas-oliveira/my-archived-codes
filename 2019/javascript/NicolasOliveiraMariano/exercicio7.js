function fatorial(){
    var numero = parseInt(document.getElementById('numero').value);
    var resposta = document.getElementById('resultado');
    var result=1;

    for(var count=1 ; count<=numero ; count++)
    result *= count;

    resposta.innerHTML =result;
    }

    
