<?php
    // Conexão com o banco 
    require_once 'db_connection.php';
    // Sessão
    session_start();
    //Para o botão enviar
    if(isset($_POST['btn-entrar'])): 
        $erros = array();
        $login = mysqli_escape_string($connect, $_POST['login']); // Filtra os dados
        $senha = mysqli_escape_string($connect, $_POST['senha']);

        if(empty($login) or empty($senha)):
             //Verifica se está vazio
            $erros[] = "<li>O campo login/senha precisa ser preenchido </li>"; //Coloca o erro em um array
        
        else: 
            $sql = "SELECT login from usuarios WHERE login = '$login' ";
            $resultado = mysqli_query($connect, $sql);

            if(mysqli_num_rows($resultado)>0): //Conta o resultado de usuarios da tabela
                
                $sql = "SELECT * FROM usuarios WHERE login = '$login' AND senha = '$senha'";
                $resultado = mysqli_query($connect, $sql); //Conta o resultado da requisição acima

                if(mysqli_num_rows($resultado) == 1): //A condição verifica a unica resposta da requisição acima (Assume-se que será uma)
                    $dados = mysqli_fetch_array($resultado);
                    $_SESSION['logado'] = true;
                    $_SESSION['id_usuario'] = $dados['id'];
                else:
                    $erros[] = "<li>Usuário inexistente</li>";
                endif;

            endif;
        endif;
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <h1>Login</h1>
    
    <?php
        if(!empty($erros)):
            foreach($erros as $erro):
                echo $erro;
            endforeach;
        endif;
    ?>
    
    <form action="<?php echo $_SERVER['PHP_SELF'];?>" method="POST">
        Login:<input type="text" name="login"><br>
        Senha:<input type="password" name="senha"><br>
        <button type="submit" name="btn-entrar">Entrar</button>
    </form>

</body>
</html>