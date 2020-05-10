<?php
$servername = "studmysql01.fhict.local";  
$database = 'dbi428428';
$username = "dbi428428";
$password = "spiderMan2000";

    $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);




  
  
    $sqlworker ="SELECT username FROM absence WHERE date = "."'".$_COOKIE['selectedDate']."'"." AND sick = 1";
  $stmtworker = $conn->prepare($sqlworker);
  $stmtworker->execute();
  $workers = $stmtworker->fetchAll();
  
  

  $sqlname = "SELECT first_name,last_name FROM people WHERE username = 'poggers'";
  foreach ($workers as $value) {
    $name = $value['username'];
    $sqlname =$sqlname." OR username = "."'".$name."'";
  }
 
  $stmtname = $conn->prepare($sqlname);
  $stmtname->execute();
  $names = $stmtname -> fetchAll();
  echo json_encode($names);



?>