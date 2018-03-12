<?php
/*
// Opretter forbindelse til databasen
 */

$databaseHost = 'localhost';
$databaseName = 'test2';
$databaseUsername = 'root';
$databasePassword = '';

$mysqli = mysqli_connect($databaseHost, $databaseUsername, $databasePassword, $databaseName); 
	
?>
