<?php

require_once("UsuarioSessao.php");
$usu1 = new UsuarioSessao("Juquinha", "Juca");

$usu1->salvar();
$usu1->ler();

var_dump($usu1);

