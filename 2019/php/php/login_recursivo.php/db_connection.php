<?php
    $host = "127.0.0.1";
    $dbname = "myBank";
    $dbuser = "postgres";
    $userpass = "postgres";
    
    $dsn = "pgsql:host=$host;".
           "port=5432;".
           "dbname=$dbname;".
           "user=$dbuser;".
           "password=$userpass";

    $connect = mysqli_connect($dsn);

if(mysqli_connect_error()):
    echo "Falha na conexão: ".mysqli_connect_error();
endif;