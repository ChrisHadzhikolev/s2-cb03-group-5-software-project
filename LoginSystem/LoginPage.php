<!doctype>
<html>
<head>
    <link rel="stylesheet" type="text/css" href="logInStyle.css">
</head>
<body>
<h1>Sign In</h1>
<form action="LogInDBcon.php" method="post">
    <div class="container">
        <label for="uname"><b>Username:</b></label>
        <input type="text" placeholder="Username" name="uname" required>
        <br>
        <label for="psw"><b>Password :</b></label>
        <input type="password" placeholder="Password" name="psw" required>
        <br>
        <label>
            <input type="checkbox" checked="checked" name="remember"> Remember me
        </label>
        <br>
        <button type="submit" name="login_user">Login</button>
    </div>
    <div class="container" style="backface-visibility: visible">
        <span class="psw"><a href="#">Forgot password?</a></span>
    </div>
    </form>
</body>
</html>
