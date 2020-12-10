function addIngredient(e) {
    console.log(e);
}


let up = document.getElementById('list');
let down = document.getElementById('drink');
let softdrink = ['Vand', 'Mælk', 'Saftevand', 'Cola'];
let garnish = ['Agurk', 'Gulerød', 'Appelsin', 'Citron'];
let alcohol = ['Rom', 'Snaps', 'Vodka', 'Gin'];
let ingridients = softdrink.concat(garnish, alcohol);


up.innerHTML = "Click on the button to check "
    + "get a random drink<br><br>";

function randomDrink() {
    down.innerHTML =
        ingridients[Math.floor(Math.random() * ingridients.length)];

}  
