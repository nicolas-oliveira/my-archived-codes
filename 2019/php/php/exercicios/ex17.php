<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="/php/style.css">
    <title>Strings PHP</title>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <h2>Aprendendo PHP</h2><br>
                <?php
                    $texto = "Nicolas";
                    echo $texto;
                    echo "<br>";
                    
                    echo strlen($texto); //Quantidade de caracteres
                    echo "<br>";
                    
                    echo strrev($texto); //Inverte a string
                    echo "<br>";
                    
                    $oldtxt = "Hello World!"; 
                    
                    echo $oldtxt;
                    $newtxt = str_replace("World","Maluco",$oldtxt); //Substitui a palavra correspondente da string
                    echo "<br>";
                    echo $newtxt;
                ?>
            <div>
        </div>
    </div>
</body>
</html>