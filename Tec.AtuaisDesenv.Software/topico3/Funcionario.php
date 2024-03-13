<?php
    require_once("Pessoa.php");
    class Funcionario extends Pessoa{

        private int $matricula;

        public function __construct(float $salario, string $nome, int $matricula) {
           parent::__construct(float $salario, string $nome); //chamando construtor pai
           $this->matricula = $matricula;
        }

        public function getSalario(): float{
            return $this->salario;
        }

        public function setSalario(): (float $valor){
            if($valor >= 1000){
                $this->salario = $valor;
            }
        }
    }