<?php

$precos = array();
//ou $precos = [];
//$precos = array(0 => 1.75, 2 => 1.78, 3 => 7.89, ...) criando td de uma vez com os indez que eu quero

$precos[0] = 1.75;
$precos[2] = 1.78;
$precos[] = 7.89; //prox posicao livre (3)
$precos[32] = 9.99; //prox posicao livre (4)
$precos[] = 7.89; 
$precos[12] = 7.89; 
$precos[] = 7.89; //soma o maior indice
$precos["nuvem"] = 100; //array associativo (chave a um valor)
$precos["biscoito"] = 7.89; 

//nao precisa necessariamente ter indices sequenciais em php

print_r($precos);
var_dump($precos);
var_dump(array_reverse($precos)); //perde os indices e tras so os valores ao contrario
//ordenando pelo indice
ksort($precos);
var_dump($precos);

//acessando o array
echo "O preco do biscoito é: " .$precos["biscoito"];

//php.net

//so funciona se os itens forem sequenciais
$tas = array("MD", "BH", "KK", "HM", "JP");

for($j=0; $j < count($tas); $j++):
    echo "$j : {$tas[$j]} <br>";
endfor;

//sempre melhor usar foreach
$tas2 = array("MD", "BH", 4 => "KK", "HM", "JP");

foreach ($tas2 as $key => $value){
    echo "$key : $value <br>";
}

$dados = array(
    array(0,"João","joao@i.br","123456",'m',1), 
    array(1,"Maria","maria@i.br","654321",'f',1), 
    array(2,"Gabriela","gabilimnda@i.br","password",'f',1), 
    array(3,"Kurt","cobain@i.br","teenspirit",'m',0), 
    array(4,"James","hetfield@i.br","seekanddestroy",'m',0));

?>