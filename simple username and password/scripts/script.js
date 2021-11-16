

const users = {

    username: "Juan",

    password: "1234"

}


function validatePassword() {   
    var username = document.getElementById('username').value; 
    var password = document.getElementById('password').value;    
    var message = document.getElementById('message');   

     
        if(password == users.password && username == users.username) {        
            message.innerHTML = "Correct username and password";       
             message.className = "correct";    } 
        

         else {        
             message.innerHTML = "incorrect username or password";        
             message.className = "wrong";   
             }
            
                  //else if (username != users.username) {        
           //message.innerHTML = "inorrect username";  
           //message.className = "wrong";  
        //} 
        //else if (password != users.password) {        
           // message.innerHTML = "inorrect password";  
           // message.className = "wrong";  
        // }     
           
}


