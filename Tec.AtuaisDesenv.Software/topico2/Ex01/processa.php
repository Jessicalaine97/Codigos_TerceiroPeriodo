<?php
     // echo "O nome digitado foi: {$_POST["nome"]} {$_POST["sobrenome"]}<br>";
     // // get tb daria certo (passaria os dados na url)
     // echo "O mês foi digitado foi: {$_POST["selMes"]}<br>";

     // foreach ($extra[i] as $key) {
     //      echo "O extra é: {$_POST["$extras[i]"]}<br>";
     // }
     
     // //var_dump($_POST);
?>

<!DOCTYPE html>
<html lang="en">
<head>
     <meta charset="UTF-8">
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <title>Document</title>
</head>
<body>
     <p> O nome é: <?= $_POST["nome"]?></p>
     <p> O estado civil é: <?= $_POST["estCivil"]?></p>
     <p> O estado é: <?= $_POST["selEstado"]?></p>
     <p> Os extras são: </p>

     <?php
          foreach($_POST["extras"] as $extra):
     ?>

     <?= $extra ?><br>
     
     <?php
          endforeach;
     ?>

</body>
</html>