# React

Today I studied React
- npx create-react-app projname
  cd projname
  npm start
- node_modules: library code storage
- public: static files storage
- src: code storage. write codes here
- App.js: main page

- JSX syntax
  - class = className
  - {} =Data binding. to put variables 
  - style={} : to write style (eg:<h4 style={{ color: 'red', fontSize:'16px' }})></h4>
  - return(): JSX expressions must have one parent element

- Destructuring:allows you to pull out data from arrays and objects into distinct variables with concise syntax.
  > let[a,b]=[1,2];

- Why use state instead of variables?
because variables doesn't update html automatically. however state render html automatically. so if the used data is expected to change often, use state.

- /*eslint-disable */ : Disable Lint

- state compares existing state and updated state, if both are same, changes are not made
  > name[0]= Kate;
    changeName(name);  : the reason why this code is not working

  > let copy = name;
    copy[0]= Kate;000
    changeName(copy);  : variable copy is also pointing same data. copy == name? true

- Shallow copy[...name] : ... means strip array/object and [] means make it array/object

```jsx
/*eslint-disable */

import logo from './logo.svg';
import './App.css';
import { useState } from 'react';




function App() {

  let post = 'Toronto K-foods'; // this is the data from the server
  let [data, setData] = useState(['Bulgogi', 'Gamjatang', 'Soontofu'])
  let [likes, setLikes] = useState(0)
  return (
    <div className="App">
      <div className="black-nav">
        <h4>{post}</h4>
      </div>
      <div className='list'>
        <h4 style={{ color: 'red', fontSize: '20px' }} id={data[0]}>{data[0]} <span onClick={() => { { (setLikes(likes + 1)) } }}>👍</span> {likes} </h4>
        <button onClick={() => {
          let Copydata = [...data];
          Copydata[0] = "Pulgogi"
          setData(Copydata)
        }}>ChangeName</button>
        <p>Published in 2023-01-07</p>      </div>
      <div className='list'>
        <h4 style={{ color: 'red', fontSize: '20px' }} id={data[1]}>{data[1]} </h4>
        <p>Published in 2023-01-07</p>      </div>
      <div className='list'>
        <h4 style={{ color: 'red', fontSize: '20px' }} id={data[2]}>{data[2]} </h4>
        <p>Published in 2023-01-07</p>      </div>
    </div >
  );
}

export default App;

```