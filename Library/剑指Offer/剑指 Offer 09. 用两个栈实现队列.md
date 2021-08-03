[Link](https://leetcode-cn.com/problems/yong-liang-ge-zhan-shi-xian-dui-lie-lcof/)

```JavaScript
class CQueue {
    constructor() {
        this.mainStack = []
        this.sideStack = []
    }

    /** 
    * @param {number} value
    * @return {void}
    */
    appendTail(value) {
        this.mainStack.push(value)
        return
    }

    /**
     * @return {number}
     */
    deleteHead() {
        if (this.mainStack.length == 0) {
            return -1
        }
        while (this.mainStack.length > 0) {
            this.sideStack.push(this.mainStack.pop())
        }
        const res = this.sideStack.pop()
        while (this.sideStack.length > 0) {
            this.mainStack.push(this.sideStack.pop())
        }
        return res
    }
};

/**
 * Your CQueue object will be instantiated and called as such:
 * var obj = new CQueue()
 * obj.appendTail(value)
 * var param_2 = obj.deleteHead()
 */
```