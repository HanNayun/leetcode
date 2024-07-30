using JetBrains.Annotations;
using source._2900._2961;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2961
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[][] variables = [[2, 3, 3, 10], [3, 3, 3, 1], [6, 1, 1, 4]];
        int target = 2;
        int[] expected = [0, 2];
        CollectionAssert.AreEqual(expected, solution.GetGoodIndices(variables, target).ToArray());
    }

    [TestMethod]
    public void normal_case_2()
    {
        Solution solution = new();
        int[][] variables =
        [
            [30, 5, 43, 2], [15, 50, 35, 41], [45, 34, 41, 32], [14, 37, 33, 13], [6, 8, 1, 53], [37, 1, 12, 52],
            [42, 37, 2, 52], [9, 2, 15, 3], [31, 12, 21, 24], [52, 24, 6, 12], [51, 35, 21, 52], [30, 18, 10, 2],
            [27, 31, 50, 27], [29, 25, 26, 32], [15, 38, 43, 17], [22, 12, 16, 43], [48, 9, 15, 6], [41, 26, 22, 21],
            [41, 49, 52, 26], [53, 38, 9, 33]
        ];
        int target = 1;
        int[] expected = [5, 7, 8, 10, 17, 18];
        CollectionAssert.AreEqual(expected, solution.GetGoodIndices(variables, target).ToArray());
    }

    [TestMethod]
    public void normal_case_3()
    {
        Solution solution = new();
        int[][] variables =
        [
            [17, 44, 51, 27], [75, 46, 92, 49], [14, 89, 32, 37], [29, 15, 50, 56], [42, 47, 43, 42], [88, 22, 85, 48],
            [70, 8, 23, 35], [11, 25, 3, 17], [28, 69, 20, 43], [82, 42, 5, 87], [50, 87, 5, 24], [55, 19, 59, 53],
            [37, 29, 69, 19], [26, 25, 7, 63], [8, 14, 28, 49], [22, 25, 13, 11], [62, 78, 63, 50], [3, 67, 60, 31],
            [34, 40, 60, 10], [85, 62, 36, 35], [55, 19, 87, 22], [64, 8, 83, 81], [78, 49, 49, 85], [92, 51, 65, 65],
            [6, 44, 67, 18], [30, 58, 34, 74], [63, 80, 11, 90], [5, 13, 47, 33], [84, 71, 29, 3], [9, 77, 45, 11],
            [14, 23, 15, 89], [6, 31, 69, 69], [21, 84, 36, 82], [47, 85, 72, 53], [54, 81, 8, 40], [63, 80, 67, 84],
            [32, 28, 91, 12], [54, 18, 25, 35], [39, 69, 27, 15], [89, 10, 89, 92], [17, 66, 72, 13], [62, 39, 37, 65],
            [31, 84, 71, 2], [33, 89, 68, 27], [83, 54, 6, 50], [14, 49, 88, 54], [4, 43, 27, 12], [8, 4, 19, 46],
            [2, 18, 23, 18], [87, 51, 85, 22], [77, 3, 64, 69], [73, 31, 55, 47], [38, 85, 56, 29], [26, 60, 13, 88],
            [53, 7, 15, 60], [4, 15, 2, 16], [38, 86, 29, 37], [66, 2, 72, 78], [3, 75, 20, 78], [18, 87, 78, 44],
            [64, 83, 91, 37], [63, 20, 86, 59], [25, 35, 10, 40], [19, 20, 19, 21], [10, 39, 84, 45], [72, 34, 35, 22],
            [13, 36, 90, 64], [80, 26, 51, 42], [72, 3, 19, 83], [2, 34, 68, 14], [29, 52, 53, 17], [73, 91, 31, 82],
            [73, 84, 64, 69], [24, 83, 41, 3], [35, 51, 24, 66], [24, 21, 40, 75], [61, 9, 29, 83], [24, 58, 61, 37],
            [8, 51, 30, 76], [77, 16, 37, 18], [13, 58, 67, 84], [61, 2, 30, 13], [17, 66, 50, 65], [51, 76, 89, 54],
            [89, 18, 35, 65], [16, 57, 48, 87], [60, 43, 15, 60]
        ];
        int target = 34;
        int[] expected = [68];
        CollectionAssert.AreEqual(expected, solution.GetGoodIndices(variables, target).ToArray());
    }

    [TestMethod]
    public void empty_expected_result()
    {
        Solution solution = new();
        int[][] variables = [[39, 3, 1000, 1000]];
        int target = 17;
        int[] expected = [];
        CollectionAssert.AreEqual(expected, solution.GetGoodIndices(variables, target).ToArray());
    }
}