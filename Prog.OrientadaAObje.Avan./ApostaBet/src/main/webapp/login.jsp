<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Login</title>
</head>
<body>
    <div class="logindv">
        <h2>Login</h2>
    </div>
         <div class="bodydv">
    <form action="/home" method="post">
       <input type="hidden" name="ac" value="verify">
       <label for="login_email"> E-mail: </label>
       <input type="text" name="cpLogin" placeholder="usuario@gmail.com" id="login_email">
       <label for="login_senha"> Senha: </label>
       <input type="text" name="cpSenha" placeholder="********" id="login_senha">
       <button type="submit" name="bttn">Logar</button>
       <a href="#">Esqueci minha senha</a>
    </form>
</body>
</html>