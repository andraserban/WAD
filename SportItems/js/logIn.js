function validateLogin(){
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    var username = $("#username").val();
    var password = $("#password").val();
	var attempt = 3; 

    sportsAPI.getUserByUserName(username).done(
        function (data) {
            if(data.length > 0){
                if(data[0].Password == password)
                {
					alert ("Login successfully");
					window.location.href = "template.html"; 
					
                }
                else{
					attempt --;
					alert("You have left "+attempt+" attempt;");
					if( attempt == 0){
						 alert("Incorrect password");	
						
					}
				}
	
            }
            else{
                alert("User does not exist!");
            }

        }
    );
 
    
}
function RegisterUser(){
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");
    var userInfo = {
        userName : $("#username").val() ,
        Email : $("#email").val() , 
        Password : $("#password").val(),
		Role: "user"
       
    }

    sportsAPI.addNewUser(userInfo).done(
        function (data){
            window.location.href="template.html";
        }
    );
 
}