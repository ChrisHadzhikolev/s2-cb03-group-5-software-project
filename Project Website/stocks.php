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
   
    <meta name="viewport" content="width=device-width, initial-scale=1">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script> 
   
  <link rel="stylesheet" href="stocks.css" />
    <title>Stocks</title>
    </head>
   <body style=" background-color: #a5b3fe;">
   <?php
require_once "navBar.php";

?>
 <script src="jquery-3.5.0.min.js" type="text/javascript"></script>

<div class="container">
    <!-- Search form -->
    <div class="md-form mt-0">
        <input class="form-control" type="text" placeholder="Search" aria-label="Search" name="search" id="searchbar">
        <button class="btn btn-primary" name ="searchbutton"  onclick="SearchFor()" style="background-color:#a5b3fe;border-color: black;color:#2f292f;margin-left:45%;">
          Search
          </button>
    </div>
  <h2>Stocks</h2>
            
  <table class="table table-bordered">
    <thead>
      <tr>
        <th>Id</th>
        <th>Name</th>
        <th>Category</th>
        <th>Price</th>
        <th>Quantity</th>
        <th>Stock request</th>
      </tr>
    </thead>
    <tbody id="items">

    </tbody>
  </table>
</div>

</body>
</html>


<script>
let info=($.ajax({
          url:"PHP_functions/GrabItems.php",
          type:"POST",
          success:function(msg){
            UpdateTable(msg);
          },
          dataType:"json"
        }).responseText);



function UpdateTable(info)
{
  var string = " ";
  for (let index = 0; index < info.length; index++) {
    if (info[index][5] == 0) {
      info[index][5]="NO";
  }
  else{info[index][5]="YES";}
    string+="<tr><td>"+info[index][0]+"</td><td>"+info[index][1]+"</td><td>"+info[index][2]+"</td><td>"+info[index][3]+"€</td><td>"+info[index][4]+"</td><td>"+info[index][5]+"</td></tr>";
    document.getElementById("items").innerHTML = string;
  }
}
function SearchFor()
{
var likee = document.getElementById('searchbar').value;
let info=($.ajax({
          url:"PHP_functions/GrabItemsSearch.php?like="+likee,
          type:"POST",
          success:function(msg){
            UpdateTable(msg);
          },
          dataType:"json"
        }).responseText);

}

</script>
<?php
echo"<script>$.ajax({url:'PHP_functions/GrabItems.php',type:'POST',success:function(msg){UpdateTable(msg);},dataType:'json'});</script>";
?>
