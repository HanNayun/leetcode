## Array
1. Create a 2D Array
```JavaScript
const arr = new Array(row_len).fill(0).map(()=>new Array(col_len).fill(0));
```

## Number
1. Aviod Number Overflow
```Javascript
let mid = left+ ((right-left)>>>1);
```