﻿<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
</head>
<body>







   <?php
   include("banner.php");
   ?>
    <div id="registreerContainer">


        <div id="regestratieVraag1">
           
            <p id="leerlingregistratieLabelAcount">maak uw account aan.</p>
			<div id="regLeft">
           <form method="post" action="leerlingRegistratie.php">
			<table border="1">
			<tr>
			<th colspan="4" id="midden">
			inloggegevens
			</td>
			</tr>

			<tr>
			<td id="midden">
			Email:
			</td>
			<td>
			<input type="email" value="" name="email" />
			</td>
			<td>
			 gebruikersnaam:
			</td>
			<td>
			<input type="text" value="" name="gebruikersnaam" /><br>
			</td>
			</tr>

			<tr>
			<td id="midden">
			voornaam:
			</td>
			<td >
			  <input type="text" value=" " name="naam" /><br />
			</td>
			<td>
			 wachtwoord:
			</td>
			<td>
			<input type="password" value="" name="passwoord1" /><br>
			</td>
			</tr>

			<tr>
			<td id="midden">
			 familienaam:
			</td>
			<td>
			<input type="text" value="" name="famielienaam" /><br />
			</td>
			<td id="midden">
			 herhaal uw wachtwoord:
			</td>
			<td>
			 <input type="password" value="" name="passwoord2" /><br />
			</td>
			</tr>

			<tr>
			<td colspan="2" id="midden">
			 Voer hier de code in die je van je leerkracht gekregen hebt:
			</td>
			<td colspan="2">
			 <input name="klascode"  type="number" size="40">
			</td>
			</tr>
			</table>
             
			 <input type="submit" value="inloggen" id="submid1" />
			 <br />
			</form>
			<?php 
			session_start();
			$debug = false ;
			include("dbConnection.php");

			if (isset($_POST['naam'])  ){
				$naam = $_POST['naam'];
				$famielienaam = $_POST['famielienaam'];
				$password1 = $_POST['passwoord1'];
				$password2 = $_POST['passwoord2'];
				$email = $_POST['email'];
				$code = $_POST['klascode'];
				if ($password1 == $password2) {
					if (strlen($password1) > 8) {
				$sql = "SELECT * FROM klas WHERE code = '$code'"; 
				$result = $conn->query($sql);

				//	$result = mysqli_query($conn,"SELECT * FROM klas WHERE code = '$code'");
					if ($result->num_rows == 1) {
					$row = $result->fetch_assoc();
					$klasid = $row['idklas'];
					// insert 
					
					$password1 = md5($password1);//encrypt the password before saving in the database
					$query = "INSERT INTO leerlingen (naam, famielienaam, idklas , wachtwoord, email,oefeningid)  VALUES ('$naam', '$famielienaam', '$klasid', '$password1', '$email', 1)";
					if(mysqli_query($conn, $query)) {
  
					if ($debug)	echo "Records added successfully.";
					
		// get the ID
		echo "SELECT idleerlingen FROM leerlingen WHERE email= '$email'";
		$sql = "SELECT idleerlingen FROM leerlingen WHERE email= '$email'";
	
	$result = $conn->query($sql);
	$ide = $result->fetch_assoc();
	$id = $ide['idleerlingen'];
	echo("<br> id = " . $id ."<br>");
	$_SESSION["id"] = $id ;


		 header('location: oefeningen.php ');
	
		} else{
			if(  (strpos(mysqli_error($conn), 'email'))   ) {
			   echo (" het emailadres is al in gebruik ");
			} else {
			echo "ERROR: Could not able to execute $query. " . mysqli_error($conn);
			}
		}

				} else {
					echo("Voer de juiste klascode in die je gekregen hebt van je leerkracht. Indien je dit niet gekregen hebt, dien je deze aan te vragen. ");
				}

				} else {
					echo("je wachtwoord moet minstens 8 tekens bevatten.");
				}

			} else {
				echo("de 2 wachtwoorden komen niet overeen. ");
			}


			
		}

?>
        </div>
    </div>
<br><br><br><br><br><br>
	<?php
include("footer.php");
?>
   

</body>
</html>