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
- useRef
- useContext
- useMemo
- useCallback
- useReducer