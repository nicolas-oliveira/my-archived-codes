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
                $site = "cursoemvideo";
                $$site = "cursophp"; // A variavel recebe o nome do conteúdo da variavel site
                
                ?>
            <div>
        </div>
    </div>
</body>
</html>