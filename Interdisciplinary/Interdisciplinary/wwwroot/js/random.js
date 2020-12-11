
//let up = document.getElementById('list');
//let down = document.getElementById('drink');
//let Name = ['Jannick', 'Burhan', 'Martin', 'Annalee'];
//let ingridients = Name;



//function randomName() {
//    down.innerHTML =
//       "The victim is:" + ingridients[Math.floor(Math.random() * ingridients.length)];
        
//}  

//up.innerHTML = "Players:"
//    + "<br><br>" + Name;


// Created by Ginfio

window.onload = function () {
    var list;
    var col = [];
    inp = document.getElementById("input");
    parent = document.getElementById("mother");
    addBtn = document.getElementById("addButton");
    winnerName = document.getElementById("name");
    pickBtn = document.getElementById("shuffleButton");
    pickBtn.addEventListener("click", pickWinner);
    addBtn.addEventListener("click", add);
    var i = 0; // init index of next array element to zero

    function add() {
        if (inp.value === '') return; // return if empty input

        list = document.createElement("li");
        parent.appendChild(list);
        list.innerHTML += inp.value;

        list.addEventListener('click', remove.bind(list, i)); // set onClick event function to call list.remove(i) when callback
        col.push({ index: i, name: inp.value });
        console.log('col after add: ' + JSON.stringify(col, null, 2)); // inspect col after add

        inp.value = ''; // clear input after update
        inp.focus(); // focus for next input
        i++; // increament i for next element
    }

    function remove(i) {
        col = col.filter(function (_, index) {
            return i !== index;
        }); // remove current item col[i]

        console.log('col after remove: ' + JSON.stringify(col, null, 2)); // inspect col after remove
        this.parentNode.removeChild(this); // remove self li
    }

    function pickWinner() {
        if (col.length === 0) return; // if empty, no winner
        var winner = col[Math.floor(Math.random() * col.length)].name; // get col[random].name as winner name
        winnerName.innerHTML = winner;
    }
}