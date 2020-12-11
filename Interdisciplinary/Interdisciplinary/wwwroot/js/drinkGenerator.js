"use strict";

let ingredients = JSON.parse(localStorage.getItem("session"));
const placeholder = document.querySelector('.randomdrinkplaceholder');
const min = 1;
const max = 6;

//to do: sort by category, but that requires user to pick at least one of each category
placeholder.innerHTML = ingredients[Math.floor(Math.random() * ingredients.length)].name + " " + Math.floor(Math.random() * (max - min) + min) + "cl";




