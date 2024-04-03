var containsNearbyAlmostDuplicate = function (nums, k, t) {
  //create an object out of the arrays. if a property is undefined then it's been repeated
  const arrObj = {};
  for (let i = 0; i < nums.length; i++) {
    const ele = nums[i];
    const val = arrObj[ele];
    console.log(ele, val, i);
    // console.log(val);
    if (val !== undefined && Math.abs(val - i) <= k) {
      return true; //key has repeated
    }
    arrObj[ele] = i;
  }
  console.log(arrObj);
  //Math.abs(nums[val] - nums[i])<=t &&
  return false;
};

let nums = [8, 7, 15, 1, 6, 1, 9, 15], //[1, 2, 3, 1],
  k = 1,
  t = 3;

console.log(containsNearbyAlmostDuplicate(nums, k, t));
