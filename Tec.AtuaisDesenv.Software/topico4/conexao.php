<?php

$db = new mysqli('mariadb', 'root', 'root', 'tads');

$query = 'select * from tads.alunos;';
$result = $db->query($query);
//var_dump($result);

while($linha=$result->fetch_assoc()){
    echo "<p> {$linha["id"]} {$linha["nome"]} {$linha["matricula"]}</p>";
}

$db->close();