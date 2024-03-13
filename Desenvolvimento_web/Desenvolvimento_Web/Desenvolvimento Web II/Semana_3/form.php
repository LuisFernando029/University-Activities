<?php

if(isset($_FILES['foto']))
 {
    $destino = 'uploads/' . $_FILES['foto']['name'];
    $arquivo_tmp = $_FILES['foto']['tmp_name'];
    move_uploaded_file( $arquivo_tmp, $destino);

    $nome = $_POST["nome"];
    $email = $_POST["email"];
    $senha = $_POST["senha"];
    $dt_nascimento = $_POST["nascimento"];
    $cidade = $_POST["cidade"];
    $estado = $_POST["estado"];
    $sexo = $_POST["sexo"];
    $interesses = $_POST['interesses'];
    $mensagem = $_POST["mensagem"];
    $cor = $_POST["cor"];
 }

            list($ano, $mes, $dia) = explode('-', $dt_nascimento);
            $hoje = mktime(0, 0, 0, date('m'), date('d'), date('Y'));
            $dt_nascimento = mktime(0, 0, 0, $mes, $dia, $ano);
            $idade = floor((((($hoje - $dt_nascimento)/60)/60)/24)/365.25);

   // echo "<img src='" . $destino . "' alt='Minha Foto'>";
?>

<html>
    <head>
        <link rel="stylesheet" href="css/style.css">
        <style>
            body{
                background-color: <?echo $cor?>;
            }
        </style>
    </head>
    <body>

            <main class="main">
        <form>
            <section class="first-section">
                <div class="first-div">
                    <label>Nome Completo: <? echo $nome ?> </label class="label-form-body">

                    <label class="label-form-body">Email: <?echo $email ?></label>

                </div>
                <div class="second-div">
                    <label class="label-form-body">idade: <? echo $idade?></label>

                    <label class="label-form-body">Cidade: <? echo $cidade?></label>


                    <label>Estado: <? echo $estado?> </label>
                
            </section>
            </div>
            <section class="second-section">
                <div class="first-div-second-section">
                    <label class="label-form-body">Sexo - <?echo $sexo ?></label>
                </div>
                <div class="third-div">
                    <label class="label-form-body">Interesses: 
                    <? 
                        foreach ($interesses as $interesse){
                            echo "<br>$interesse";
                    }
                    ?> </label><br>
 
                </div>
                <label class="label-form-body">Foto</label>
                <img src=<?echo $destino?> alt='Minha Foto'>
                
                <div class="last-div">
                    <label class="label-form-body">Sobre voce: <?echo $mensagem?></label><br><br><br><br><br>
                    
                </div>
            </section>
        </form>
    </main>
    </body>

</html>