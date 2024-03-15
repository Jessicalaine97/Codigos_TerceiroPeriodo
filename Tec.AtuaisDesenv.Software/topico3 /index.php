<?php
require_once "Funcionario.php";
require_once "Departamento.php";

$func1 = new Funcionario(2000, "João", 123);
$func2 = new Funcionario(6000, "Maria", 456);

var_dump($func1);

$dep1 = new Departamento;
$dep1->addFuncionario($func1);
$dep1->addFuncionario($func2);

var_dump($dep1);

echo $dep1->getFuncionario(1)->getSalario();

echo Departamento::IDENTIFICADOR;

echo Departamento::$quantidade;
