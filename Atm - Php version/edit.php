<?php session_start(); ?>

<?php
if(!isset($_SESSION['valid'])) {
	header('Location: login.php');
}
?>


	
				

<?php
// including the database connection file
include_once("connection.php");

if(isset($_POST['update']))
{	
	$id = $_POST['id'];
	$saldo = $_POST['saldo'];
	
	// checking empty fields
		
		//updating the table

		$result = mysqli_query($mysqli, "UPDATE konto SET saldo = saldo - 500 WHERE id=$id");
		
		//redirectig to the display page. In our case, it is view.php
		header("Location: login.php");
	
}
?>
<?php
//getting id from url
$id = $_GET['id'];

//selecting data associated with this particular id
$result = mysqli_query($mysqli, "SELECT * FROM konto WHERE id=$id");


?>
<html>
<head>	
	<title>Edit Data</title>
</head>

<body>
	<br/><br/>
	
	<form name="form1" method="post" action="edit.php">
		<table border="0">
			<tr> 
			</tr>
			<tr> 
		
				<h1>
				Vil du udskrive kvitering?
				</h1>
  
  

			</tr>
		
			<tr>
				<td><input type="hidden" name="id" value=<?php echo $_GET['id'];?>></td>
								<td><input type="submit" name="update" value="Nej tak" ></td>
				<td><input type="submit" name="update" value="Ja tak" ></td>
			</tr>
		</table>
	</form>


	
</body>
</html>