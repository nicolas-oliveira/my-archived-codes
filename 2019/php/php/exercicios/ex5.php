<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css">
    <title>Variaveis referenciaveis em php</title>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <h2>Aprendendo PHP</h2><br>
                <?php
                   $a = 3;
                   $b = $a;
                   $b += 2;
                   echo "<br>O valor de a é $a";
                   echo "<br>O valor de b é $b";

                   $c = 3;
                   $d = &$c;
                   $d += 2;
                    echo "<br><br><strong>O valor por referência:</strong>";
                   echo "<br><br>O valor de c é $c";
                   echo "<br>O valor de d é $d";

                ?>
            <div>
        </div>
    </div>
</body>
</html>