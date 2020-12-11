

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
    var i = 0; 

    function add() {
        if (inp.value === '') return; 

        list = document.createElement("li");
        parent.appendChild(list);
        list.innerHTML += inp.value;

        list.addEventListener('click', remove.bind(list, i)); 
        col.push({ index: i, name: inp.value });
        console.log('col after add: ' + JSON.stringify(col, null, 2)); 

        inp.value = ''; 
        inp.focus(); 
        i++; 
    }

    function remove(i) {
        col = col.filter(function (_, index) {
            return i !== index;
        }); 

        console.log('col after remove: ' + JSON.stringify(col, null, 2)); 
        this.parentNode.removeChild(this); 
    }

    function pickWinner() {
        if (col.length === 0) return; 
        var winner = col[Math.floor(Math.random() * col.length)].name; 
        winnerName.innerHTML = winner;
    }
}