<?php
/* 

$GLOBALS
$_SERVER = array com vários indices que
$_REQUEST
$_POST
$_GET
$_FILES
$_COOKIE
$_SESSION

*/

$x = 10;
$y = 15;

function soma() {
    echo $GLOBALS['x'] + $GLOBALS['y'];
    //echo $x + $y; inacessivel
}