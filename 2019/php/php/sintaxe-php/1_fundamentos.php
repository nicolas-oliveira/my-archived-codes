<?php

class Cliente {
    public $nome;
    public function atribuirNome($nome) {
      $this->$nome = $nome;
   }
}

$cliente = new Cliente();
$cliente->atribuirNome("Nicolas");
echo "<pre>";
var_dump($cliente);


