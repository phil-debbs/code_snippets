const { performance } = require("perf_hooks"); //https://stackoverflow.com/a/50646335/5367889

function mergeSortedArrays(arr1, arr2) {
  //naive solution
  let t1 = performance.now();
  //O(a+b) + O(logn)
  const merge1 = [...arr1, ...arr2].sort((a, b) => a - b);
  let t2 = performance.now();
  console.log(merge1, " naive time: ", t2 - t1);

  //
  let i = 0,
    j = 0;
  let arr1item = arr1[0],
    arr2item = arr2[0];
  const merge2 = [];
  t1 = performance.now();
  while (arr1item || arr2item) {
    if (!arr2item || arr1item < arr2item) {
      merge2.push(arr1item);
      i++;
      arr1item = arr1[i];
    } else {
      merge2.push(arr2item);
      j++;
      arr2item = arr2[j];
    }
  }
  t2 = performance.now();
  console.log(merge2, " merge2 time: ", t2 - t1);
}

const array1 = [0, 3, 1, 31, 40, 100, 1, 5, 25, 10, 40, 100, 1, 5, 25, 10];
const array2 = [
  3, 4, 6, 30, 40, 100, 1, 5, 25, 10, 40, 100, 1, 5, 25, 10, 40, 100, 1, 5, 25,
  40, 100, 1, 5, 25, 10, 40, 100, 1, 5, 25, 10, 40, 100, 1, 5, 25, 10, 10,
];

console.log(mergeSortedArrays(array1, array2));
