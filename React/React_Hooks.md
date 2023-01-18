# React : Hooks 

Today I studied React
- useState

```jsx
import { useState } from 'react';

function App(){
  const [time,setTime] = useState(1);

  const handleClick = ()=>{
    let newTime;
    if(time>=12){
      newTime=1;
    }else{
      newTime=time+1
    }
    
    setTime(newTime);
  }
  return(
    <div>
      <span>Time: {time}</span>
      <button onClick={handleClick}>Update</button>  
    </div>
  );
}

export default App;

```


```jsx
import { useState } from 'react';



function App() {
    const [names, setName] = useState(["A", "B"]);
    const [input, setInput] = useState('');

    const handleInputChange = (e) => {
        setInput(e.target.value)
    };

    const handUpload = () => {
        setName((prevState) => { //callback
            return [input, ...prevState]
        });

    } //nfn
    return (
        <div>
            <input type="text" value={input} onChange={handleInputChange} />
            <button onClick={handUpload}>Upload</button>
            {names.map(name, index => { //key!
                return <p key={index}>{name}</p>;
            })}
        </div>
    )
}

export default App;

```

- useEffect
  - If you want to run code to handle a specific task When component has mounted, updated or unmounted, use useEffect
  - Receives a callback function as an argument
    > useEffect(()=>{});// runs everytime when a component renders

    > useEffect(()=>{},[value]);// dependency array ,runs when a component renders for the first time and when value has changed 


```jsx
import React,{ useState, useEffect } from 'react';



function App() {
    const [count, setCount] = useState(1);
    const [name, setName] =  useState("");

    const handleCountUpdate = () => {
        setCount(count + 1);
    };
    const handleInputChange = (e) => {
        setName(e.target.value);
    }
    
    useEffect(()=>{
      console.log('rendered');
    });
    
    useEffect(()=>{
      console.log('count changed');
    }, [count]);
    
    return (
        <div>
            <button onClick={handleCountUpdate}>Update</button>
            <span>count: {count}</span>
            <input type="text" value={name} onChange={handleInputChange} />
            <span>name: {name}</span>
        </div>
    );
}

export default App;

```
- useEffect
  - clean up
    > useEffect(()=>{
    > return()=>{}
    > },[]);

```jsx
import React,{ useState, useEffect } from 'react';
import Timer from '/Timer';

function App() {
    const [showTimer, setShowTimer] = useState(false);
    return (
        <div>
            {showTimer && <Timer/>}
            <button onClick={()=>{setShowTimer(!showTimer)}}>Toggle Timer</button>
        </div>
    );
}

export default App;

------------
import React,{ useEffect } from 'react'; 
const Timer = (props) => {

  useEffect(()=>{
    const timer = setInterval(()=>{
      console.log('Timer is working')
    },1000);
    
    return()=>{
     clearInterval(timer);
     console.log('Timer has finished') //clean up. runs when timer component unmounted
    }
    
  },[])//useEffect works only one time when timer component rendered for the first time with an empty array.
  
  return(
    <div>
      <span>Starting the timer. see the console</span>
    </div>
  )
};
  
export default Timer;
```
    

- useRef
- useContext
- useMemo
- useCallback
- useReducer
