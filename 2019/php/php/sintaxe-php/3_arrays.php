<?php
//3 FORMAS DE CRIAR UM ARRAY
$carros = array("BMW", "VELOSTER", "HILUX");
print_r($carros); //Array ( [0] => BMW [1] => VELOSTER [2] => HILUX )

echo"<hr>";

$motos = array();
$motos[] = "Yamaha";
$motos[] = "Suzuki";
$motos[] = "Honda";
print_r($motos); //Array ( [0] => Yamaha [1] => Suzuki )

echo"<hr>";

$cidades = ["Passos", "São Paulo", "Belforoxo","Rio de Janeiro"];
print_r($cidades); //Array ( [0] => Passos [1] => São Paulo [2] => Belforoxo [3] => Rio de Janeiro )
echo"<hr>";

//CONT - Conta os arrays
echo count($cidades); //3
echo"<hr>";

//FOREACH - Percorre o array atribuindo a uma variavel ($valor)
foreach($carros as $valor){
    echo $valor."<br>";
}
echo"<hr>";
 
//Arrays associativos

$pessoa = array("nome"=>"Nicolas","idade"=>21,"altura"=>1.63);
echo $pessoa["idade"];
echo"<hr>";

//Arrays Multidimensionais

$times = array(
    "cariocas"=> array("campeao"=>"flamengo","vice"=>"vasco","terceiro"=>"botafogo"),
    "paulistas"=> array("santos","sao paulo","palmeiras"),
    "mineiros"=> array("cruzeiro","atletico","america")
);

echo $times["cariocas"]["campeao"];
echo"<br>";
echo $times["paulistas"][1];
echo"<br>";
echo $times["mineiros"][0];
echo"<hr>";

foreach($times["mineiros"] as $indice) {
    echo $indice."<br>";
}
echo"<hr>";
foreach($times["cariocas"] as $indice=>$valor){
    echo $indice." : ".$valor."<br>";
}
