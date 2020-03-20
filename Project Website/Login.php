<?php session_start(); ?>
<form method="post">
    <div class="container2">
        <label for="uname"><b>Username:</b></label>
        <input type="text" placeholder="Username" name="uname" required>
        <br>
        <label for="psw"><b>Password :</b></label>
        <input type="password" placeholder="Password" name="psw" required>
        <br>
        <label>
            <a href="Register.php" >Don't have an account? </a>
        </label>
        <br>
        <button type="submit" name="login_user">Login</button>
        <?php  ?>

    </div>
    <div class="container2" style="backface-visibility: visible">
        
    </div>
    </form>

    <?php
     if (isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] === true) {
        header("location: index.php");
     }


    if(isset($_POST['login_user'])){
    include 'Variables.php';
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
$_SESSION["loggedin"] = true;
sleep(1);
$sql2 ='SELECT * FROM people WHERE username = :username';
$stmt2 = $conn->prepare($sql2);
$stmt2->execute(
	[
		':username'=> $queryusername,
    ]
);
$resultt = $stmt2->fetch();

$_SESSION['fname'] = $resultt["first_name"];

$_SESSION['lname'] = $resultt["last_name"];

$_SESSION['position'] = $resultt["position"];

$_SESSION['email'] = $resultt["email"];

sleep(1);

header('Location:index.php');
    
}
else{
    
    $message = "You have entered the wrong password";
    echo "<script type='text/javascript'>alert('$message');</script>";
}
$conn = null;

    }
?>
