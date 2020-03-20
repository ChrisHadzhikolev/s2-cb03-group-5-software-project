<!DOCTYPE html>
<?php 
session_start();
include 'variables.php';

if (!isset($_SESSION["loggedin"])) {
  # code...
  header('Location:http://localhost/LogIn.php');
}

?>

<html lang="en">
  <head>
    <meta charset="utf-8" />
    <meta name="description" content="" />
    <meta name="keywords" content="footer, address, phone, icons" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <link
      href="http://fonts.googleapis.com/css?family=Cookie"
      rel="stylesheet"
      type="text/css"
    />
    <link
      href="https://fonts.googleapis.com/css?family=Volkhov&display=swap"
      rel="stylesheet"
    />

    <link
      rel="stylesheet"
      href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css"
    />
    <script
      type="text/javascript"
      src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js"
    ></script>
    <link
      href="https://fonts.googleapis.com/css?family=Merriweather:400,900,900i"
      rel="stylesheet"
    />
    <link rel="stylesheet" href="index.css" />

    <title>Employee</title>
  </head>
  <body>
    <ul>
      <li>
        <a><span>IHDY</span></a>
      </li>
      <li class="home"><a href="index.php">Information</a></li>
      <li class="home"><a href="schedule2.php">Schedule</a></li>
      <li class="home"><a href="messages.php">Notifications</a></li>
      <li style="float:right"><a href="logout.php">Logout
      </a></li>
    </ul>

    <div class="main">
      <div class="bg-text">
        <h1 style="font-size:30px">Personal Information</h1>
        <!--<a class="button" href="php/login.php">Log in</a>-->
      </div>
    </div>
  
<div class="card">
  <img src="employee.jpg" alt="John" style="width:100%">
  <h1><?php echo "". $_SESSION['fname'] ." ". $_SESSION['lname'];?></h1>
  <p class="title"><?php echo "". $_SESSION['position'];?></p>
  <p><button>Upload photo</button><input type="file" name="myfile" /></p>
  <p><button>Edit info</button></p>
  <p><button>Edit privacy settings</button></p>
</div>
<div class="contact-info">
Contact information: <br> 
<div class="contacts">e-mail: <?php echo "". $_SESSION['email'];?> <br>
phone: <br>
linkedin: <br>
facebook: <br>
</div>
</div>
<div class="extra-info">
  Extra information: <br>
  
<div class="contacts"> 
  Gender: <br>
  Birthday: <br>
  Natinality:
</div></div>

    <div class="footer">
      <ul>
        <li><a class="active" href="#home">-> IHDY</a></li>
        <li><a href="#news">Services</a></li>
        <li><a href="#contact">Notifications</a></li>
        <li><a href="schedule.html">Schedule</a></li>
        <li><a href="#contact">Contact</a></li>
  <li style="float:right"><a href="#about">Login</a></li>
         </div><div class="footer">
          <ul>
            <li><a class="active" href="#home">+3156789980</a></li>
            <li><a class="active" href="mailto:media_bazaar@gmail.com">media_bazaar@gmail.com</a></li>
      <li style="float:right"><a href="#about">Caplaan 66, Eindhoven, Netherlands</a></li>
            
      </ul>
    <!-- <a class="button" href="php/AboutUsPage.php">Click Me</a>
</div>-->

    
        <!--<p class="footer-company-name">© 2020 MediaBazaar Inc.</p>
      </div>

      <div class="footer-center">
        <div>
          <i class="fa fa-map-marker"></i>
          <p><span> Caplaan 66 </span> Eindhoven, Netherlands</p>
        </div>

        <div>
          <i class="fa fa-phone"></i>
          <p>+31 674 898 468</p>
        </div>
        <div>
          <i class="fa fa-envelope"></i>
          <p>
            <a href="mailto:media_bazaar@gmail.com">media_bazaar@gmail.com</a>
          </p>
        </div>
      </div>
      <div class="footer-right">
        <p class="footer-company-about">
          <span>About the company</span>
          Startup. Fresh Solutions. Good Results.
        </p>
        <div class="footer-icons">
          <a href="#"><i class="fa fa-facebook"></i></a>
          <a href="#"><i class="fa fa-twitter"></i></a>
          <a href="#"><i class="fa fa-instagram"></i></a>
          <a href="#"><i class="fa fa-linkedin"></i></a>
          <a href="#"><i class="fa fa-youtube"></i></a>
        </div>
      </div>
    </footer>-->
  </body>
</html>
