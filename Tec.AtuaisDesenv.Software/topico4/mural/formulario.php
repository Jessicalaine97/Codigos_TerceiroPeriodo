<form action="" method="post">
    Nome:
    <input type="text" name="nome" id="nome"><br>
    E-mail:
    <input type="text" name="email" id="email"><br>
    Cidade:
    <input type="text" name="cidade" id="cidade"><br>
    Recado:
    <textarea name="recados" id="recado" cols="30" rows="10"></textarea><br>
    <input type="submit" value="Cadastrar" name="cadastrar"><br>
</form>

    <?php
        if(isset($_POST["cadastrar"])):
            $nome=$_POST["nome"];
            $email=$_POST["email"];
            $cidade=$_POST["cidade"];
            $recados=$_POST["recados"];

            $sql="insert into tads.recados (nome, email, cidade, recados) values('{$nome}', '{$email}', '{$cidade}', '{$recados}');";

            var_dump($sql);
            $con->query($sql);
        endif;
    ?>

