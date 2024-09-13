<?php

include './db_connection.php';

$conn = getConnection();

$sql = "INSERT INTO login (user_account, password_account, sex, email)
VALUES ('nicolas','ranor21','M','email@ex.com');";

$conn->exec($sql);
echo "Gravação feita com sucesso!";




