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
$result = mysqli_query($mysqli, "SELECT * FROM products WHERE login_id=".$_SESSION['id']." ORDER BY id DESC");
?>




<html>
<head>
	<title>Homepage</title>
</head>



<body>
	<a href="index.php">Netbank</a>  | <a href="logout.php">Logud</a>
	<br/><br/>
	
	<table width='80%' border=0>
		<tr bgcolor='#CCCCCC'>
			<td>Navn</td>
			<td>Saldo</td>
		</tr>
		<?php
		while($res = mysqli_fetch_array($result)) {		
			echo "<tr>";
			echo "<td>".$res['konto']."</td>";
			echo "<td>".$res['saldo']."</td>";
		  echo "<td><a href=\"edit.php?id=$res[id]\">500.kr</a> | </td>";		

		}
		?>
	</table>

	

</body>
</html>

