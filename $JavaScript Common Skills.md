## Array
1. Create a 2D Array
```JavaScript
const arr = new Array(row_len).fill(0).map(()=>new Array(col_len).fill(0))
```

## Number
1. Aviod Number Overflow
```Javascript
let mid = left + ((right - left) >>> 1)
```

## Map
1. quick judge
```JavaScript
map.set(key, (map.get(key) || 0) + nums)
```

## Function
1. Define a function that call immediately  
   you can not do this by using a arrow funciton
```JavaScript
(function myFunc(arg1, arg2){
    /*code*/
}(arg1, arg2))
```
