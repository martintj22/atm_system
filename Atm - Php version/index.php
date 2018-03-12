<?php session_start(); ?>
<html>
<head>
	<title>Atm system</title>
	<link href="style.css" rel="stylesheet" type="text/css">
</head>

<body>
	<div id="header">
	Atm system
	</div>
	<?php
	if(isset($_SESSION['valid'])) {			
		include("connection.php");					
		$result = mysqli_query($mysqli, "SELECT * FROM login");
	?>
				
		Velkommen til vores atm <?php echo $_SESSION['name'] ?> ! <a href='logout.php'>Log ud</a><br/>
		<br/>
		<a href='view.php'>Hvis konto</a>
		<br/><br/>
	
	
	<?php	
	} else 
	{
		echo "Indtast konto oplysninger for at hæve et beløb.<br/><br/>";
		echo "<a href='login.php'>Login</a> | <a href='register.php'>Register</a>";
	}
	?>
	
	<div id="footer">
		<h1> Et skole projekt </h1>
	</div>
</body>
</html>
