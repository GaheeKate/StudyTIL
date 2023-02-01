#  ASP.NET - HTTP Client & Views

Today I studied ASP.NET - HTTP Client & Views

- Setting up an HTTP client
  - controller that can access the api data
    - new controller -> MVC 5 controller with read/write actions: allow user to communicate to web api with CRUD
    - write objective and curl first
    ```
    HttpClient client = new HttpClient(){};
    string url = "curl address";
    HttpResponseMessage response = client.GetAsync(url).Result;
   
    Debug.WriteLine(response.StatusCode)// status info from http response 

    IEnumerable<model name> varname = response.Content.ReadAsAsync<IEnumerable<model name>>().Result; // round bracket bc its a method

    return View(varname)-> Add view with MVC5 view
    ```
    - by id: add +id to url

</br>    
- rendering base CRUD with views
  - read
  ```
   @model Ienumerable<Application.Models.model name>
    @foreach(var name in Model)
    {
      @model name.col name
    }
  ```
