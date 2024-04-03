/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} left
 * @param {number} right
 * @return {ListNode}
 */
var reverseBetween = function (head, left, right) {
  if (left >= right || !head) {
    return head;
  }

  let leftNode = null;
  let cur = head;
  let temp = null;
  let i = left;
  while (i > 1 && cur) {
    if (i === 1) {
      leftNode = cur;
      break;
    }
    if (i === 2) {
      temp = cur;
    }
    i--;
  }
  cur = leftNode;
  let rightNode = null;
  let prev = null;
  let j = right - left;
  while (j > 1 && cur) {
    let next = cur.next;
    cur.next = prev;
    prev = cur;
    cur = next;
    j--;
  }

  temp.next = prev;
  return temp;
};

console.log(reverseBetween([1, 2, 3, 4, 5], 2, 4));
