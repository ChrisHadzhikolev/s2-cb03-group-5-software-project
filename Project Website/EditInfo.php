
<?php session_start();
header("Cache-control: no-cache");
error_reporting(0);

if (!isset($_SESSION["loggedin"]))
{
  header("location: Login.php");
}


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

<div style="  height: 150%; width: 70%"class="container">
    <h1>Edit Profile</h1>
 
    <form method="POST" name="form1" enctype="multipart/form-data">
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
          
          ?>" class="avatar img-circle" alt="avatar"  style="width:200px;height:200px">
          <h6>Upload a different photo...</h6>
          
          <input type="file" class="form-control" name="image" >
          <button class="btn btn-primary" name ="postpic" type="submit" style="background-color:#a5b3fe;border-color: black;color:#2f292f;">
          Update
          </button>
        </div>
      </div>
      </form>
      
      <!-- edit form column -->
      <div class="col-md-9 personal-info">
        
        <h3>Personal info</h3>
        
        <form class="form-horizontal" method="POST" name="form2">
          
          <div class="form-group">
            <label class="col-lg-3 control-label">Email:</label>
            <div class="col-lg-8">
              <input class="form-control" type="text" value="<?php echo  $result['email']?>" name ="email">
            </div>
          </div>
          <div class="form-group">
            <label class="col-lg-3 control-label">Number:</label>
            <div class="col-lg-8">
              <input class="form-control" type="text" value="<?php echo  $result['phone_number']?>" name="nr">
            </div>
          </div>
          <div class="form-group">
            <label class="col-md-3 control-label">Password:</label>
            <div class="col-md-8">
              <input class="form-control" type="password" value="" name="psw">
            </div>
          </div>
          <div class="form-group">
            <label class="col-md-3 control-label">Confirm password:</label>
            <div class="col-md-8">
              <input class="form-control" type="password" value="" name="psw2">
            </div>
          </div>
          <div class="form-group">
            <label class="col-md-3 control-label"></label>
            <div class="col-md-8">
            <button class="btn btn-primary" name ="save" type="submit" style="background-color:#a5b3fe;border-color: black;color:#2f292f">
          Save Changes
          </button><span></span>
          <a href="changePassword.php"><input type="button" class="btn btn-primary" value="Change password" style="background-color:#a5b3fe;border-color: black;color:#2f292f"></a>
              <input type="reset" class="btn btn-default" value="Cancel">
            </div>
          </div>
        </form>
      </div>
  </div>
</div>

</body>
</html>

<?php 

if(isset($_POST['postpic']))
{
  $name = $_FILES['image']['name'];
  $target_dir = "pics/";
  $target_file = $target_dir . basename($_FILES["image"]["name"]);
    // Select file type
    $imageFileType = strtolower(pathinfo($target_file, PATHINFO_EXTENSION));

    // Valid file extensions
    $extensions_arr = array("jpg", "jpeg", "png", "gif");

    // Check extension
    if (in_array($imageFileType, $extensions_arr)) {

        // Insert record


        // Upload file
        move_uploaded_file($_FILES['image']['tmp_name'], $target_dir . $_SESSION['uname'].".png"); 
        $message = "Picture succesfully updated";
        echo "<script type='text/javascript'>alert('$message');</script>"; 
        cleanCache();
        sleep(2);    
        header("location:Editinfo.php");

    }
    else{
      $message = "Please upload a picture";
        echo "<script type='text/javascript'>alert('$message');</script>"; 
    }
}

if(isset($_POST['save']))
{
  
  $servername = "studmysql01.fhict.local";  
    $database = 'dbi428428';
    $username = "dbi428428";
    $password = "spiderMan2000";

        $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        

        $sqlcheckpass ='SELECT password FROM users WHERE username = :username';
        $stmtcheckpass = $conn->prepare($sqlcheckpass);
        $stmtcheckpass->execute(
          [
            ':username' => $_SESSION['uname'],
          ]
          );

          $checkpass = $stmtcheckpass->fetch();
          $cpass = $checkpass['password'];
          $pass1 = $_POST['psw'];
          $pass2=$_POST['psw2'];
          
          if($pass1 === $pass2 && $pass2 === $cpass)
          {

          



        $sql ="UPDATE people SET email = :email , phone_number= :nr WHERE username = :username";

        $stmt = $conn->prepare($sql);
        $stmt->execute(
          [
            ':email' => $_POST['email'],
            ':nr' => $_POST['nr'],
            ':username'=> $_SESSION['uname'],

          ]
        );

        $message = "Your info has been changed.";
        echo "<script type='text/javascript'>alert('$message');</script>";
        
        redirect("location:EditInfo.php");

      }
      else
      {
        $message = "Wrong Password.";
        echo "<script type='text/javascript'>alert('$message');</script>";
        redirect("location:EditInfo.php");
    
      }

        $conn = null;



}