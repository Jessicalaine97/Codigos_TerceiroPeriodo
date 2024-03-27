<?php

require_once "Database.php";

$db = new Database();

$con=$db->getConnection();

require "formulario.php";

$db->closeConnection();