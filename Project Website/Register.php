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
                  placeholder="Username"
                  name="uname"
                />
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

              <div class="input-group">
                <input
                  class="input--style-3"
                  type="password"
                  placeholder="Password"
                  name="psw"
                />
              </div>
              <div class="input-group">
                <input
                  class="input--style-3"
                  type="password"
                  placeholder="Confirm Password"
                  name="psw2"
                />
              </div>

              <div class="input-group">
                <input
                  class="input--style-3"
                  type="password"
                  placeholder="Verification Code"
                  name="code"
                />
              </div>

              <div class="p-t-10">
                <button class="btn btn--pill btn--green" type="submit" name ="Register">
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

        $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    


$queryusername = $_POST["uname"];
$querypassword = $_POST["psw"];
$querypassword2 = $_POST["psw2"];
$querymail = $_POST["email"];
$querynumber = $_POST["phone"];
$querycode = $_POST["code"];


if ($querypassword != $querypassword2)
{
    $message = "Passwords do not match";
    echo "<script type='text/javascript'>alert('$message');</script>";
    die();
    
}


$sqlcode = 'SELECT username FROM users WHERE first_time_verification_key = :code AND first_time_verification_key IS NOT NULL' ;
$stmtcode = $conn->prepare($sqlcode);
$stmtcode->execute(
  [
    ':code'=>$querycode,
  ]
  );

  $olduser = $stmtcode->fetch();

  if($stmtcode->rowCount() == 0)
  {
    $message = "Invalid Code";
    echo "<script type='text/javascript'>alert('$message');</script>";
    die();
  }

  $sqlckeckname = 'SELECT * FROM users WHERE LOWER(username) = LOWER(:username)' ;
  $stmtcheckname = $conn->prepare($sqlckeckname);
  $stmtcheckname->execute(
[
  ':username'=>$queryusername,
]
  );
  echo $querymail;

  
 if($stmtcheckname->rowCount() > 0)
 {
  $message = "Username already exists";
  echo "<script type='text/javascript'>alert('$message');</script>";
  die();
 }


$sqlcheckmail = 'SELECT * FROM people WHERE LOWER(email)=LOWER(:email)';
$stmtcheckemail = $conn->prepare($sqlcheckmail);
$stmtcheckemail->execute(
  [
    ':email'=>$querymail,
  ]
);
if($stmtcheckemail->rowCount() > 0)
 {
  $message = "Email already in use";
  echo "<script type='text/javascript'>alert('$message');</script>";
  die();
 }


$sql ="UPDATE users SET username = :username , password = :pass WHERE first_time_verification_key = :code "  ;
$stmt = $conn->prepare($sql);
$stmt->execute(
  [
    ':username' => $queryusername,
    ':pass' => $querypassword,
    ':code' => $querycode,
  ]
);


 $sqll ="UPDATE people SET email = :email , phone_number= :nr WHERE username = :username";
 $stmtt = $conn->prepare($sqll);
 $stmtt->execute(
  [
  ':email' => $querymail,
  ':nr' => $querynumber,
  ':username' => $queryusername,
  ]
);

$sqlremovecode = "UPDATE users SET first_time_verification_key = null WHERE first_time_verification_key = :code";
$stmtremovecode = $conn->prepare($sqlremovecode);
$stmtremovecode->execute(
  [
    
    ':code'=>$querycode,
  ]
);

$message = "Account created successfully!";
echo "<script type='text/javascript'>alert('$message');</script>";
sleep(2);
header('Location:index.php');


$conn = null;

    }
?>
