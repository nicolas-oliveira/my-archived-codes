function calcular_parcelas(){
    //Quantidade total de prestações
    var parcelas = document.getElementById('parcelas_totais').value
    Number.parseInt(parcelas)
    
    //Quantidade de prestações pagas
    var pago = document.getElementById('pago').value
    Number.parseInt(pago)

    //Valor do preço da prestação
    var preco = document.getElementById('preco').value
    Number.parseFloat(preco)
    
    /*if((pago > parcelas) && (preco <= 0)){
        
        show_result_pago.innerText = 'O preço das parecelas recebeu um valor inválido!'
        show_result_pagar.innerText = 'A quantidade paga é superior a quantidade total!'
        show_result_total.innerText = ''

    }else if((pago > parcelas) && (preco > 0)){
        
        show_result_pago.innerText = ''
        show_result_pagar.innerText = 'A quantidade paga é superior ou igual a quantidade total!'
        show_result_total.innerText = ''
    
    }else if((pago < parcelas) && (preco <= 0)){
        
        show_result_pago.innerText = ''
        show_result_pagar.innerText = 'O preço das parecelas recebeu um valor inválido!'
        show_result_total.innerText = ''
        
    }*/

        //Total a ser pago
        resultado_total = parcelas * preco
        
        //Mostrar a quantidade que foi paga
        var resultado_pago = document.getElementById('resultado_pago')
        resultado_pago = pago * preco
        
        //Mostrar total pago e o que falta a pagar
        var resultado_pagar = document.getElementById('resultado_pagar')
        resultado_pagar = resultado_total - resultado_pago
        
        //Resultado que aparece após o texto
        show_result_pago.innerText = 'Quantidade Paga: R$ '+ resultado_pago
        show_result_pagar.innerText = 'Quantidade ainda a ser paga: R$ '+ resultado_pagar
        show_result_total.innerText = 'Quantidade total: R$ '+ resultado_total
    
    
}