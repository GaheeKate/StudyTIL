# Node.js
 
Today I studied Node.js 

- to run JS in the server without browser
- npm module is like exe file
- npm init -> package.json (list modules) for maintenance
- npm i or install , uninstall
- express web framework module
- get: params, query
```js
const express = require('express')
const app = express()
var cors = require('cors')


app.use(cors())

app.get('/', function (req, res) { //http method, routing, callback func
    res.send('Hello World')
})

app.get('/dog', function (req, res) { //http method, routing, callback func
    res.json({ 'sound': "woof woof" })// json: js object notation
})

app.get('/cat', function (req, res) { //http method, routing, callback func
    res.send('Hello Cat')
})

//get 
app.get('/user/:id', function (req, res) { //http method, routing, callback func
    const q = req.params //    const q = req.query
    console.log(q)

    res.json({ 'userid': q.id })
})

//post
app.use(express.json());
app.post('/user/:id', function (req, res) { //http method, routing, callback func
    const q = req.params //    const q = req.query
    console.log(q)
    const b = req.body;
    console.log(b);

    res.send({ 'userid': 'HI' })
})


//ex. get sounds by name
app.get('/sound/:name', (req, res) => {
    const { name } = req.params
    if (name == 'dog') {
        res.json({ 'sound': "woof" })
    }
    else if (name == 'cat') { res.json({ 'sound': "meow" }) }
    else { res.json({ 'sound': 'unknown' }) }

})



app.listen(3000) //port listening to get a request
```

- cors:Cross-Origin Resource Sharing (CORS) is an HTTP-header based mechanism that allows a server to indicate any origins (domain, scheme, or port) other than its own from which a browser should permit loading resources. 

```js
//to respond to all request
const cors = require('cors');
app.use(cors({
    origin: '*'
}));
```
