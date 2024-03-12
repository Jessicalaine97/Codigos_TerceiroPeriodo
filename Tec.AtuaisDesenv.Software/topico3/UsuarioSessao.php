<?php

class UsuarioSessao
{
    public $login;
    public $nome;

    public function salvar()
    {
        echo "salvar <br>";
    }

    public function ler()
    {
        echo "ler <br>";
    }

    public function __construct($login, $nome) 
    {
        $this->login = $login;
        $this->nome = $nome;
        echo "Novo objeto <br>";
    }
}