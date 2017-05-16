function loadBasketball()
{
    var sportItemsAPI = new sportItemsAPI();
    sportItemsAPI.setBaseURL("http://localhost:50311");

    sportItemsAPI.getAllBasketball().done(
        function (data){
            var htmlString = "";
            for(i = 0; i < data.length; i++){

                if(data[i].Image == null){

                    if(data[i].PriductId == null){

                        htmlString += '<a class="img" href="Basketball.html"><img src=' + data[i].Image + 'class="img-responsive"></a>'
                    }
                    
                } 
            }
            productBox.prepend(htmlString);
        }
    );
}

function loadSwimming()
{
    var sportItemsAPI = new sportItemsAPI();
    sportItemsAPI.setBaseURL("http://localhost:50311");

    sportItemsAPI.getAllSwimming().done(
        function (data){
            var htmlString = "";
            for(i = 0; i < data.length; i++){

                if(data[i].Image == null){

                    if(data[i].PriductId == null){

                        htmlString += '<a class="img" href="Swimming.html"><img src=' + data[i].Image + 'class="img-responsive"></a>'
                    }
                    
                } 
            }
            productBox.prepend(htmlString);
        }
    );
}
function loadYoga()
{
    var sportItemsAPI = new sportItemsAPI();
    sportItemsAPI.setBaseURL("http://localhost:50311");

    sportItemsAPI.getAllYoga().done(
        function (data){
            var htmlString = "";
            for(i = 0; i < data.length; i++){

                if(data[i].Image == null){

                    if(data[i].PriductId == null){

                        htmlString += '<a class="img" href="Yoga.html"><img src=' + data[i].Image + 'class="img-responsive"></a>'
                    }
                    
                } 
            }
            productBox.prepend(htmlString);
        }
    );
}
function loadPilates()
{
    var sportItemsAPI = new sportItemsAPI();
    sportItemsAPI.setBaseURL("http://localhost:50311");

    sportItemsAPI.getAllPilates().done(
        function (data){
            var htmlString ="";
            for(i = 0; i < data.length; i++){

                if(data[i].Image == null){

                    if(data[i].PriductId == null){

                        htmlString += '<a class="img" href="Pilates.html"><img src=' + data[i].Image + 'class="img-responsive"></a>'
                    }
                    
                } 
            }
            productBox.prepend(htmlString);
        }
    );
}