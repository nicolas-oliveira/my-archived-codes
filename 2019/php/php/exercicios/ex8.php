<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css">
    <title>Variaveis de variáveis em php</title>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <h2>Aprendendo PHP</h2><br>
                <?php
                    $idade = $_GET["id"];
                    if($idade < 16){
                        echo "Não vota";
                    }elseif(($idade >= 16 && $idade < 18) || $idade >= 65){
                        echo "O voto é opcional";

                    }elseif($idade >= 18 && $idade < 65){
                        echo "O voto é obrigatório";
                    }
                ?>
            <div>
        </div>
    </div>
</body>
</html>