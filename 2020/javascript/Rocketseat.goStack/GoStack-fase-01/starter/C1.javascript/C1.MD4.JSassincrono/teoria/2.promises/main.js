var minhaPromise = function() {
    return new Promise(function(resolve, reject) { /* Função que retorna o sucesso (resolve) ou erro (reject) */
        var xhr = new XMLHttpRequest();
        xhr.open('GET', 'https://api.github.com/users/nicolas-oliveira');
        xhr.send(null);

        xhr.onreadystatechange = function(){
            if(xhr.readyState === 4) { /* Verifica se a resposta voltou */
                if (xhr.status === 200) {
                    resolve(JSON.parse(xhr.responseText)); /* O retorno como JSON é convertido  */

                } else {
                    reject('Erro na requisição');
                }
            }
        }
    });
}


minhaPromise()
    .then(function(response){
        console.log(response);
    })
    .catch(function(error) {
        console.log(error);
    });
