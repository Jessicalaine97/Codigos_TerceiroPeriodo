<?php

class Pessoa
{
    protected float $salario;
    protected string $nome;

    public function __construct(float $salario, string $nome) {
        $this->salario = $salario;
        $this->some = $nome;
    }

   
}