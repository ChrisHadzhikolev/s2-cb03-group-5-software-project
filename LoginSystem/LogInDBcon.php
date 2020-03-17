<?php


    $servername = "studmysql01.fhict.local";
    $database = 'dbi428428';
    $username = "dbi428428";
    $password = "spiderMan2000";

$conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);




$queryusername = $_POST["uname"];
$querypassword = $_POST["psw"];
$sql ='SELECT * FROM users WHERE username = :username AND password= :pword';
$stmt = $conn->prepare($sql);
$stmt->execute(
	[
		':username'=> $queryusername,
		':pword' => $querypassword
	]
);
$result = $stmt->fetch();
if($stmt->rowCount() > 0)
{
	
	echo "<a>You Have Successfully Logged in</a>";
	exit();
	
}
else{
	echo " <p>You Have Entered Incorrect Password</p>";
	exit();
}
$conn = null;
