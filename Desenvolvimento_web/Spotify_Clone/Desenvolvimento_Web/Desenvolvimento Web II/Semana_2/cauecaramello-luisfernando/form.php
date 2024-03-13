<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Formulário</title>
</head>
<body>
    <h1 class="titulo">Salário</h1>
    <form method="post" action="#">
        <h4>Código:</h4> <input type="number" name="codigo"><br>
        <h4>Horas Trabalhadas:</h4> <input type="number" name="htrab"><br>
        <h4>Hora Extra:</h4> <input type="number" name="hextra"><br>
        <h4>Valor por Hora Trabalhada:</h4> <input type="number" name="valh"><br>
        <h4>Dependentes:</h4> <input type="number" name="dependentes"><br><br>
        <input type="submit" class="submit" value="Calcular">
    </form>
</body>
<?php
    if($_POST){
    $codigo = $_POST["codigo"];
    $htrab = $_POST["htrab"];
    $hextra = $_POST["hextra"];
    $valh = $_POST["valh"];
    $dependentes = $_POST["dependentes"];

    $bruto = ($htrab*$valh);
    $hextra = ($hextra*($valh*1.5));
    $dependente = ($bruto)*($dependentes*0.03);
    $transporte = (($bruto + $dependente)*0.06);
    $vliquido = $bruto + $hextra + $dependente - $transporte;

    echo "<h4><br>Código do Funcionário: </h4>" . $codigo;
    echo "<h4><br>Salário Bruto:</h4> " . $bruto;
    echo "<h4><br>Hora Extra: </h4>" . $hextra;
    echo "<h4><br>Acréscimo de Dependentes: </h4>" . $dependentes;
    echo "<h4><br>Valor Transporte:</h4> " . $transporte;
    echo "<h4><br>Valor Líquido: </h4>" . $vliquido;
}
?>
<footer>
    <p>Feito por: Cauê Caramello e Luis Fernando - DSM 2º Ciclo</p> 
</footer>
</html>