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

    <title>Register</title>

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
    
    <link href="css/main.css" rel="stylesheet" media="all" />
    <link rel="stylesheet" type="text/css" href="registerStyle.css" />
  </head>

  <body>
    <div class="page-wrapper bg-gra-01 p-t-180 p-b-100 font-poppins">
      <div class="wrapper wrapper--w780">
        <div class="card card-3">
          <div class="card-heading"></div>
          <div class="card-body">
            <h2 class="title">Register</h2>
            <form method="POST">
              <div class="input-group">
                <input
                  class="input--style-3"
                  type="text"
                  placeholder="Name"
                  name="name"
                />
              </div>
              <div class="input-group">
                <input
                  class="input--style-3 js-datepicker"
                  type="text"
                  placeholder="Birthdate"
                  name="birthday"
                />
                <i
                  class="zmdi zmdi-calendar-note input-icon js-btn-calendar"
                ></i>
              </div>
              <div class="input-group">
                <div class="rs-select2 js-select-simple select--no-search">
                  <select name="gender">
                    <option disabled="disabled" selected="selected"
                      >Gender</option
                    >
                    <option>Male</option>
                    <option>Female</option>
                    <option>Other</option>
                  </select>
                  <div class="select-dropdown"></div>
                </div>
              </div>
              <div class="input-group">
                <input
                  class="input--style-3"
                  type="email"
                  placeholder="Email"
                  name="email"
                />
              </div>
              <div class="input-group">
                <input
                  class="input--style-3"
                  type="text"
                  placeholder="Phone"
                  name="phone"
                />
              </div>
              <div class="p-t-10">
                <button class="btn btn--pill btn--green" type="submit">
                  Submit
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
    if(isset($_POST['Register'])){
    include 'Variables.php';
    $servername = "studmysql01.fhict.local";  
    $database = 'dbi428428';
    $username = "dbi428428";
    $password = "spiderMan2000";

        $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password,$phone);
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
header('Location:index.php');


$conn = null;

    }
?>
