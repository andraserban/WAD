function sportItemsAPI() {

    if (typeof sportItemsAPI.instance === 'object') {
        return sportItemsAPI.instance;
    }

    var baseURL = "localhost";
    var doAsyncGet = function (partialUrl) {
        var authorityToken = '';//$.cookie("sportItems_token");
        var fullUrl = baseURL + partialUrl;
        return $.ajax({
            url: fullUrl,            
            dataType: "json"
        });
    };

    var doAsyncPost = function (partialURL, jsonDataToPost) {
        var authorityToken = '';//$.cookie("sportItems_token");
        var fullUrl = baseURL + partialURL;
        return $.ajax({
            url: fullUrl,
            type: "POST",
            headers: {               
                "Content-Type":"application/json"
                
            },
            data: JSON.stringify(jsonDataToPost),
            dataType: "json"
        });
    };

    var doAsyncDelete = function (partialURL)
    {
        var authorityToken = '';//$.cookie("sportItems_token");
        var fullUrl = baseURL + partialURL;
        return $.ajax({
            url: fullUrl,
            type: "DELETE",
                        
            dataType: "json"
        });
    }

    var doAsyncPut = function (partialURL, jsonDataToPut) {
        var authorityToken = '';//$.cookie("sportItems_token");
        var fullUrl = baseURL + partialURL;
        return $.ajax({
            url: fullUrl,
            type: "PUT",
            headers: {               
                "Content-Type": "application/json"
            },
            data: JSON.stringify(jsonDataToPut),            
            dataType: "json"
        });
    };
	
	 this.setBaseURL = function (strBaseURL) {
        baseURL = strBaseURL;
    };

    this.getAllProducts = function () {
        var apiURL = "/api/products";
        return doAsyncGet(apiURL);
    };

    this.getAllCategories = function () {
        var apiURL = "/api/products/categories";
        return doAsyncGet(apiURL);
    };  

    this.getAllBasketball = function () {
        var apiURL = "/api/products/basketball";
        return doAsyncGet(apiURL);
    };  
	this.getAllSwimming = function () {
        var apiURL = "/api/products/swimming";
        return doAsyncGet(apiURL);
    }; 
	this.getAllYoga = function () {
        var apiURL = "/api/products/yoga";
        return doAsyncGet(apiURL);
    }; 
	this.getAllPilates = function () {
        var apiURL = "/api/products/pilates";
        return doAsyncGet(apiURL);
    }; 

    this.getProductById = function (id) {
        var apiURL = "/api/products/" + id;
        return doAsyncGet(apiURL);
    };

    this.addNewProduct = function (product) {
        var postURL = "/api/products";
        return doAsyncPost(postURL, product);
    };

    this.deleteProduct = function (productId)
    {
        var deleteURL = "/api/products/" + productId;
        return doAsyncDelete(deleteURL);
    }

    this.updateProduct = function (productData)
    {
        var putUrl = "/api/products/"+productData.id;
        return doAsyncPut(putUrl, productData);
    }
	this.getUserByUserName = function (userName)
    {
        var apiURL = "/api/user/" + userName;
        return doAsyncDelete(apiURL);
    }
	

    sportItemsAPI.instance = this;

}
