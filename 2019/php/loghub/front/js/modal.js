var btn = document.getElementById("btn");

var modal = document.getElementById("showmodal");

var span = document.getElementsByClassName("close")[0];

btn.onclick = function(){
    modal.style.display = "block";
}
span.onclick = function(){
    modal.style.display = "none";
}

