<!DOCTYPE html>
<html lang="en">
<head>
    <title>Web app</title>
    <link rel="stylesheet" href="css/style.css">
    <meta charset="utf-8">
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
            %>
               <h1>
                    Forward <% out.print(nome); %>
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