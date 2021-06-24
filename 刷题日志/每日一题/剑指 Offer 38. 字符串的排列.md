```JavaScript
/**
 * @param {string} s
 * @return {string[]}
 */
var permutation = function (s) {
    const ans = Array.from(recursion(s));
    return ans;
};

function recursion(s) {
    const chars = s.split("");
    const ans = new Set();
    if (s.length == 1) {
        return s;
    }
    for (let char of chars) {
        let suffix = recursion(s.replace(char, ''));
        for (let fix of suffix) {
            ans.add(char + fix);
        }
    }
    return ans;
}
```