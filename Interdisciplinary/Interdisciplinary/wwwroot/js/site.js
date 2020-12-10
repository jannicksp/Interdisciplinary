
"use strict";
const formPicker = document.querySelector("#IngredientPicker");
let pickedIngredients = [];

formPicker.addEventListener("submit", event => {
    event.preventDefault();
    let ingredient = JSON.parse(formPicker.elements.ingredient.options[formPicker.elements.ingredient.selectedIndex].getAttribute("data-value"));

    document.querySelector("#ChosenIngredients .chosen").innerHTML += `<div class="pickedIngredient"><input type="checkbox" id="${ingredient[0].name}" name="selected" checked value="${ingredient[0].id}" hidden>
  <label for="${ingredient[0].name}"> ${ingredient[0].name}</label><br></div>`

    document.querySelectorAll("#ChosenIngredients .chosen div").forEach(element => {
        element.removeEventListener("click", deletePicked);
        element.addEventListener("click", deletePicked);
    })
});

function deletePicked(e) {
    this.remove();
   

}






