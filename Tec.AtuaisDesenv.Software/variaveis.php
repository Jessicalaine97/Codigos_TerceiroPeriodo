<?php
    $nome = "Jess"; //variavel nao pode comecar com numero(case sensitive)
    $Nome = "J";
    echo $nome;
    echo "<br>";
    echo $Nome;
    echo "<br>";
    echo gettype($nome); //imprimindo o tipo
    echo "<br>";

    $varA = "A";
    $varB = 'A';
    //$varB = $varA;
    echo "$varA";
    echo "<br>";
    echo '$varB'; //aspas simples nao interpreta

    echo is_string($varA); //1 true
    //==(valor), ===(valor e tipo)

    $texto = "<br>Olá";
    $texto2 = " mundo";
    echo $texto.$texto2; //concatenacao

    for($i=0; $i<10; $i++){
        echo "$i<br>";
    }

    for($i=0; $i<20; $i++){
        echo "O quadrado de $i é " .$i*$i,"<br>";
    }
?>