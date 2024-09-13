<?php
/*
 * is_array(); --> Verifica se a variavel é um array 
 * in_array($valor, $array); --> Verifica se determinado valor existe em alguma posição do array
 * array_keys($array); --> Retorna um novo array com as chaves do array passado como parâmetro
 * array_values($array); 
 * array_merge($array1, $array2); 
 * array_pop(); 
 * array_shift(); 
 * array_unshift(); 
 * array_push(); 
 * array_combine();  
 * array_sum(); 
 * explode(); 
 * implode(); 
 */
$nomes = array("Nicolas", "Bruna", "Priscila", "Beatriz", "João");

if(is_array($nomes)):
    echo "é array";
else:
    echo "não é um array";
endif;
/* ******************** */
echo "<hr>";

in_array("Nicolas", $nomes); //TRUE
in_array("Paulo", $nomes); //False

if(in_array("Felipe", $nomes)):
    echo "Existe no array";
else:
    echo "Não existe";
endif;
/* ******************** */
echo "<hr>";


