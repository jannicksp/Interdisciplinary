// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let up = document.getElementById('list');
let down = document.getElementById('drink');
let softdrink = ['Vand', 'Mælk', 'Saftevand', 'Cola'];
let garnish = ['Agurk', 'Gulerød', 'Appelsin', 'Citron'];
let alcohol = ['Rom', 'Snaps', 'Vodka', 'Gin'];
let ingridients = softdrink.concat(garnish, alcohol);


up.innerHTML = "Click on the button to check "
    + "get a random drink<br><br>" + softdrink + "," + garnish +"," + alcohol;

function randomDrink() {
    down.innerHTML =
        ingridients[Math.floor(Math.random() * ingridients.length)];
        
}  


