<?php
include './db_test.php';

$sql = 'SELECT * FROM animals';
$json = $dsn->query($sql)->fetchAll(PDO::FETCH_ASSOC);
