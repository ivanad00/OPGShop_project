/* register / login button */
var x = document.getElementById("login");
var y = document.getElementById("register");
var z = document.getElementById("btn");

    function register(){
        x.style.left = "-400px";
        y.style.left= "50px";
        z.style.left="110px";
    }

    function login(){
        x.style.left = "50px";
        y.style.left= "450px";
        z.style.left="0px";
    }

/* nav */

function redirectingHomePage() {
    window.location = "http://localhost:5000"
}

function redirectingProducts() {
    window.location ="http://localhost:5000/product/shop"
}

function redirectingForms() {
    window.location = "http://localhost:5000/form/login"
}

