<?php
    //Conexão
    require_once 'db_connection.php';
    //Verficação para impedir o acesso por link a pagina restrita
    if(!isset($_SESSION['logado'])):
        header('Location: index.php');
    endif;
    //Sessão
    session_start();

    $id = $_SESSION['id_usuario'];
    $sql = "SELECT * FROM usuarios WHERE id = '$id'";
    $resultado = mysqli_query($connect,$sql);
    $dados = mysqli_fetch_array($resultado);

    mysqli_close($connect);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Página Restrita</title>
</head>
<body>
    <h1>Olá <?php echo $dados['nomes'];?></h1>
</body>
</html>