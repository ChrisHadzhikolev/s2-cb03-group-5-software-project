<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="schedule.css" />
    
    <title>Schedule</title>
  </head>
  <body>
  <?php
require_once "navBar.php";
?> <div class="calendar">
  <div class="checkboxes">
 <p>Check-in</p>

At work: <input type="checkbox" id="myCheck"  onclick="myFunction()">

<p id="text" style="display:none">Employee is at work.</p>
Absent: <input type="checkbox" id="myCheck_absent"  onclick="myFunction1()">

<p id="text_a" style="display:none">Employee is absent.</p>
Sick: <input type="checkbox" id="myCheck_sick"  onclick="myFunction2()">

<p id="text_s" style="display:none">Employee is sick.</p>
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

<div class="list-group" >
  <a href="#" class="list-group-item list-group-item-action" style="background-color:#a5b3fe; color: black">
    Shifts for today
  </a>
  <a href="#" class="list-group-item list-group-item-action" style="background-color:black; color: white">John Anderson</a>
  <a href="#" class="list-group-item list-group-item-action" style="background-color:black; color: white">Anna Stewart</a>
  <a href="#" class="list-group-item list-group-item-action" style="background-color:black; color: white">David Bonn</a>
</div>
<div class="list-group" style="margin-top:1%; margin-bottom:2%">
  <a href="#" class="list-group-item list-group-item-action" style="background-color:#a5b3fe; color: black">
    Absent employees due to sickness
  </a>
  <a href="#" class="list-group-item list-group-item-action" style="background-color:black; color: white">John Jenson</a>
  <a href="#" class="list-group-item list-group-item-action" style="background-color:black; color: white">Nora Stewart</a>
  <a href="#" class="list-group-item list-group-item-action" style="background-color:black; color: white">Dave Bummer</a>
</div>
  </body>
</html>
