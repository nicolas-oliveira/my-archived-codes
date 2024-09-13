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
                <form method="get" action="ex13.php">
                    Numero: <input type="text" name="num" id="numero">
                    <fieldset>
                        <legend>Operacao</legend>
                        <input type="radio" name="oper" id="dobro" value="1" checked>
                        <label for="dobro">Dobro</label>
                        <input type="radio" name="oper" value="2" id="cubo">
                        <label for="cubo">Cubo</label>
                        <input type="radio" name="oper" value="3" id="raiz">
                        <label for="raiz">Raiz Quadrada</label><br>
                    </fieldset>
                    <input type="submit">
                    <?php
                    $num = isset($_GET["num"])?$_GET["num"]:0;
                    $oper = isset($_GET["oper"])?$_GET["oper"]:1;
                    switch ($oper) {
                        case 1:
                            $response = $num * 2;
                            break;
                        case 2:
                            $response = $num ** 3;
                            break;
                        case 3:
                            $response = $num ** (0.5);
                            break;
                    }
                    echo "<br>O resultado é <strong>$response</strong>";
                    ?>
                </form>
            <div>
        </div>
    </div>
</body>
</html>