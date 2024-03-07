<!DOCTYPE html>

<%@ page import="br.edu.vianna.model.Calculadora" %>

<html lang="en">
<head>
    <title>Web app</title>
    <link rel="stylesheet" href="css/style.css">
    <meta charset="UTF-8">
</head>
<body>

    <div class="container">
        <div class="header">
            <h1>Calcular</h1>
        </div>
        <div class="body">
            <div class="bodyContainer">
            <%
                String nome = request.getParameter("nome");
                double calc = (Double)request.getAttribute("calc");
                Calculadora obj = (Calculadora)request.getAttribute("obj");
            %>
               <h1>
                    O nome é: <% out.print(nome); %>
                    O resultado é: <% out.print(obj.operacao()); %>
                    <% out.print(nome); %> <% out.print(obj.getValor1()); %>
               </h1>
            </div>
        </div>
        <div class="footer">
            <h2>footer</h2>
        </div>
    </div>
    <!--script src="js/script.js"></script>-->
    <script src="js/ajax.js"></script>
</body>
</html>