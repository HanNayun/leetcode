[Link](https://leetcode-cn.com/problems/liang-ge-lian-biao-de-di-yi-ge-gong-gong-jie-dian-lcof/)

```JavaScript
/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

/**
 * @param {ListNode} headA
 * @param {ListNode} headB
 * @return {ListNode}
 */
var getIntersectionNode = function (headA, headB) {
    let pA = headA
    let pB = headB
    if(pA==null||pB==null){
        return null
    }
    while (true) {
        if (pA == pB) {
            return pA
        }
        if (pA.next == null && pB.next == null) {
            return null
        }
        if (pA.next == null) {
            pA = headB
        } else {
            pA = pA.next
        }
        if (pB.next == null) {
            pB = headA
        } else {
            pB = pB.next
        }
    }
};
```