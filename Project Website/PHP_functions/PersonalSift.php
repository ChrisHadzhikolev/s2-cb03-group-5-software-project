<?php
$identity=$_GET['name'];

$servername = "studmysql01.fhict.local";  
$database = 'dbi428428';
$username = "dbi428428";
$password = "spiderMan2000";

    $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);




  
  
  $sqlworker ="SELECT username,".$_COOKIE['day']." FROM working_days WHERE ".$_COOKIE['day']." IN(1,2,3,0) AND username= :uname";
  $stmtworker = $conn->prepare($sqlworker);
  $stmtworker->execute(
      [
          ':uname'=>$identity,
      ]
  );
  $workers = $stmtworker->fetchAll();
  echo json_encode($workers);

  ?>