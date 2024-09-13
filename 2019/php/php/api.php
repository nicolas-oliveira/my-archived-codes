<?php

//conexão com banco de dados
$pdo = new PDO("pgsql:dbname='postgres'; ".
				"user='postgres'; ".
				"password='postgres'; ".
				"host=localhost; ".
                "port=5432");
               
$action = $_REQUEST['action']; //ação requisitada pelo usuário
$json = []; //variável de resposta (formato json -> objeto)

switch ($action) {
    //retorna informações de usuario caso encontre no banco usuario e senha correto
    case 'login':
        $user = $_REQUEST['user'];
        $password = $_REQUEST['password'];

        $sql = "SELECT id, name FROM teste.usuario WHERE user = '{$user}' AND password = '{$password}'";
        $query = $pdo->query($sql)->fetch(PDO::FETCH_ASSOC);
    break;

    //listar todos os clientes 
    case 'L':
        $sql = "SELECT id, name, phone FROM teste.clients";
        $json = $pdo->query($sql)->fetchAll(PDO::FETCH_ASSOC);
        break;
    
    //inserir novo cliente
    case 'I':
        $name = $_REQUEST['name'];
        $phone = $_REQUEST['phone'];

        $sql = "INSERT INTO teste.clients (name, phone) VALUES ('{$name}', '{$phone}')";
        $pdo->query($sql);
    break;

    //recuperar informações de um cliente específico com seu id
    case 'E':
        $id = $_REQUEST['id'];

        $sql = "SELECT id, name, phone FROM teste.clients WHERE id = '{$id}'";
        $json = $pdo->query($sql)->fetch(PDO::FETCH_ASSOC);
    break;

    //alterar informações de um cliente
    case 'A':
        $name = $_REQUEST['name'];
        $phone = $_REQUEST['phone'];
        $id = $_REQUEST['id'];

        $sql = "UPDATE teste.clients set name = '{$name}', phone = '{$phone}' WHERE id = '{$id}'";
        $pdo->query($sql);
    break;

    //excluir cliente
    case 'X':
        $id = $_REQUEST['id'];

        $sql = "DELETE FROM teste.clients WHERE id = '{$id}'";
        $pdo->query($sql);
    break;

    default:
        # code...
        break;
}

echo(json_encode($json));

/* **************************** */
