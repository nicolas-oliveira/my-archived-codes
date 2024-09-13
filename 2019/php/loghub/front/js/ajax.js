    
    //Declaração das variaveis globais que recolhem a DOM

    var loginfo = document.querySelector('.response');
    
/*     var textLog = document.createTextNode(texto);
    var textShowlog = document.appendChild(textLog); */

    // Ação do botão
    $("#btnSubmit").click(function(e) {
        e.preventDefault();
        
            $.ajax({
                type: 'POST',
                url: '../../back/php/login.php',
                data: {  
                    username: $('#username').val(),
                    password: $('#password').val()
                },
                beforeSend: function(e){
                    console.log('Pronto');
                    
                },  
            }).done(function(resp){
                console.log(resp);
                
                switch (resp) {
                    case '0':
                        response = "Preencha os dados de login e senha";
                        break;
                    case '1':
                        response = "Informe a senha";
                        break;
                    case '2':
                        response = "Informe o usuário";
                        break;
                    case '3':
                        response = "Email ou senha incorretos";
                        break;
                    case '4':
                        window.location.replace('teste.html');
                        break;
                    default:
                        console.log("Erro");
                        break;
                }
            loginfo.innerText = response;
        });
    });
    
    // var loginfo = document.querySelector('.loginfo');
    // var textLog = document.createTextNode(logphp)
    // var textShowlog = document.appendChild(textLog);

    