<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css">
    <title>Incrementos e decrementos em php</title>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <h2>Aprendendo PHP</h2><br>
                <?php
                    $atual = $_GET["aa"]; /* Essa linha pega o ano na url http://127.0.0.1/php/ex4.php?aa=2019 */
                    echo "O ano atual é $atual e o ano anterior é ". --$atual;
                    $atual++; //Voltando para o numero anterior
                    echo "<br>O ano atual é $atual e o ano que vem é ". ++$atual;

                ?>
            <div>
        </div>
    </div>
</body>
</html>