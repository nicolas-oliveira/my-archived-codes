function calcular(){
            
    var lt = parseFloat(document.getElementById('litros').value)
    var min = parseFloat(document.getElementById('minutos').value)
    
    if(lt > 0 && min > 0){
        result = document.getElementById('resultado')
        var resultado = lt / min

        result.innerHTML = `Será necessário ${resultado} minutos`
    }
}
