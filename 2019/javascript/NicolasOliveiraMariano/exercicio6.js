function primo(){
    var numero_input = document.getElementById('numero').value
    Number(numero_input)
    var i
    Number(i)
    var booleano
    
    for(i = 2; i <= numero_input / 2; i++){
        if(numero_input % i == 0){
            booleano = true
            i++
        }
    }
    
    if(booleano == true){
        resultado.innerText = "Não é um numero primo"
    }else{
        resultado.innerText = "É um numero primo"
    }
                
}