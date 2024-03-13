<?php
    require_once("UsuarioSessao.php");
    class UsuarioSessaoPermissao extends UsuarioSessao{

        public $permissao;

        public function __construct($nome, $login, $permissao) {
            parent::__construct($login, $nome); //chamando construtor da classe pai
            //$this->nome= $nome;
            //$this->login= $login;
            $this->permissao= $permissao;
            echo "Nova permissao";
        }

        public function ler():string
        {
            echo "ler UsuarioSessao <br>";
            return $this->nome;
        }
    }