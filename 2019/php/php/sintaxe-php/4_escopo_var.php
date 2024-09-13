<?php

$nome = "Nicolas";
$a = 1;
$b = 2; //Variaveis definidas globalmente
$c = 3;


function soma() {
    $GLOBALS['a']+$GLOBALS['b']+$GLOBALS['c']; //Acessa variáveis definidas globalmente
    echo $a + $b + $c;
}


function exibeNome(){
    global $nome; //torna ela global
    echo $nome; //sozinho não funciona
}
exibeNome();


function exibeCidade(){
    // Variavel criada no Escopo Local
    global $cidade; //torna ela global
    $cidade = "São Paulo";
}

exibeCidade();
echo $cidade;