## 使用二分法查找
>每次使用二分查找时,作为参照数的那个值在排序后的数组中的位置就确定了  
因此只需判断该参照数的位置[pos]和k的大小  
若[pos]==k: 则arr[pos]就是该数  
若[pos]<k: 则期望数在arr[pos]左边, 递归使用fuc(arr, begin, pos-1)  
若[pos]>k: 则期望数在arr[pos]右边, 递归使用fuc(arr, pos+1, end)  


```Java
public class Main 
{
    // BinarySearch
    // Return the index of piovt
    static int binarySearch(int[] arr, int begin, int end) 
    {
        int L = begin, R = end, pivot = arr[L];

        while (L < R) 
        {
            while (L < R && arr[R] >= pivot) 
            {
                R--;
            }
            arr[L++] = arr[R];            

            while (L < R && arr[L] <= pivot) 
            {
                L++;
            }
            arr[R--] = arr[L];
        }
        arr[L]=pivot;
        return L;
    }

    // Find the kth max number
    // Return the kth max number
    static int findKMaxNum(int[] arr, int begin, int end, int k) 
    {
        if (begin >= end) 
        {
            return arr[begin];
        }
        else
        {
            int middle = binarySearch(arr, begin, end);
            if (middle == k) 
            {
                return arr[middle];
            } 
            else if (middle > k) 
            {
                return findKMaxNum(arr, begin, middle - 1, k);
            } 
            else  //(middle < k) 
            {
                return findKMaxNum(arr, middle + 1, end, k);
            }
        }        
    }

    public static void main(String[] args) 
    {
        int arr[] = { 9, 5, 8, 2, 1, 0, 3, 6, 7, 4 };
        int k = 6;
        int len = arr.length;

        System.out.println(findKMaxNum(arr, 0, len - 1, k));
    }
}
```