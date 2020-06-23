<?php session_start();?>
<head>
    <link rel="stylesheet" type="text/css" href="logOut.css">
    <link
            href="vendor/mdi-font/css/material-design-iconic-font.min.css"
            rel="stylesheet"
            media="all"
    />
</head>
<body>
<div class="content">

    <form method='post' >
        <p>Are you sure you want to log out?</p>
        <br>
        <button type="submit" name="logout_user">Logout</button>
    </form>
</div>


</body>
<?php
    if(isset($_POST['logout_user'])){
        unset($_SESSION['loggedin']);
        sleep(2);
        header('Location:index.php');
    }


        ?>  