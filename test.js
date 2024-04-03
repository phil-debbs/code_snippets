/**
 * @param {number[][]} grid
 * @return {number}
 */

let m = 0;
let n = 0;
let allGrid = [];
function area(r, c) {
  if (r < 0 || r >= m || c < 0 || c >= n || allGrid[r][c] <= 0) {
    return 0;
  }
  allGrid[r][c] = -1;
  return 1 + area(r + 1, c) + area(r - 1, c) + area(r, c + 1) + area(r, c - 1);
}
var maxAreaOfIsland = function (grid) {
  m = grid.length;
  n = grid[0].length;
  allGrid = grid;

  grid.splice();
  let ans = 0;
  for (let i = 0; i < m; i++) {
    for (let j = 0; j < n; j++) {
      ans = Math.max(ans, area(i, j));
    }
  }

  return ans;
};

console.log(
  maxAreaOfIsland([
    [0, 1, 1, 0],
    [0, 0, 0, 1],
  ])
);
