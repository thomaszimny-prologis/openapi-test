using openapi_test.SendITApi;

var httpClient = new HttpClient();
var apiClient = new SendITApiClient(httpClient)
{
    BaseUrl = "http://s21514564.onlinehome-server.info:4210/"
};

try
{
	var cancelResponse = await apiClient.PackageV2_CancelAsync(new CancelRequest
	{
		ClientID = "0001",
		PackageID = "P1",
		WebServiceUser = "testUser",
		WebServicePassword = "testPassword"
	});

    Console.WriteLine($"Cancel Successful: Result: {cancelResponse.Result}");
}
catch (ApiException ex)
{
    Console.WriteLine($"Result: HTTP status {ex.StatusCode} Message: {ex.Response}");
}