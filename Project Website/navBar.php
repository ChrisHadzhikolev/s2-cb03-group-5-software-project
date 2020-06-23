
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
   <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
   <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link rel="stylesheet" href="navBar.css" />
  <title>Document</title>
</head>
<body>
<nav class="navbar navbar-expand-lg " style="background-color: black">

<div class="collapse navbar-collapse" id="navbarNavDropdown">
  <ul  class="navbar-nav">
  <li class="nav-item dropdown">
      <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
        Employee
      </a>
      <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
        <a class="dropdown-item" href="index.php">Profile</a>
        <a class="dropdown-item" href="personalSchedule.php">Personal schedule</a>
        <a class="dropdown-item" href="mailto:name@email.com">Contact manager</a>
        <a class="dropdown-item" href="editInfo.php">Edit information</a>
      </div>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="schedule.php">Schedule</a>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="stocks.php">Stocks</a>
    </li>
    <?php if( isset($_SESSION["loggedin"]) && $_SESSION["loggedin"]): ?>
      <li class="nav-item">
      <a class="nav-link" href="Logout.php">Logout</a>
    </li>
            <?php else: ?>
              <li class="nav-item">
      <a class="nav-link" href="Login.php">Login</a>
    </li>
            <?php endif; ?>
    
  </ul>
</div>
</nav>  
</body>
</html>

