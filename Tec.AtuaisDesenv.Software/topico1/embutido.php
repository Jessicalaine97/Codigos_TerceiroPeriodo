<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Embutido</title>
    <style>
        .blue{
            color:blue;
        }

    </style>
</head>
<body>
    <div class="principal">
        <h1>Quadrados</h1>
        <p>
            <?php
                $i=1;
                while($i<=20):
                    $quadrado=$i*$i;
                    echo "O quadrado de $i é $quadrado <br>\n";
                    $i++;
                endwhile;

                $nome = "Jessica";
                $sobrenome = "Laine";
            ?>
            <h2 class=blue>
                <?= $nome." ".$sobrenome;
                ?>
            </h2>

            <?php
                $patinhos=99;
                while($patinhos>=1):
            ?>
                <?= $patinhos?> foram passear<br>
                Além das montanhas para brincar<br>
                A mamãe gritou: Quá, quá, quá, quá<br>
                Mas só <?= --$patinhos?> patinhos voltaram de lá<br><br>
            <?php
                endwhile;
            ?>

            <?php
                for($j=99; $j>=0; $j--):
                    $j."foram passear<br>\n
                    Além das montanhas para brincar<br>\n
                    A mamãe gritou: Quá, quá, quá, quá<br>\n
                    Mas só" .$j-1. "patinhos voltaram de lá<br>\n"
                endfor;
            ?>

        </p>
    </div>
</body>
</html>