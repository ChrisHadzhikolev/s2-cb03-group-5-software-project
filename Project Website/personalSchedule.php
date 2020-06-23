
<?php session_start();
ob_start(); 
header("Cache-control: no-cache");
if(!isset($_SESSION['reload']))
{
  header("location:personalschedule.php");
  $_SESSION['reload']="1";
}

if (!isset($_SESSION["loggedin"]))
{
  header("location: Login.php");
}
require_once "navBar.php";
$date=date("d/m/Y");
setcookie('selectedDate',$date);
$date="01/01/1999";
$day = date('l');
setcookie("day",$day);
$_COOKIE['selectedDate']=$date;
$date="11/10/1999";
$unem=$_SESSION['uname'];


?>




<!DOCTYPE html>
<html>
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="schedule.css" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css">
 <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
 <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
 <script src="jquery-3.5.0.min.js" type="text/javascript"></script>

    <title>Schedule</title>
  </head>
  <body>
 <div class="calendar">
 <!-- <div class="checkboxes">
 <p>Check-in</p>

At work: <input type="checkbox" id="myCheck"  onclick="myFunction()" name="work">

<p id="text" style="display:none">Employee is at work.</p>
Absent: <input type="checkbox" id="myCheck_absent"  onclick="myFunction1()" name = "absent">

<p id="text_a" style="display:none">Employee is absent.</p>
Sick: <input type="checkbox" id="myCheck_sick"  onclick="myFunction2()" name = "sick">

<p id="text_s" style="display:none">Employee is sick.</p>
</div>-->
<div id = "sickbutton">

    <button class="btn btn-primary" name ="sick"  onclick="Sick()" style="background-color:#a5b3fe;border-color: black;color:#2f292f;margin-left:45%;margin-top:2%;">
          Call in sick
          </button>

          </div>

<script src="checkbox.js" type="text/javascript"></script>

<div class="wrapper">
      <div class="container-calendar"> 
          <h3 id="monthAndYear"></h3>
          <div class="button-container-calendar">
              <button id="previous" onclick="previous()">&#8249;</button>
              <button id="next" onclick="next()">&#8250;</button>
          </div>
          
          <table class="table-calendar" id="calendar" data-lang="en">
              <thead id="thead-month"></thead>
              <tbody id="calendar-body"></tbody>
          </table>
          
          <div class="footer-container-calendar">
              <label for="month">Jump To: </label>
              <select id="month" onchange="jump()">
                  <option value=0>Jan</option>
                  <option value=1>Feb</option>
                  <option value=2>Mar</option>
                  <option value=3>Apr</option>
                  <option value=4>May</option>
                  <option value=5>Jun</option>
                  <option value=6>Jul</option>
                  <option value=7>Aug</option>
                  <option value=8>Sep</option>
                  <option value=9>Oct</option>
                  <option value=10>Nov</option>
                  <option value=11>Dec</option>
              </select>
              <select id="year" onchange="jump()"></select>       
          </div>
      </div>
    </div>
    </div>
    <script src="calendar.js" type="text/javascript"></script>


<div class="list-group" id ="workers" style="margin-top:1%; margin-bottom:2%">
  <a href="#" class="list-group-item list-group-item-action" style="background-color:#a5b3fe; color: black">
    Your shift on 
  </a>

</div>
  
  <script>
     var selectedDate = new Date();
     var weekday = new Array(7);
weekday[0] = "Sunday";
weekday[1] = "Monday";
weekday[2] = "Tuesday";
weekday[3] = "Wednesday";
weekday[4] = "Thursday";
weekday[5] = "Friday";
weekday[6] = "Saturday";
    var t = document.querySelector("#calendar-body");
        t.addEventListener("click", function (e) {
        selectedTd.classList.remove("selected");
    var tdSelected = e.composedPath()[0];
    
    if(tdSelected.nodeName === "SPAN"){
        selectedDate.setFullYear(currentYear,currentMonth, tdSelected.innerText);
        tdSelected = e.composedPath()[1];


        
    }else{
        selectedDate.setFullYear(currentYear,currentMonth, tdSelected.childNodes[0].innerText);

    }
    tdSelected.classList.add("selected");
    document.cookie = "selectedDate =" + selectedDate.toLocaleDateString();
    document.cookie = "day =" + weekday[selectedDate.getDay()];
    
    selectedTd = tdSelected;
    let Workers=($.ajax({
          url:"Php_functions/PersonalSift.php?name=<?php echo $unem?>",
          type:"POST",
          success:function(msg){
            ShowWorkers(msg,selectedDate.toLocaleDateString());
          },
          dataType:"json"
        }).responseText);

        
        
        


    
 

   
});

function ShowWorkers(worker,date){
  var Shift = " ";
  var string = "<a class='list-group-item list-group-item-action' style='background-color:#a5b3fe; color: black'>Your shift on "+date+"</a>";
  for(var i =0;i<worker.length;i++)
  {
   if (worker[i][1] == 0) {
     Shift = "Free Day";
     
   }
   if (worker[i][1] == 1) {
      Shift = "Day Shift";
     
   }
   if (worker[i][1] == 2) {
      Shift = "Half-Day Shift";
     
   }
   if (worker[i][1] == 3) {
      Shift = "Night Shift";
     
   }
    string +="<a class='list-group-item list-group-item-action' style='background-color:black; color: white'>"+Shift+"</a>"

  }


 

  document.getElementById("workers").innerHTML = string;  
} 

  </script>
  </body>
  
</html>

<?php


$servername = "studmysql01.fhict.local";  
$database = 'dbi428428';
$username = "dbi428428";
$password = "spiderMan2000";

    $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

if($date != $_COOKIE['selectedDate'])
{


  
  
  $sqlworker ="SELECT username FROM working_days WHERE ".$_COOKIE['day']."=1";
  $stmtworker = $conn->prepare($sqlworker);
  $stmtworker->execute();
$workers = $stmtworker->fetchAll();
$date =$_COOKIE['selectedDate'] ;

echo "<script>var Workers=($.ajax({url:'Php_functions/PersonalSift.php?name=$unem',type:'POST',success:function(msg){ShowWorkers(msg,selectedDate.toLocaleDateString());},dataType:'json'}).responseText);</script>";







ob_flush();
}
if(isset($_POST['sick']))
{

}

?>

