
"use strict";
const formPicker = document.querySelector("#IngredientPicker");
let pickedIngredients = [];
let formRandom = document.querySelector(".randomDrinkSubmit");
let checkboxes = document.querySelectorAll('#ChosenIngredients input[type=checkbox]:checked');

formPicker.addEventListener("submit", event => {
    event.preventDefault();
    let ingredient = JSON.parse(formPicker.elements.ingredient.options[formPicker.elements.ingredient.selectedIndex].getAttribute("data-value"));

    document.querySelector("#ChosenIngredients .chosen").innerHTML += `<div class="pickedIngredient"><input type="checkbox" id="${ingredient[0].name}" name="selected" checked value="${ingredient[0].id}" hidden data-cat="${ingredient[0].category}">
  <label class="rubrik" for="${ingredient[0].name}"> ${ingredient[0].name}</label><br></div>`

    document.querySelectorAll("#ChosenIngredients .chosen div").forEach(element => {
        element.removeEventListener("click", deletePicked);
        element.addEventListener("click", deletePicked);
    })
});

function deletePicked(e) {
    this.remove();
}

document.querySelector("#ChosenIngredients button").addEventListener("click", event => {



    if (document.querySelector("#ChosenIngredients").elements.selected == undefined) {
        document.querySelector(".error-message").innerHTML = "Please choose at least one ingredient"
    } else {
        document.querySelector(".error-message").innerHTML = ""
        document.querySelector("#ChosenIngredients").submit();
    }
});



formRandom.addEventListener("click", event => {
    event.preventDefault();

    checkboxes.forEach(checkbox => {
        console.log(checkbox.getAttribute("data-cat"));
        pickedIngredients.push({ "name": checkbox.id, "category": checkbox.getAttribute("data-cat") });

    })




    let session = localStorage.setItem("session", JSON.stringify(pickedIngredients));



    document.querySelector("#getRandom").submit()




})






