[Link](https://leetcode-cn.com/problems/lian-xu-zi-shu-zu-de-zui-da-he-lcof/)


## 解析
dp[i]=max(dp[i-1]+nums[i],nums[i])

```JavaScript
/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function (nums) {
    let pre = 0, ans = nums[0]
    for (let i of nums) {
        pre = Math.max(pre + i, i)
        ans = Math.max(ans, pre)
    }
    return ans
};
```