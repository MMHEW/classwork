var vases = document.getElementsByTagName("img");

window.onload = function() {
    state = null;
}

for(i = 0; i<vases.length; i++){

    vases[i].src= "https://static.wikia.nocookie.net/clubpenguin/images/2/20/Green_Vase.png/revision/latest?cb=20141229161405";


}



const randIndex = Math.floor(Math.random() * vases.length);

vases[randIndex].setAttribute("id", "winner");


var node = document.createElement("li");
node.innerHTML = "HELLO";
var parent = document.getElementById("parent");
parent.appendChild(node);

var flag = true;
var x=0;
while(flag){
    
    console.log(x);
    if(x==100){flag=false}
     
    else{
        x++;
    }
    
    
}
