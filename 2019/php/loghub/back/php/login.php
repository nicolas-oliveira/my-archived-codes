<?php
    include "./db_connection.php";

    $conn = getConnection();
  
    $user = $_POST["username"];
    $pass = $_POST["password"];

    $sql = "SELECT user_account, password_account FROM login WHERE user_account = '{$user}' AND password_account = '{$pass}'";

    $consulta = $conn->query($sql)->fetch(pdo::FETCH_ASSOC);

    if(empty($user) && empty($pass)){
        $resp = 0; //"Preencha os dados de login e senha";
    
    }elseif(empty($pass)){
        $resp =  1; //"Informe a senha";
    
    }elseif(empty($user)){
        $resp =  2; //"Informe o usuário";
    
    }else{
        if($consulta==''){
            $resp = 3;
        }elseif(count($consulta)==2){
            //header('Location: ../../front/html/teste.html');
            $resp = 4;
        }
    }
    
    
    echo($resp);
    

    
?>