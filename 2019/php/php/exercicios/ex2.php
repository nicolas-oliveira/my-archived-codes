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
                    $n1 = $_GET["a"];
                    $n2 = $_GET["b"]; /* Valores recebidos pela URL http://127.0.0.1/php/ex2.php?a=5&b=2*/
                    echo "<h3>Valores recebidos $n1 e $n2</h3>";
                    echo "<br><h4>As operações básicas:</h4>";
                    $soma = $n1 + $n2;
                    $sub = $n1 - $n2;
                    $mult = $n1 * $n2;
                    echo "A soma entre $n1 e $n2 é $soma";
                    echo "<br>A subtração entre $n1 e $n2 é $sub";
                    echo "<br>A multiplicação entre $n1 e $n2 é $mult";
                    echo "<br>A divisão entre $n1 e $n2 vale ". ($n1/$n2);
                    echo "<br>O módulo vale ".($n1%$n2);
                    echo "<br>A media vale ".(($n1 + $n2) / 2);
                    
                    echo "<br><br><h4>Funções aritméticas:</h4>";
                    echo "<br>".'.abs(), .pow(), .round(), .inval(), .number_format()';
                    echo "<br><br>O valor absoluto de $n2 é ".abs($n2);
                    echo "<br>O valor de $n1<sup>$n2</sup> é ".pow($n1, $n2);
                    echo "<br>A raiz de $n1 é ".sqrt($n1);
                    echo "<br>O valor de $n2 arredondado é ".round($n2);
                    echo "<br>A parte inteira de $n2 é ".intval($n2);
                    echo "<br>O valor de $n1 em moeda é ".number_format($n1,2,",",".");
                ?>
            <div>
        </div>
    </div>
</body>
</html>