<!DOCTYPE html>
<html lang="en">
<head>
        <?php
            $txt = isset($_GET["t"])?$_GET["t"]:"Texto generico";
            $tam = isset($_GET["tam"])?$_GET["tam"]:"12pt";
            $cor = isset($_GET["cor"])?$_GET["cor"]:"#ff0000";
        ?>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="/php/style.css">
    <title>Manipulando CSS com PHP</title>
    <style>
        span.texto {
            font-size: <?php echo $tam;?>;
            color: <?php echo $cor;?>;    
        }
    </style>
</head>
<body>
    <div class="box">
        <div class="boxintern">
            <div class="whitebox">
                <h2>Aprendendo PHP</h2><br>
                <form method="get" action="ex11.php">
                    <label for="itxt">Texto:</label>
                    <input type="text" name="t" id="itxt">
                    <label for="itam"></label>
                    <select name="tam" id="itam">
                        <option value="8pt">8</option>
                        <option value="10pt">10</option>
                        <option value="12pt">12</option>
                        <option value="20pt">20</option>
                        <option value="24pt">24</option>
                        <option value="40pt">40</option>
                    </select><br>
                    <label for="icor">Cor: </label>
                    <input type="color" name="cor" id="icor"><br>
                    <input type="submit" value="Gerar">
                </form>
                <?php
                    echo "<span class='texto'>$txt</span>";
                ?>
            <div>
        </div>
    </div>
</body>
</html>