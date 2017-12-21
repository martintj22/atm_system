<?php session_start(); ?>

<?php
if(!isset($_SESSION['valid'])) {
	header('Location: login.php');
}
?>



<?php
//including the database connection file
include_once("connection.php");

//fetching data in descending order (lastest entry first)
$result = mysqli_query($mysqli, "SELECT * FROM konto WHERE login_id=".$_SESSION['id']." ORDER BY id DESC");
?>




<html>
<head>
	<title>Homepage</title>
</head>




<body>	<H2> Amazing Team M - ATM  </H2>

	<br/><br/>
	<H2> Vælg et beløb du vil hæve  </H2>
	<table width='80%' border=0>
		<tr bgcolor='#CCCCCC'>
			
		</tr>
		<?php
		
		
		while($res = mysqli_fetch_array($result)) {		
			echo "<tr>";
			
			
			
			
			
		  echo "<td><a href=\"edit.php?id=$res[id]\">100.kr</a> | </td>";	
echo "<tr>";		  
		  
		  echo "<td><a href=\"edit.php?id=$res[id]\">300.kr</a> | </td>";	
echo "<tr>";		  
		  
		  echo "<td><a href=\"edit.php?id=$res[id]\">500.kr</a> | </td>";		

		}
		?>
	</table>

	

</body>
</html>

