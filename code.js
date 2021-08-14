const test = (board) => {
    const box = new Array(9).fill(0).map(() => new Set())
    const row = new Array(9).fill(0).map(() => new Set())
    const col = new Array(9).fill(0).map(() => new Set())
    for (let i = 0; i < 9; i++) {
        for (let j = 0; j < 9; j++) {
            const num = board[i][j]
            const zone = Math.floor(i / 3) * 3 + Math.floor(j / 3)
            if (num !== '.') {
                if (row[i].has(num) || col[j].has(num) || box[zone].has(num)) {
                    return false
                }
                row[i].add(num)
                col[j].add(num)
                box[zone].add(num)
            }
        }
    }
    return true
}



//Input

const par1 = [
    ["5", "3", ".", ".", "7", ".", ".", ".", "."],
    ["6", ".", ".", "1", "9", "5", ".", ".", "."],
    [".", "9", "8", ".", ".", ".", ".", "6", "."],
    ["8", ".", ".", ".", "6", ".", ".", ".", "3"],
    ["4", ".", ".", "8", ".", "3", ".", ".", "1"],
    ["7", ".", ".", ".", "2", ".", ".", ".", "6"],
    [".", "6", ".", ".", ".", ".", "2", "8", "."],
    [".", ".", ".", "4", "1", "9", ".", ".", "5"],
    [".", ".", ".", ".", "8", ".", ".", "7", "9"]
]

const par2 = [[1, 3, 2], [2, 3, 0], [1, 3, 0], [0, 2, 1]]
const par3 = [[1, 3], [0, 2]]

//Output
console.log(test(
    par1,
    par2,
    par3
))