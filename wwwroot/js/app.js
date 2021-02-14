
/* register / login button */
var x = document.getElementById("login");
var y = document.getElementById("register");
var z = document.getElementById("btn");

function register() {
    x.style.left = "-400px";
    y.style.left = "50px";
    z.style.left = "110px";
}

function login() {
    x.style.left = "50px";
    y.style.left = "450px";
    z.style.left = "0px";
}

/* nav */

function redirectingHomePage() {
    window.location = "http://localhost:5000"
}

function redirectingProducts() {
    window.location = "http://localhost:5000/product/shop"
}

function redirectingForms() {
    window.location = "http://localhost:5000/form/login"
}



function showPayment() {
    var x = document.getElementById("checkout");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}


var back2Top = document.getElementById("back2Top");
back2Top.style.display = "none";  // hidden by default
document.querySelector('body').onscroll = function () {
    if (window.scrollY > 150) // showing 150px from top
        back2Top.style.display = "block";
    else
        back2Top.style.display = "none";
};