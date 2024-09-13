function confirma(){
    var nome = document.getElementById('nome')
    var ano = document.getElementById('ano').value
    var ano_nasc = Number(ano)
    var data = new Date()
    var ano_atual = data.getFullYear()
    var idade = ano_atual - ano

    if(ano > ano_atual || ano <= 0){   
        
        window.alert('Aconteceu algo inesperado verifique!')
    
    }else if(idade < 14){
        
        result.innerText = `Categoria Mirim: ${idade} anos`
        
    }else if(idade == 15 || idade == 14){
        
        result.innerText = `Categoria Infantil: ${idade} anos`
    
    }else if(idade == 17 || idade == 16){
    
        result.innerText = `Categoria Juvenil: ${idade} anos`
    
    }else if(idade >= 18 && idade <= 20){
        
        result.innerText = `Categoria Juniores: ${idade} anos`
    
    }else if(idade > 20){
    
        result.innerText = `Categoria Profissional: ${idade} anos`
    
    }

}
