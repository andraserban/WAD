function validate(){
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    var username = $("#us").val();
    var password = $("#pass").val();
	var attempt = 3; 

    sportsAPI.getUserByUserName(username).done(
        function (data) {
            if(data.length > 0){
                if(data[0].Password == password)
                {
                    $.cookie("User", data[0].UserId, { expires : 10 });
					alert ("Login successfully");
					window.location = "template.html"; 
					return false;
                }
                else{
					attempt --;
					alert("You have left "+attempt+" attempt;");
					if( attempt == 0){
						 alert("Incorrect password");	
						return false;
					}
				}
	
            }
            else{
                alert("User does not exist!");
            }

        }
    );
 
    
}