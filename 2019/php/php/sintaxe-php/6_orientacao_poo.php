<?php
/* Exemplos de programação estruturada e orientação à objetos */

/* Estruturado */
/* $nome = 'Fulano';

$salarioBase = 1000;
$horasExtras = 10;
$valorDahora = 20;

$salarioEfetivo = $salarioBase + ($horasExtras * $valorDahora);

echo $salarioEfetivo;
echo '<hr>'; */
/* ############################## */
/* Programação orientada a objetos */
require '6_orientacao_encasp.php';

$funcionario = new Funcionario();

$funcionario->setNome('Fulano');

$funcionario->setSalarioBase(1000);

$funcionario->setHorasExtras(10);

$funcionario->setValorDaHora(20);

echo $funcionario->getSalarioEfetivo();
