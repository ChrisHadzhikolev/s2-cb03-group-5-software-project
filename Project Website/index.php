<?php session_start();

if (!isset($_SESSION["loggedin"]))
{
  header("location: Login.php");
}
header("Expires: Tue, 01 Jan 2000 00:00:00 GMT");
header("Last-Modified: " . gmdate("D, d M Y H:i:s") . " GMT");
header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");

$servername = "studmysql01.fhict.local";  
    $database = 'dbi428428';
    $username = "dbi428428";
    $password = "spiderMan2000";

        $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        
        $sql ='SELECT * FROM people WHERE username = :username';
        $stmt = $conn->prepare($sql);
        $stmt->execute(
          [
            ':username'=> $_SESSION['uname'],
          ]
        );
        $result = $stmt->fetch();
        $conn = null;

?>




<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8" />
    <meta
      name="viewport"
      content="width=device-width, initial-scale=1, shrink-to-fit=no"
    />
    <link rel="icon" href="img/favicon.png" type="image/png" />
    <link
      rel="stylesheet"
      href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"
      integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"
      crossorigin="anonymous"
    />
    
    
    <link rel="stylesheet" href="editInfo.css" />
    <title>Edit personal info</title>
    </head>
   <body style="background-color: #a5b3fe">
   <?php
require_once "navBar.php";
?>
<div class="container"style="  height: 150%; width: 70%">
    <h1>Profile</h1>
  
	<div class="row">
      <!-- left column -->
      <div class="col-md-3">
        <div class="text-center">
          <img src="<?php 
          $name = $_SESSION['uname'];
          if(file_exists("pics/$name.png"))
          {
            echo "pics/$name.png"."?". rand(99,9999) .'/>';
          }
          else{
            echo "pics/default.png"."?". rand(99,9999) .'/>';
          }
          
          ?>" class="avatar img-circle" alt="avatar" style="width:200px;height:200px">
              </div>
      </div>
      
      <!-- edit form column -->
      <div class="col-md-9 personal-info">
        
        <h3>Personal info</h3>
        
        <form class="form-horizontal" role="form">
          <div class="form-group">
            <label class="col-lg-3 control-label">First name:</label>
            <div class="col-lg-8">
              <input class="form-control" type="text" value="<?php echo $result['first_name']?>" style="color:black">
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 control-label">Last name:</label>
            <div class="col-lg-8">
              <input class="form-control" type="text" value="<?php echo $result['last_name']?>"
              style="color:black">
            </div>
          </div>
          
          <div class="form-group">
            <label class="col-lg-3 control-label">Email:</label>
            <div class="col-lg-8">
              <input class="form-control" type="text" value="<?php echo $result['email']?>" style="color:black">
            </div>
          </div>
          
          <div class="form-group">
            <label class="col-lg-3 control-label">Phone Number:</label>
            <div class="col-lg-8">
              <input class="form-control" type="text" value="<?php echo $result['phone_number']?>" style="color:black">
            </div>
          </div>
          
          <div class="form-group">
            <label class="col-md-3 control-label"></label>
            <div class="col-md-8">
              <a href="EditInfo.php"><input type="button" class="btn btn-primary" value="Edit information" style="background-color:#a5b3fe;border-color: black;color:#2f292f"></a>
            </div>
          </div>
        </form>
      </div>
  </div>
</div>

</body>
</html>