<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="/php/style.css">
    <title>Metodo get e post em php</title>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <h2>Aprendendo PHP</h2><br>
                <form method="GET" action="ex10.php">
                    Nome: <input type="text" name="nome"><br>
                    Ano de nascimento: <input type="number" name="ano"><br>
                    <fieldset>
                        <legend>Sexo:</legend>
                        <input type="radio" name="sexo" id="masc" value="homem"/>
                        <label for="masc">Masculino</label><br>
                        <input type="radio" name="sexo" id="fem" value="mulher"/>
                        <label for="fem">Feminino</label>
                    </fieldset>
                    <input type="submit" value="Enviar">
                </form>
                <?php
                    $nome = $_GET["nome"];
                    $ano = $_GET["ano"];
                    $sexo = $_GET["sexo"];
                    $idade = date("Y") - $ano;
                    echo "$nome é $sexo e tem $idade anos";
                ?>
            <div>
        </div>
    </div>
   
</body>
</html>