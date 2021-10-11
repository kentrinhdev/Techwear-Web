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
