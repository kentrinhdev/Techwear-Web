//==================================================================
//FRONT OF THE CARD
//==================================================================

//Determines if card is already flipped

function isCardFrontFlipped(numID) {
    event.preventDefault();

    var cardFront = document.getElementById(`productID_${numID}`);

    if (!cardFront.classList.contains('card-is-flipped')) {
        return false;
    } else {
        return true;
    }
}

//Adds the class that flips the card

function addClassToCardElement(numID) {
    event.preventDefault();

    var cardFront = document.getElementById(`productID_${numID}`);
    
    if (!cardFront.classList.contains('card-is-flipped')) {
        cardFront.classList += " card-is-flipped";
    }
}

//Removes the class that flips the card

function removeClassToCardElement(numID) {
    event.preventDefault();

    var cardFront = document.getElementById(`productID_${numID}`);
    
    if (cardFront.classList.contains('card-is-flipped')) {
        cardFront.classList.remove('card-is-flipped');
    }
}


//==================================================================
//BACK OF THE CARD
//==================================================================

//Determines if card is already flipped

function isCardBackFlipped(numID) {
    event.preventDefault();

    var cardBack = document.getElementById(`productID-back_${numID}`);

    if (!cardBack.classList.contains('card-is-flipped')) {
        return false;
    } else {
        return true;
    }
}

//Adds the class that flips the card

function addClassToCardBack(numID) {
    event.preventDefault();

    var cardBack = document.getElementById(`productID-back_${numID}`);

    if (!cardBack.classList.contains('card-is-flipped')) {
        cardBack.classList += " card-is-flipped";
    }
}

//Removes the class that flips the card

function removeClassToCardBack(numID) {
    event.preventDefault();

    var cardBack = document.getElementById(`productID-back_${numID}`);

    if (cardBack.classList.contains('card-is-flipped')) {
        cardBack.classList.remove('card-is-flipped');
    }
}

//==================================================================
//PRODUCT IMAGE SLIDER
//==================================================================

var i = 0;
var time = 5000; //10 second delay

var images_01 = [];
images_01[0] = "img/tee_01/snap_01.png";
images_01[1] = "img/tee_01/snap_02.png";
images_01[2] = "img/tee_01/snap_03.png";

var images_02 = [];
images_02[0] = "img/tee_02/snap_01.png";
images_02[1] = "img/tee_02/snap_02.png";
images_02[2] = "img/tee_02/snap_03.png";

var images_03 = [];
images_03[0] = "img/tee_03/snap_01.png";
images_03[1] = "img/tee_03/snap_02.png";
images_03[2] = "img/tee_03/snap_03.png";

var images_04 = [];
images_04[0] = "img/tee_04/snap_01.png";
images_04[1] = "img/tee_04/snap_02.png";
images_04[2] = "img/tee_04/snap_03.png";

var images_05 = [];
images_05[0] = "img/tee_05/snap_01.png";
images_05[1] = "img/tee_05/snap_02.png";
images_05[2] = "img/tee_05/snap_03.png";

var images_06 = [];
images_06[0] = "img/tee_06/snap_01.png";
images_06[1] = "img/tee_06/snap_02.png";
images_06[2] = "img/tee_06/snap_03.png";

var images_07 = [];
images_07[0] = "img/tee_07/snap_01.png";
images_07[1] = "img/tee_07/snap_02.png";
images_07[2] = "img/tee_07/snap_03.png";

var images_08 = [];
images_08[0] = "img/tee_08/snap_01.png";
images_08[1] = "img/tee_08/snap_02.png";
images_08[2] = "img/tee_08/snap_03.png";

function fadeIn(element, duration = 300) {
    element.style.display = '';
    element.style.opacity = 0;
    var last = + new Date();
    var tick = function () {
        element.style.opacity = +element.style.opacity + (new Date() - last) / duration;
        last = + new Date();
        if (+element.style.opacity < 1) {
            (window.requestAnimationFrame && requestAnimationFrame(tick)) || setTimeout(tick, time);
        }
    };
    tick();
}

function runRandom() {
    var rNum = Math.floor(Math.random() * 3);
    return rNum;
}

function changeImg() {
    var rn = runRandom();
    var cardImage_01 = document.getElementById("productImg_1");
    cardImage_01.src = images_01[rn];
    fadeIn(cardImage_01, time);

    console.log(`01 rn: ${rn}`);

    rn = runRandom();
    var cardImage_02 = document.getElementById("productImg_2");
    cardImage_02.src = images_02[rn];
    fadeIn(cardImage_02, time);

    console.log(`02 rn: ${rn}`);

    rn = runRandom();
    var cardImage_03 = document.getElementById("productImg_3");
    cardImage_03.src = images_03[rn];
    fadeIn(cardImage_03, time);

    console.log(`03 rn: ${rn}`);

    rn = runRandom();
    var cardImage_04 = document.getElementById("productImg_4");
    cardImage_04.src = images_04[rn];
    fadeIn(cardImage_04, time);

    console.log(`04 rn: ${rn}`);

    rn = runRandom();
    var cardImage_05 = document.getElementById("productImg_5");
    cardImage_05.src = images_05[rn];
    fadeIn(cardImage_05, time);

    console.log(`05 rn: ${rn}`);

    rn = runRandom();
    var cardImage_06 = document.getElementById("productImg_6");
    cardImage_06.src = images_06[rn];
    fadeIn(cardImage_06, time);

    console.log(`06 rn: ${rn}`);

    rn = runRandom();
    var cardImage_07 = document.getElementById("productImg_7");
    cardImage_07.src = images_07[rn];
    fadeIn(cardImage_07, time);

    console.log(`07 rn: ${rn}`);

    rn = runRandom();
    var cardImage_08 = document.getElementById("productImg_8");
    cardImage_08.src = images_08[rn];
    fadeIn(cardImage_08, time);

    console.log(`08 rn: ${rn}`);

    setTimeout("changeImg()", time);
}


//Get the button:
mybutton = document.getElementById("myBtn");

// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20 || mybutton.style.display > 0 || !window.pageYOffset || !window.scrollY) {
        mybutton.style.display = "block";
    } else {
        mybutton.style.display = "none";
    }
}

window.addEventListener("scroll", function () {
    if (mybutton.style.display == 0) {
        mybutton.style.display = "";
    } else {
        mybutton.style.display = "block";
    }
});

// When the user clicks on the button, scroll to the top of the document

function topFunction() {
    document.body.scrollTop = 0;
    window.scrollTo({ top: 0, behavior: 'smooth' });
}

function BlazorScrollToId(id) {
    const element = document.getElementById(id);
    if (element instanceof HTMLElement) {
        element.scrollIntoView({
            behavior: "smooth",
            block: "start",
            inline: "nearest"
        });
    }
}
