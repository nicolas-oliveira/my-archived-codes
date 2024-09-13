<?php
//CONTANTES SEMPRE SÃO GLOBAIS
define("NOME","Nicolas Oliveira");
define("IDADE",21);
define("ALTURA",1.63);
define("CASADO",false);

echo 'Meu nome é'.NOME.' e minha idade é '.IDADE;
//CONST DO TIPO ARRAY
echo '<hr>';

define("TIMES", ['vasco','flamengo','santos','cruzeiro']);

echo TIMES[0]; //vasco 
echo TIMES[1]; //flamengo 