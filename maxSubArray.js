//
/**
 * Given an integer array nums, find the contiguous subarray (containing at least one number)
 * which has the largest sum and return its sum.
 * eg array [-2,1,-3,4,-1,2,1,-5,4]
 *
 * -Details
 * --This suggests that a subarray could be an array with only one element or more.
 * --The first element becomes the max subarray sum(max) and current sum (curSum). So max=[0], curSum[0] and start index of the subarray is 0
 * --Starting from the next elementin the array, add and assign that to curSum: curSum += nums[i].
 * --If curSum < nums[i], then replace curSum with nums[i] since then nums[i] now becomes the starting
 *   point for a new contiguous subarray whose sum is bigger than curSum. i becomes the start index of that subarray.
 *   Also, the number of elements in the subarray is set to 1;
 * --If curSum > max, then max = curSum and the number of elements in the subarray is incremented by 1.
 * --Loop until all elements have been parsed.
 *
 * @param {*} nums
 * @returns
 */
var maxSubArray = function (nums) {
  let max = nums[0];
  let curSum = nums[0];
  let startindex = 0;
  let numOfEle = 1;
  for (let i = 1; i < nums.length; i++) {
    let curElement = nums[i];
    curSum += curElement;

    if (curElement > curSum) {
      startindex = i;
      numOfEle = 1;
      curSum = curElement;
    }

    if (curSum > max) {
      max = curSum;
    } else {
      numOfEle++;
    }
  }

  return max;
};

const array = [1]; //[-2, 1, -3, 4, -1, 2, 1, -5, 4];

console.log(maxSubArray(array));
