<?php
/* Script para a criação da table e da column correspondente */
include './db_connection.php';
// Sobre os tipos do PostreSQL http://www.macoratti.net/11/03/sql_nv1.htm
$conn = getConnection();

$sql = 'CREATE TABLE public.login(
    user_account character varying(30) COLLATE pg_catalog."default" NOT NULL,
    password_account character varying(30) COLLATE pg_catalog."default" NOT NULL,
    sex character(1) COLLATE pg_catalog."default" NOT NULL,
    email character varying(60) COLLATE pg_catalog."default" NOT NULL)';

$conn->query($sql);

echo "Tabela criada com sucesso!";