function tabuada(){
    var numero = document.getElementById('numero')
    var recebe = document.getElementById('tag_select')
    
    var n = Number(numero.value) 
    var c = 1
    tabuada_div.innerHTML = '' 
    while(c <= 10){
        var item = document.createElement('option')
        item.text = `${n} x ${c} = ${n*c}`
        item.value = `res${c}`
        tabuada_div.appendChild(item)
        c++
    }
}