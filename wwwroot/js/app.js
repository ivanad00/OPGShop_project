
///* register / login button */
//var x = document.getElementById("login");
//var y = document.getElementById("register");
//var z = document.getElementById("btn");

//function register() {
//    x.style.left = "-400px";
//    y.style.left = "50px";
//    z.style.left = "110px";
//}

//function login() {
//    x.style.left = "50px";
//    y.style.left = "450px";
//    z.style.left = "0px";
//}

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



//function showPayment() {
//    var x = document.getElementById("checkout");
//    if (x.style.display === "none") {
//        x.style.display = "block";
//    } else {
//        x.style.display = "none";
//    }
//}



/* back to top */
var back2Top = document.getElementById("back2Top");
back2Top.style.display = "none";  // hidden by default
document.querySelector('body').onscroll = function () {
    if (window.scrollY > 150) // showing 150px from top
        back2Top.style.display = "block";
    else
        back2Top.style.display = "none";
};


const starElements = document.querySelectorAll(".star .heart-icon");
for (let i = 0; i < starElements.length; i++) {
    const starElement = starElements[i];
    starElement.addEventListener("click", handleStarClick);
}

function handleStarClick(e) {
    const star = e.currentTarget;
    const starContainer = star.parentElement;
    const starSiblings = starContainer.children;

    let clickedStarPassed = false;
    for (let i = 0; i < starSiblings.length; i++) {
        const currentStar = starSiblings[i];

        if (!clickedStarPassed) {
            currentStar.classList.remove("far");
            currentStar.classList.add("fas");
        }
        else {
            currentStar.classList.remove("fas");
            currentStar.classList.add("far");
        }

        if (currentStar == star) {
            clickedStarPassed = true;
        }
    }
}

var count;

function starmark(item) {
    count = item.id[0];
    sessionStorage.starRating = count;
    var subid = item.id.substring(1);
    for (var i = 0; i < 5; i++) {
        if (i < count) {
            document.getElementById((i + 1) + subid).style.color = "orange";
        }
        else {
            document.getElementById((i + 1) + subid).style.color = "white";
        }


    }

}

//function result() {
//    //Rating : Count
//    //Review : Comment(id)
//    alert("Rating : " + count + "\nReview : " + document.getElementById("comment").value);
//}