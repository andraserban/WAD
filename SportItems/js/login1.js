function VerifyUser(){
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    var username = $("#userName").val();
    var password = $("#Password").val();

    sportsAPI.getUserByUserName(username).done(
        function (data) {
            if(data.length > 0){
                if(data[0].Password == password)
                {
                    $.cookie("User", data[0].UserId, { expires : 10 });
                }
                else{
                    alert("Incorrect password!");
                }
            }
            else{
                alert("User does not exist!");
            }

        }
    );
    window.location.replace("template.html");
    
}