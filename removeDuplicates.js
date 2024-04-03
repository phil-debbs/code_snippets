function removeDuplicates(nums, value) {
  let k = nums.length;
  let i = 0;
  while (i < k) {
    if (nums[i] === value) {
      //splice to remove the 0
      nums.splice(i, 1);
    } else {
      i++;
    }
  }
}

console.log(removeDuplicates([3, 2, 2, 3], 3));
