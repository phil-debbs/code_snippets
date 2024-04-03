//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

//Solution:
/**
 * -loop through the elements of the array and check whether the current element is a complement of any other element:
 * i.e. if a key in complement object equals the current element. If so, then that means there exists two numbers in
 *  the array that add up to get the target number, return the index of those two numbers.
 * Otherwise, find the complement of the current element and add as a property in the complement object.
 * -The value of the property is the index of the current element.
 *
 * find the complement of each element of the array that add up to give the target
 * i.e comp = target - a[i]
 * -keep the complement and the index of the element whose complement you find in an object complement.
 * -The keys of the object would be the complements and the values would be the indices.
 *
 */

function twoSum(arr, target) {
  const complements = {};
  for (let i = 0; i < arr.length; i++) {
    const element = arr[i];
    const comp = target - element;
    if (complements[element] !== undefined) {
      //ie a complement is equal to the current element, so return
      return [complements[element], i]; //return indices of the two numbers. i is the index of the current element. complements[comp] will hold the index of the element whose complement is comp.
    }
    Integer.MIN;
    complements[comp] = i;
  }
  return false;
}

const nums = [3, 2, 4], //[(2, 7, 11, 15)],
  target = 6; // 9;

console.log(twoSum(nums, target));
