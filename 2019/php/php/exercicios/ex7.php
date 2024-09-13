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
                    $n1 = $_GET["n1"];
                    $n2 = $_GET["n2"];
                    $op = $_GET["op"];
                    echo "Os valores passados foram: $n1 e $n2";
                    $operacao = ($op == "s") ? $n1 + $n2 : $n1 * $n2; 
                    echo "<br>$operacao";
                    
                    echo "<br><br><strong>Igual identico</strong>";
                    $a = 1;
                    $b = "1";
                    $r = ($a === $b)?"SIM":"NÃO";
                    echo "<br>$a é identico a $b? $r";
                    
                    echo "<br><br><strong>Média</strong>";
                    $nota1 = $_GET["n1"];
                    $nota2 = $_GET["n2"];
                    $media = ($nota1+$nota2) / 2;
                    echo "<br>A media entre a $nota1 e $nota2 é $media";
                    echo "<br>A situação do aluno é ".(($media>6) ? "APROVADO" : "REPROVADO");
                ?>
            <div>
        </div>
    </div>
</body>
</html>