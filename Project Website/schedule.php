<!DOCTYPE html>
<?php
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
    <link href="https://fonts.googleapis.com/css?family=Ubuntu&display=swap" rel="stylesheet">
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
      <li class="home"><a href="schedule.php">Schedule</a></li>
      <li class="home"><a href="messages.php">Notifications</a></li>
      <li style="float:right"><a href="#about">Login</a></li>
    </ul>

    <div class="main">
      <div class="bg-text">
        <h1 style="font-size:30px">SCHEDULE</h1>
        <!--<a class="button" href="php/login.php">Log in</a>-->
      </div>
    </div>

    <div class="calendar">
      <div class="month">
        <ul>
          <li class="prev">&#10094;</li>
          <li class="next">&#10095;</li>
          <p>August<br /><span style="font-size:18px">2017</span></p>
        </ul>
      </div>

      <ul class="weekdays">
        <li>Mo</li>
        <li>Tu</li>
        <li>We</li>
        <li>Th</li>
        <li>Fr</li>
        <li>Sa</li>
        <li>Su</li>
      </ul>

      <ul class="days">
        <li>1</li>
        <li>2</li>
        <li>3</li>
        <li>4</li>
        <li>5</li>
        <li>6</li>
        <li>7</li>
        <li>8</li>
        <li>9</li>
        <li><span class="active">10</span></li>
        <li>11</li>
        <li>12</li>
        <li>13</li>
        <li>14</li>
        <li>15</li>
        <li>16</li>
        <li>17</li>
        <li>18</li>
        <li>19</li>
        <li>20</li>
        <li>21</li>
        <li>22</li>
        <li>23</li>
        <li>24</li>
        <li>25</li>
        <li>26</li>
        <li>27</li>
        <li>28</li>
        <li>29</li>
        <li>30</li>
        <li>31</li>
      </ul>
    </div>
    <div class="notes">
      <div class="month">
        <p>Notes<br /><span style="font-size:18px">August</span></p>
      </div>

      <ul class="weekdays">
        <li>✓ 1.</li>
      </ul>
      <ul class="weekdays">
        <li>2.</li>
      </ul>
      <ul class="weekdays">
        <li>3.</li>
      </ul>
      <ul class="weekdays">
        <li>4.</li>
      </ul>
    </div>
    <!--tasks-->
    <div class="task">
      <div class="month">
        <p>Tasks<br /></p>
      </div>

      <ul class="weekdays">
        <li>1.</li>
      </ul>
      <ul class="weekdays">
        <li>2.</li>
      </ul>
      <ul class="weekdays">
        <li>3.</li>
      </ul>
      <ul class="weekdays">
        <li>4.</li>
      </ul>
      <ul class="weekdays">
        <li>5.</li>
      </ul>
    </div>
    <div class="footer">
      <ul>
        <li><a class="active" href="#home">-> IHDY</a></li>
        <li><a href="#news">Services</a></li>
        <li><a href="#contact">Notifications</a></li>
        <li><a href="schedule.html">Schedule</a></li>
        <li><a href="#contact">Contact</a></li>
  <li style="float:right"><a href="#about">Login</a></li>
        <div class="info_footer">
          <li>Caplaan 66 </li><br>
          <li>Eindhoven, Netherlands</li><br>
          
      
      </div>
      <div class="info2_footer">
        <li>+31 674 898 468</li><br>
          <li>media_bazaar@gmail.com</li>
        </div>
    </div>
  </ul>
    <!--<footer class="footer">
      <div class="footer-left pl-5">
        <h3><span>-> IHDY</span></h3>

        <p class="footer-links">
          <a href="#">Home</a>
          |
          <a href="#">Services</a>
          |
          <a href="#">Contact Us</a>
          |
          <a href="#">About Us</a>
          |
          <a href="#">Login</a>
          |
          <a href="#">Registration</a>
        </p>

        <p class="footer-company-name">© 2020 MediaBazaar Inc.</p>
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
