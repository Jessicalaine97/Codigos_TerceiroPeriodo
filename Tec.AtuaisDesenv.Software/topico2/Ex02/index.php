<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="processa.php" method="POST">
        <input type="text" name="nome">
        <input type="text" name="sobrenome"><br>
        <input type="radio" name="estCivil" value="Solteiro"> Solteiro
        <input type="radio" name="estCivil" value="Casado"> Casado <br>

        <select name="selEstado">
            <option value="RJ">Rio de Janeiro</option>
            <option>Minas Gerais</option>
            <option>São Paulo</option>
            <option>Espírito Santo</option>
        </select><br>

        <select name="selMes">
            <option value="Janeiro">1</option>
            <option value="Fevereiro">2</option>
            <option value="Março">3</option>
        </select><br>

        <input type="checkbox" name="extras[]" value="Garagem">Garagem<br>
        <input type="checkbox" name="extras[]" value="Piscina">Piscina<br>
        <input type="checkbox" name="extras[]" value="Jardim">Jardim<br>

        <input type="hidden" name="token" value="123456">
        <!-- qnd nao quero mostrar pro usuario -->

        <input type="submit" value="enviar">
    </form>

</body>
</html>