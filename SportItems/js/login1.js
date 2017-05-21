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
					alert ("Login successfully");
					window.location.href = "template.html"; 
					break;
                }
                else{
					attempt --;
					alert("You have left "+attempt+" attempt;");
					if( attempt == 0){
						 alert("Incorrect password");	
						break;
					}
				}
	
            }
            else{
                alert("User does not exist!");
            }

        }
    );
 
    
}