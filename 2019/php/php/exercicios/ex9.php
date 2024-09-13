<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css">
    <title>Metodo get e post em php</title>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <h2>Aprendendo PHP</h2><br>
                <form method="GET" action="ex9.php">
                    Valor: <input type="number" name="v"/>
                    <input type="submit" value="Calcular raiz"/>
                </form>
                <?php
                    $valor = $_GET["v"];
                    $rq = sqrt($valor);
                    echo "<br>A raiz de $valor é $rq";
                ?>                
            <div>
        </div>
    </div>
</body>
</html>