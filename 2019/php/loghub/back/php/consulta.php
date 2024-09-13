<?php

include './db_connection.php';

$conn = getConnection();

$sql ='SELECT * FROM login';

$consulta = $conn->query($sql);

echo "<table>".
     "<tr><th>User</th><th>Password</th><th>Email</th>";
        while($linha = $consulta->fetch(pdo::FETCH_ASSOC)){
            echo "<tr>".
                 "<td>".$linha['user_account']."</td>".
                 "<td>".$linha['password_account']."</td>".
                 "<td>".$linha['email']."</td>".
                 "</tr>";
        }
        echo "</table>";

    