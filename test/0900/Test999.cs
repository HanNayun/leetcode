using JetBrains.Annotations;
using source._0900._999;

namespace test._0900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test999
{
    private Solution solution = new();
    private char[][] board;

    [TestMethod]
    public void TestSolution()
    {
        board =
        [
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', 'p', '.', '.', '.', '.'],
            ['.', '.', '.', 'R', '.', '.', '.', 'p'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', 'p', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
        ];
        Assert.AreEqual(3, solution.NumRookCaptures(board));

        board =
        [
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', 'p', 'p', 'p', 'p', 'p', '.', '.'],
            ['.', 'p', 'p', 'B', 'p', 'p', '.', '.'],
            ['.', 'p', 'B', 'R', 'B', 'p', '.', '.'],
            ['.', 'p', 'p', 'B', 'p', 'p', '.', '.'],
            ['.', 'p', 'p', 'p', 'p', 'p', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
        ];
        Assert.AreEqual(0, solution.NumRookCaptures(board));

        board =
        [
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', 'p', '.', '.', '.', '.'],
            ['.', '.', '.', 'p', '.', '.', '.', '.'],
            ['p', 'p', '.', 'R', '.', 'p', 'B', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', 'B', '.', '.', '.', '.'],
            ['.', '.', '.', 'p', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
        ];
        Assert.AreEqual(3, solution.NumRookCaptures(board));
    }
}