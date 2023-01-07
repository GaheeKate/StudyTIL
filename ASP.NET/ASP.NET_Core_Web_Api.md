# ASP.NET Core Web Api

Today I studied ASP.NET Core Web Api

- Web API: HTTP service, RESTFul, easy to expand with Cloud 
- HTTP: application layer protocol. Stateless req-res protocol(A Stateless Protocol doesn't require a server to retain the information of a session or the status of every communicating partner in multiple requests) (https://www.rfc-editor.org/rfc/rfc2616)
- REST: REpresentational State Transfer, Stateless, Resource-based(URL), HTTP methods(GET,POST,PUT,DELETE),HATEOAS(Hypermedia as the Engine of Application State):using Link
- Web Api test tool: Postman, Fiddler, F12

- Data storage- Data Layer(EF)- Models- ASP.NET Web API- Json- Browsers

- Server gets the request- call middleware pipeline for reqs - MVC calls controller and action method for route reqs - send response thru middleware pipeline

- Tag helpers: Introduced with ASP.NET Core. Tag Helpers Enable server-side code to participate in creating and rendering HTML elements in Razor files.
- Action Result: A result of action methods/pages or return types of action methods/page handler. Action result is a parent class for many of the derived classes that have associated helpers.

- connect database using sql studio
 >   "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=.;Database=Bulky;Trusted_Connection=True;" // it didnt work on mine, I had to add 'TrustServerCertificate=True'
    }

- add migration AddCategoryToDatabase -> update-database
