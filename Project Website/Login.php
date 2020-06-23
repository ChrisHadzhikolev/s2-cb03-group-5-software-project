<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta
      name="viewport"
      content="width=device-width, initial-scale=1, shrink-to-fit=no"
    />
    <meta name="description" content="Colorlib Templates" />
    <meta name="author" content="Colorlib" />
    <meta name="keywords" content="Colorlib Templates" />

    <title>Login</title>

    <!-- Icons font-->
    <link
      href="vendor/mdi-font/css/material-design-iconic-font.min.css"
      rel="stylesheet"
      media="all"
    />
    <link
      href="vendor/font-awesome-4.7/css/font-awesome.min.css"
      rel="stylesheet"
      media="all"
    />
    <!-- Font for the page-->
    <link
      href="https://fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i"
      rel="stylesheet"
    />
    <link href="vendor/select2/select2.min.css" rel="stylesheet" media="all" />
    <link
      href="vendor/datepicker/daterangepicker.css"
      rel="stylesheet"
      media="all"
    />
    <link rel="stylesheet" type="text/css" href="registerStyle.css" />
  </head>

  <body>
    <div class="page-wrapper bg-gra-01 p-t-180 p-b-100 font-poppins">
      <div class="wrapper wrapper--w780">
        <div class="card card-3">
          <div class="card-heading"></div>
          <div class="card-body">
            <h2 class="title">Login</h2>
            <form method="POST">
              <div class="input-group">
                <input
                  class="input--style-3"
                  type="text"
                  placeholder="Userame"
                  name="uname"
                />
              </div>
              <div class="input-group">
                <input
                  class="input--style-3 js-datepicker"
                  type="password"
                  placeholder="Password"
                  name="psw"
                />
                
              </div>  
              <a href="Register.php">Don't have a profile?</a>
              <div class="p-t-10">
                <button class="btn btn--pill btn--green" type="submit" name = "login_user">
                  Login
                </button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>

   
    <script src="vendor/jquery/jquery.min.js"></script>
    
    <script src="vendor/select2/select2.min.js"></script>
    <script src="vendor/datepicker/moment.min.js"></script>
    <script src="vendor/datepicker/daterangepicker.js"></script>

    <script src="js/global.js"></script>
  </body>
  
</html>
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



$_SESSION['uname'] = $resultt["username"];



    
}
else{
    
    $message = "You have entered the wrong password";
    echo "<script type='text/javascript'>alert('$message');</script>";
}
$conn = null;
header('Location:index.php');
    }
?>
