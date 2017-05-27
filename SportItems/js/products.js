function loadBasketball()
{
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    sportsAPI.getAllBasketball().done(
        function (data){
            var result = "";
            for(i = 0; i < data.length; i++){

              if(data[i].image != null && data[i].description !== null && data[i].price !==null && data[i].productName !==null){

                    if(data[i].ProductId != null){

                        result +='<div class="col-md-3 col-sm-6"><span class="thumbnail"><img src="http://localhost:50311' + data[i].image +'" class="img-rounded">' +'<h4>'+ data[i].productName + '</h4>' +'<p>'+ data[i].description + '</p>' + '<hr class="line"><div class="row"><div class="col-md-6 col-sm-6"><p class="price"> ' + '$'+ data[i].price +'</p></div><div class="col-md-6 col-sm-6"></div></div></span></div>';
                    }
                    
                } 
            }
            var finalElement = $(result);
            $("#productsBox").prepend(finalElement);
        }
    );
}

function loadSwimming()
{
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    sportsAPI.getAllSwimming().done(
        function (data){
            var result = "";
            for(i = 0; i < data.length; i++){

                if(data[i].image != null && data[i].description !== null && data[i].price !==null && data[i].productName !==null){

                    if(data[i].ProductId != null){

                        result +='<div class="col-md-3 col-sm-6"><span class="thumbnail"><img src="http://localhost:50311' + data[i].image +'" class="img-rounded">' +'<h4>'+ data[i].productName + '</h4>' +'<p>'+ data[i].description + '</p>' + '<hr class="line"><div class="row"><div class="col-md-6 col-sm-6"><p class="price"> ' + '$'+ data[i].price +'</p></div><div class="col-md-6 col-sm-6"></div></div></span></div>';
										
                    }
                    
                } 
            }
            var finalElement = $(result);
            $("#productsBox").prepend(finalElement);
        }
    );
}
function loadYoga()
{
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    sportsAPI.getAllYoga().done(
        function (data){
            var result = "";
            for(i = 0; i < data.length; i++){

                if(data[i].image != null){

                    if(data[i].ProductId != null){

                        result += '<div class="col-md-3 col-sm-6"><span class="thumbnail"><img src="http://localhost:50311' + data[i].image +'" class="img-rounded">' +'<h4>'+ data[i].productName + '</h4>' +'<p>'+ data[i].description + '</p>' + '<hr class="line"><div class="row"><div class="col-md-6 col-sm-6"><p class="price"> ' + '$'+ data[i].price +'</p></div><div class="col-md-6 col-sm-6"></div></div></span></div>';
                    }
                    
                } 
            }
            var finalElement = $(result);
            $("#productsBox").prepend(finalElement);
        }
    );
}
function loadPilates()
{
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    sportsAPI.getAllPilates().done(
        function (data){
            var result = "";
            for(i = 0; i < data.length; i++){

                if(data[i].image != null){

                    if(data[i].ProductId != null){

                        result += '<div class="col-md-3 col-sm-6"><span class="thumbnail"><img src="http://localhost:50311' + data[i].image +'" class="img-rounded">' +'<h4>'+ data[i].productName + '</h4>' +'<p>'+ data[i].description + '</p>' + '<hr class="line"><div class="row"><div class="col-md-6 col-sm-6"><p class="price"> ' + '$'+ data[i].price +'</p></div><div class="col-md-6 col-sm-6"></div></div></span></div>';
                    }
                    
                } 
            }
            var finalElement = $(result);
            $("#productsBox").prepend(finalElement);
        }
    );
}
function addProduct(){
    var sportsAPI = new sportItemsAPI();
    sportsAPI.setBaseURL("http://localhost:50311");

    var product = {
        ProductName: $("#productname").val(),
        ProductCategory: $("#productcategory").val(),
        ProductPrice: $("#price").val(),
        ProductDescription: $("#description").val(),
        Price: $("#inputPrice").val(),
    }

    sportsAPI.addNewProduct(product).done(
        function (data){
            window.location.href = "template.html";
        }
    );
}
