# NodeJS REST API

Today I studied Node REST API
- Reading Rest API documentation
  - Request endpoint: The endpoint is the URL.
  - Request method: Get,Post, etc
  - headers: Should use specified header if the request requires specific headers. CURL, line with -H or --header  
  - body: some requests requires data to be sent in the body. cURL, -d 
- oauth: Authorization protocol

- Fetch: Javascript native api or library for HTTP requests

- RestApi became popular because it is for any web type of scripting language that you can make HTTP requests

- env module: .env file allow user to create custom variables. contain sensitive information and add it to gitignore 
> const dotenv = require("dotenv");
  dotenv.config();

- postman.com:test API request

```js
async function GetApi() {
  let reqUrl = `${baseurl}/add/ress`;

  let response = await fetch(
    reqUrl,
    {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        "api-version": "2",
        "api-key": process.env.TRAKT_CLIENT_ID //client id
      }
    }
  );
  return await response.json();
}

module.exports = {
    GetApi
};
```

- creating Rest API with node and express
  - app.get, app.post etc with page paths
``` js
//api/convert/cmtoin?cm=10
app.get("/api/convert/comtoin", (req,res)=>{
  let cm = req.query.cm;
  let converted = {
    length: cm / 2.54
  }; //convert cm to inches
  res.json(converted);// send Json obj with appropriate JSON headers
});

//Receive data { celsius:# }
//convert celsius to fahrenheit
app.post("/api/convert/ctof", (req,res)=>{
  let celsius = req.body.celsius;
  let converted = {
    (celsius*9/5)+32;
  };
  let fahrenheit = {
    temperature: convert
  }; 
  res.json(fahrenheit);
  });


```

- The GET Method
  - GET is used to request data from a specified resource.
  - Note that the query string (name/value pairs) is sent in the URL of a GET request:

- The POST Method
  - POST is used to send data to a server to create/update a resource.
  - The data sent to the server with POST is stored in the request body of the HTTP request: