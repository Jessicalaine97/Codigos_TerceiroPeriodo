<?php

class UsuarioSessao
{
    public $login;
    public $nome;

    public function salvar(string $nome) //forcando que nome seja string
    {
        $this ->nome=$nome;
        echo "salvar <br>";
    }

    public function ler():string
    {
        echo "ler <br>";
        return $this->nome;
    }

    public function __construct($login, $nome) 
    {
        $this->login = $login;
        $this->nome = $nome;
        echo "Novo objeto <br>";
    }
}