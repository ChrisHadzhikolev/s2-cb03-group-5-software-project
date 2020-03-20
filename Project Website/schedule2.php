<!DOCTYPE html>
<?php 
session_start();
include 'variables.php';
if (!isset($_SESSION["loggedin"])) {
  # code...
  header('Location:http://localhost/LogIn.php');
}?>
<html lang="en">
  <head>
    <meta charset="utf-8" />
    <meta name="description" content="" />
    <meta name="keywords" content="footer, address, phone, icons" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <link
      href="https://fonts.googleapis.com/css?family=Ubuntu&display=swap"
      rel="stylesheet"
    />
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
   

    <title>Schedule</title>
  </head>
  <body>
    <ul>
      <li>
        <a><span>IHDY</span></a>
      </li>
      <li class="home"><a href="index.php">Information</a></li>
      <li class="home"><a href="schedule.php">Schedule</a></li>
      <li class="home"><a href="messages.php">Notifications</a></li>
      <li style="float:right"><a href="#about">Login</a></li>
    </ul>

    <div class="main">
      <div class="bg-text">
        <h1 style="font-size:35px">MARCH 2020</h1>
        <!--<a class="button" href="php/login.php">Log in</a>-->
      </div>
    </div>
    
    <div class="images">
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">1-5/03/2020-...</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">9-12/03/2020</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">Prototype</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">Prototype</div>
        </div>
      </div>
    </div>
    <div class="main">
        <div class="april">
          <h1 style="font-size:35px">APRIL 2020</h1>
          <!--<a class="button" href="php/login.php">Log in</a>-->
        </div>
      </div>
    <div class="images">
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">AI &Media</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">User Study</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">Prototype</div>
        </div>
      </div>
      
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">Prototype</div>
        </div>
      </div>
    </div>
    <div class="images">
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">AI &Media</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">User Study</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">Prototype</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blue.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">Prototype</div>
        </div>
      </div>
    </div>
    <div class="main">
        <div class="may">
          <h1 style="font-size:35px">MAY 2020</h1>
          <!--<a class="button" href="php/login.php">Log in</a>-->
        </div>
      </div>
    <div class="images">
      <div class="container">
        <img
          src="blueish.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">AI &Media</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blueish.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">User Study</div>
        </div>
      </div>
      <div class="container">
        <img
          src="blueish.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">Prototype</div>
        </div>
      </div>
      
      <div class="container">
        <img
          src="blueish.png"
          width="220"
          height="220"
          alt="Avatar"
          class="image"
        />
        <div class="overlay">
          <div class="text">Prototype</div>
        </div>
      </div>
    </div>
    <div class="footer">
        <ul>
          <li><a class="active" href="#home">-> IHDY</a></li>
          <li><a href="#news">Services</a></li>
          <li><a href="#contact">Notifications</a></li>
          <li><a href="schedule.html">Schedule</a></li>
          <li><a href="#contact">Contact</a></li>
    <li style="float:right"><a href="#about">Login</a></li>
          
    </ul>
    <div class="footer">
        <ul>
          <li><a class="active" href="#home">+3156789980</a></li>
          <li><a class="active" href="mailto:media_bazaar@gmail.com">media_bazaar@gmail.com</a></li>
    <li style="float:right"><a href="#about">Caplaan 66, Eindhoven, Netherlands</a></li>
          
    </ul>
  </body>
</html>
