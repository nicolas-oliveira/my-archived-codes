<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="/php/style.css">
    <title>Manipulando CSS com PHP</title>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <h2>Aprendendo PHP</h2><br>
                <form method="GET" action="ex16.php">
                    Texto: <input type="text" name="b">
                    <input type="submit" value="Calcular">
                </form>
                <?php
                    $texto = $_GET['b'];
                    echo strlen($texto); //Tamanho do texto
                    echo strrev($texto); //String ao contrario
                ?>
            <div>
        </div>
    </div>
</body>
</html>