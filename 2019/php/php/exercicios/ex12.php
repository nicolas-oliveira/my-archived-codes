
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="/php/style.css">
    <title>Condicionais com PHP</title>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <form method="get" action="ex12.php">
                    Ano de nascimento:
                    <input type="text" placeholder="4 digitos" name="ano">
                    <input type="submit" value="Verificar"/>
                </form>
                <?php
                    $ano = isset($_GET["ano"])?$_GET["ano"]:1900;
                    $idade (date("Y") - $ano);
                    echo "$idade<br>";
                    if($idade >= 18){
                        echo "Menor de idade";
                    }else{
                        echo "Maior de idade";
                    }
                ?>
            <div>
        </div>
    </div>
</body>
</html>