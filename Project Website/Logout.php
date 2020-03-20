<?php session_start();?>
<head>
    <link rel="stylesheet" type="text/css" href="logIn.css">
</head>
<body>
<form method="post">
    <div class="container2">
        <p>Are you sure you want to log out?</p>
        <br>
        <button type="submit" name="logout_user">Logout</button>
    </div>
    <div class="container2" style="backface-visibility: visible">
        
    </div>
    </form>
</body>
<?php
    if(isset($_POST['logout_user'])){
        unset($_SESSION['loggedin']);
        sleep(2);
        header('Location:http://localhost/');
    }


        ?>  