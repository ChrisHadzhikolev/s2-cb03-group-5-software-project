<?php session_start(); ?>
<head>
    <link rel="stylesheet" type="text/css" href="logIn.css">
</head>
<body>
<form method="post">
    <div class="container2">
        <label for="email"><b>E-Mail:</b></label>
        <br>
        <input type="text" placeholder="Email" name="email" required>
        <br>
        <label for="fname"><b>First Name:</b></label>
        <br>
        <input type="text" placeholder="First name" name="fname" required>
        <br>
        <label for="lname"><b>Last Name:</b></label>
        <br>
        <input type="text" placeholder="First name" name="lname" required>
        <br>
        <label for="uname"><b>Username:</b></label>
        <br>
        <input type="text" placeholder="Username" name="uname" required>
        <br>
        <label for="psw"><b>Password:</b></label>
        <br>
        <input type="password" placeholder="Password" name="psw" required>
        <br>
        <label for="psw2"><b>Confirm Password :</b></label>
        <br>
        <input type="password" placeholder="Confirm Password" name="psw2" required>
        <br>
        <label>
            <a href="http://localhost/index.php?page=login" >Already have an account? </a>
        </label>
        <br>
        <button type="submit" name="Register">Register</button>
        
    </div>
    <div class="container2" style="backface-visibility: visible">
        
    </div>
    </form>
</body>
    <?php
    if(isset($_POST['Register'])){
    include 'Variables.php';
    $servername = "studmysql01.fhict.local";  
    $database = 'dbi428428';
    $username = "dbi428428";
    $password = "spiderMan2000";

        $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    




$queryfname = $_POST['fname'];
$queryflame = $_POST['lname'];
$queryusername = $_POST["uname"];
$querypassword = $_POST["psw"];
$querypassword2 = $_POST["psw2"];
$querymail = $_POST["email"];


if ($querypassword != $querypassword2)
{
    $message = "Passwords do not match";
    echo "<script type='text/javascript'>alert('$message');</script>";
    
}




$sql ='SELECT * FROM users WHERE username = :username';
$stmt = $conn->prepare($sql);
$stmt->execute(
	[
		':username'=> $queryusername,
	]
);
$sql ='SELECT * FROM users WHERE username = :username';
$stmt = $conn->prepare($sql);
$stmt->execute(
	[
		':username'=> $queryusername,
	]
);
while ($user = $stmt->fetch(PDO::FETCH_ASSOC)){
    echo $dbusername = $user['username'];
   
}

$sqll ='SELECT * FROM people WHERE email = :email';
$stmtt = $conn->prepare($sqll);
$stmtt->execute(
	[
		':email'=> $querymail,
	]
);
while ($user = $stmtt->fetch(PDO::FETCH_ASSOC)){

    echo $dbemail = $user['Email'];
}



while ($user = $stmt->fetch(PDO::FETCH_ASSOC)){
    echo $dbusername = $user['username'];
    echo $dbemail = $user['Email'];
}

if (!filter_var($querymail,FILTER_VALIDATE_EMAIL)) {
    $message = "Invalid E-mail";
    echo "<script type='text/javascript'>alert('$message');</script>";
    die();
}

if(strcasecmp($dbusername, $queryusername) == 0)
{
    $message = "Username already exists";
    echo "<script type='text/javascript'>alert('$message');</script>";
    die();
}
if(strcasecmp($dbemail, $querymail) == 0)
{
    $message = "E-mail is already in use";
    echo "<script type='text/javascript'>alert('$message');</script>";
    die();
    
}

$sql ="INSERT INTO users (username, password , platform) 
VALUES('$queryusername','$querypassword', 'WEB')";
$stmt = $conn->prepare($sql);
$stmt->execute();

$sqll ="INSERT INTO people (username, first_name,last_name, email, position) 
VALUES('$queryusername', '$queryfname','$queryflame','$querymail','CLIENT')";
$stmtt = $conn->prepare($sqll);
$stmtt->execute();

$message = "Account created successfully!";
echo "<script type='text/javascript'>alert('$message');</script>";
sleep(2);
header('Location:http://localhost/');


$conn = null;

    }
?>
