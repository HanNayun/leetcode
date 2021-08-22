[Link](https://leetcode-cn.com/problems/cong-shang-dao-xia-da-yin-er-cha-shu-iii-lcof/)

## Code
<hr/>

JavaScript
```JavaScript
/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[][]}
 */
var levelOrder = function (root) {
    const queue = [];
    const res = [];
    let direction = true;

    root && queue.push(root);
    while (queue.length) {
        const temp = [];
        const layer = [];
        while (queue.length) {
            const node = queue.shift();
            layer.push(node.val);
            node.left && temp.push(node.left);
            node.right && temp.push(node.right);
        }
        if (direction) {
            res.push(layer);
        }
        else {
            res.push(layer.reverse());
        }
        direction = !direction;
        queue.push(...temp);
    }
    return res;
};
```