<?php

$servername = "studmysql01.fhict.local";  
$database = 'dbi428428';
$username = "dbi428428";
$password = "spiderMan2000";

    $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);



    $sqlworker="SELECT working_days.".$_COOKIE['day'].",working_days.username,People.first_name,People.last_name FROM working_days INNER JOIN People ON working_days.username = people.username WHERE ".$_COOKIE['day']." IN(1,2,3) AND NOT working_days.username LIKE 'mbemp1%%%%'";
  
  
  //$sqlworker ="SELECT username FROM working_days WHERE ".$_COOKIE['day']." IN(1,2,3) AND NOT username LIKE 'mbemp1%%%%'";
  $stmtworker = $conn->prepare($sqlworker);
  $stmtworker->execute();
  $workers = $stmtworker->fetchAll();

  $sqlname = "SELECT first_name,last_name FROM people WHERE username = 'poggers'";
  foreach ($workers as $value) {
    # code...
    $name = $value['username'];
    $sqlname =$sqlname." OR username = "."'".$name."'";
  }
 
  $stmtname = $conn->prepare($sqlname);
  $stmtname->execute();
  $names = $stmtname -> fetchAll();
  
  echo json_encode($workers);



?>
