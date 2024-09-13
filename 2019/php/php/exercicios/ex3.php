<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css">
    <title>Operadores em php</title>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <h2>Aprendendo PHP</h2><br>
                <?php
                    $preco = $_GET["p"];
                    echo "O preço do produto é R$$preco";
                    $preco += ($preco*1/10);
                    echo "<br>O novo preço com aumento de 10% é R$".number_format($preco,2,",",".");
                    
                ?>
            <div>
        </div>
    </div>
</body>
</html>