﻿
let up = document.getElementById('list');
let down = document.getElementById('drink');
let Name = ['Jannick', 'Burhan', 'Martin', 'Annalee'];
let ingridients = Name;



function randomName() {
    down.innerHTML =
       "The victim is:" + ingridients[Math.floor(Math.random() * ingridients.length)];
        
}  

up.innerHTML = "Players:"
    + "<br><br>" + Name;


