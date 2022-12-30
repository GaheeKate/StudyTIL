# Node.js
 
Today I studied Node.js 

- to run JS in the server without browser
- npm module is like exe file
- npm init -> package.json (list modules) for maintenance
- npm i or install , uninstall
- express web framework module
- get: params, query
```js
console.log("hello")
const express = require('express')
const app = express()

app.get('/', function (req, res) { //http method, routing, callback func
    res.send('Hello World')
})

app.get('/dog', function (req, res) { //http method, routing, callback func
    res.json({ 'sound': "woof woof" })// json: js object notation
})

app.get('/cat', function (req, res) { //http method, routing, callback func
    res.send('Hello Cat')
})

app.listen(3000) //port listening to get a request
```

- cors
```js
const cors = require('cors');
app.use(cors({
    origin: '*'
}));
```