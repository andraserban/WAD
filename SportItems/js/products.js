function loadProducts()
{
    var sportItemsAPI = new sportItemsAPI();
    sportItemsAPI.setBaseURL("http://localhost:50311");

    sportItemsAPI.getAllProducts().done(function (response)
	{
		
		
	}
	
	);
}