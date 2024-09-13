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
                <form method="GET" action="ex15.php">
                    Número: <input type="number" name="b">
                    <input type="submit" value="Calcular">
                </form>
                <?php
                    $calc = $_GET["b"];
                    for ($i = 1; $i <= 10; $i++){
                        $num = $calc * $i;
                        echo "<br>$calc X $i = $num ";
                    }
                ?>
            <div>
        </div>
    </div>
</body>
</html>