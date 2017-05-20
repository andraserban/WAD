function loadBasketball()
{
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    sportsAPI.getAllBasketball().done(
        function (data){
            var htmlString = "";
            for(i = 0; i < data.length; i++){

                if(data[i].image != null){

                    if(data[i].ProductId != null){

                        htmlString += '<a class="img" href="Basketball.html"><img src="http://localhost:50311' + data[i].image + '" class="img-responsive"></a>'
                    }
                    
                } 
            }
            var newElement = $(htmlString);
            $("#productsBox").prepend(newElement);
        }
    );
}

function loadSwimming()
{
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    sportsAPI.getAllSwimming().done(
        function (data){
            var htmlString = "";
            for(i = 0; i < data.length; i++){

                if(data[i].image != null){

                    if(data[i].ProductId != null){

                        htmlString += '<a class="img" href="Swimming.html"><img src="http://localhost:50311' + data[i].image + '" class="img-responsive"></a>'
										'<a href="Swimming.html">' + data[i].description + '</a>'
                    }
                    
                } 
            }
            var newElement = $(htmlString);
            $("#productsBox").prepend(newElement);
        }
    );
}
function loadYoga()
{
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    sportsAPI.getAllYoga().done(
        function (data){
            var htmlString = "";
            for(i = 0; i < data.length; i++){

                if(data[i].image != null){

                    if(data[i].ProductId != null){

                        htmlString += '<a class="img" href="Yoga.html"><img src="http://localhost:50311' + data[i].image + '" class="img-responsive"></a>'
                    }
                    
                } 
            }
            var newElement = $(htmlString);
            $("#productsBox").prepend(newElement);
        }
    );
}
function loadPilates()
{
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    sportsAPI.getAllPilates().done(
        function (data){
            var htmlString = "";
            for(i = 0; i < data.length; i++){

                if(data[i].image != null){

                    if(data[i].ProductId != null){

                        htmlString += '<a class="img" href="Pilates.html"><img src="http://localhost:50311' + data[i].image + '" class="img-responsive"></a>'
                    }
                    
                } 
            }
            var newElement = $(htmlString);
            $("#productsBox").prepend(newElement);
        }
    );
}
