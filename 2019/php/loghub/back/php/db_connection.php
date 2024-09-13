<?php

function getConnection(){
    
    $host = "127.0.0.1";
    $dbname = "myBank";
    $dbuser = "postgres";
    $userpass = "postgres";

    $dsn = "pgsql:host=$host;".
           "port=5432;".
           "dbname=$dbname;".
           "user=$dbuser;".
           "password=$userpass";

    try {
        
        $pdo = new PDO($dsn);
        // set the PDO error mode to exception
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        return $pdo;
        
    }catch(PDOException $e){
        echo $sql."<br>Erro: ". $e->getMessage();
    }
}
